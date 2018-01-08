using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Domain_Hosting
{
    public partial class DomainRapor : Form
    {
        private static int AlanIdisi;
        private static string GelenTutar;
        private OleDbConnection con = new OleDbConnection(Dataconnect.connectline);

        public DomainRapor()
        {
            InitializeComponent();
        }

        private void MusteriGetir()
        {
            var oldap = new OleDbDataAdapter(
                "select * from Musteriler WHERE (((Musteriler.IsActive)=True)) order by Ad", con);
            var Olddt = new DataTable();
            oldap.Fill(Olddt);
            unvanlist.DataSource = Olddt;
            unvanlist.DisplayMember = "Ad";
            unvanlist.ValueMember = "FirmaID";
        }

        private void unvanbtn_Click(object sender, EventArgs e)
        {
            try
            {
                var adp =
                    new OleDbDataAdapter(
                        "select * from Musteriler where (((Musteriler.IsActive)=True)) AND Ad like @Ad", con);
                adp.SelectCommand.Parameters.AddWithValue("@Ad", Unvanbox.Text + "%");
                var dt = new DataTable();
                adp.Fill(dt);
                if (dt.Rows.Count != 0)
                {
                    unvanlist.DataSource = dt;
                    unvanlist.DisplayMember = "Ad";
                    unvanlist.ValueMember = "FirmaID";
                }
                else
                {
                    MessageBox.Show("' " + Unvanbox.Text + " '" + " Adına Ait Müşteri Bulunamamıştır.!");
                    Unvanbox.Text = "";
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        private void DomainRapor_Load(object sender, EventArgs e)
        {
            MusteriGetir();
            KeyPreview = true;
        }

        private void unvanlist_Click(object sender, EventArgs e)
        {
            GetirDomainler();
        }

        private void GetirDomainler()
        {
            try
            {
                if (unvanlist.Items.Count != 0)
                {
                    int SeciliID = Convert.ToInt32(unvanlist.SelectedValue);
                    var da =
                        new OleDbDataAdapter(
                            "SELECT AlanAdiTablosu.AlanID, AlanAdiTablosu.DomainIsim FROM Musteriler INNER JOIN (AlanAdiTablosu INNER JOIN FirmaAlanAdi ON AlanAdiTablosu.AlanID = FirmaAlanAdi.AlanID) ON Musteriler.FirmaID = FirmaAlanAdi.FirmaID WHERE (((AlanAdiTablosu.IsActive)=True) AND ((Musteriler.FirmaID)=@ID)) ",
                            con);
                    da.SelectCommand.Parameters.AddWithValue("@ID", SeciliID);
                    var dt = new DataTable();
                    da.Fill(dt);
                    if (dt != null)
                    {
                        listBox1.DisplayMember = "DomainIsim";
                        listBox1.ValueMember = "AlanID";
                        listBox1.DataSource = dt;
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            if (unvanlist.Items.Count != 0)
            {
                try
                {
                    int DomaininIDisi = Convert.ToInt32(listBox1.SelectedValue);
                    var com =
                        new OleDbCommand(
                            "select AlanAdiTablosu.AlanID,AlanAdiTablosu.AlinanFirma,AlanAdiTablosu.DomainIsim,AlanAdiTablosu.Bakiye, AlanAdiTablosu.DomainBaslangic,AlanAdiTablosu.DomainBitis from AlanAdiTablosu where AlanID=@ID",
                            con);
                    com.Parameters.AddWithValue("@ID", DomaininIDisi);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    OleDbDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            AlanIdisi = Convert.ToInt32(dr["AlanID"]);
                            AlinanFirma.Text = dr["AlinanFirma"].ToString();
                            AlanAdi.Text = dr["DomainIsim"].ToString();
                            tutardomainbox.Text = dr["Bakiye"].ToString();
                            DomainBaslangic.Value = Convert.ToDateTime(dr["DomainBaslangic"]);
                            DomainBitis.Value = Convert.ToDateTime(dr["DomainBitis"]);
                            GelenTutar = dr["Bakiye"].ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Daha Sonra Tekrar Deneyiniz...", "Hata");
                    }
                    dr.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.ToString());
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void Guncllbtn_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Domain Bilgileri Güncellensin mi?", "Güncellenme Onay",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlg == DialogResult.Yes)
            {
                try
                {
                    var com =
                        new OleDbCommand(
                            "update AlanAdiTablosu set AlinanFirma=@AF,DomainIsim=@DI,DomainBaslangic=@DB,DomainBitis=@DBit where AlanID=@ID",
                            con);
                    com.Parameters.AddWithValue("@AF", AlinanFirma.Text);
                    com.Parameters.AddWithValue("@DI", AlanAdi.Text);
                    com.Parameters.AddWithValue("@DB", Convert.ToString(DomainBaslangic.Value.ToLongDateString()));
                    com.Parameters.AddWithValue("@DBit", Convert.ToString(DomainBitis.Value.ToLongDateString()));
                    com.Parameters.AddWithValue("@ID", AlanIdisi);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    if (com.ExecuteNonQuery() > 0)
                    {
                        var ComBakiyeSil = new OleDbCommand(
                            "update Musteriler set Bakiye=Bakiye-@Bak where FirmaID=@ID", con);
                        ComBakiyeSil.Parameters.AddWithValue("@Bak", GelenTutar);
                        ComBakiyeSil.Parameters.AddWithValue("@ID", Convert.ToInt32(unvanlist.SelectedValue));
                        if (ComBakiyeSil.ExecuteNonQuery() > 0)
                        {
                            var ComBakiyeEkle =
                                new OleDbCommand("update Musteriler set Bakiye=Bakiye+@Bak where FirmaID=@ID", con);
                            ComBakiyeEkle.Parameters.AddWithValue("@Bak", tutardomainbox.Text);
                            ComBakiyeEkle.Parameters.AddWithValue("@ID", Convert.ToInt32(unvanlist.SelectedValue));
                            if (ComBakiyeEkle.ExecuteNonQuery() > 0)
                            {
                                MessageBox.Show("Bilgiler güncellendi.", "Güncelle", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                                Close();
                            }
                        }
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.ToString());
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void DomainRapor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Domain Bilgileri Silinsin mi?", "Silinme Onay", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dlg == DialogResult.Yes)
            {
                try
                {
                    var comsil = new OleDbCommand("update AlanAdiTablosu set IsActive=0 where AlanID=@ID", con);
                    comsil.Parameters.AddWithValue("@ID", AlanIdisi);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    if (comsil.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Bilgiler silindi.", "Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.ToString());
                }
                finally
                {
                    con.Close();
                }
            }
        }
    }
}