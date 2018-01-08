using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Domain_Hosting
{
    public partial class HostingRapor : Form
    {
        private static string GelenTutar;
        private static int HostinginIDisi;
        private OleDbConnection con = new OleDbConnection(Dataconnect.connectline);

        public HostingRapor()
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        private void HostingRapor_Load(object sender, EventArgs e)
        {
            MusteriGetir();
            KeyPreview = true;
        }

        private void GetirHostingler()
        {
            try
            {
                if (unvanlist.Items.Count != 0)
                {
                    int SeciliID = Convert.ToInt32(unvanlist.SelectedValue);
                    var da =
                        new OleDbDataAdapter(
                            "SELECT Hosting.HostID,Hosting.FtpAdres FROM (Hosting INNER JOIN FirmaHosting ON Hosting.HostID = FirmaHosting.HostID) INNER JOIN Musteriler ON FirmaHosting.FirmaID = Musteriler.FirmaID WHERE(((Hosting.IsActive)=True) AND ((Musteriler.FirmaID)=@ID))",
                            con);
                    da.SelectCommand.Parameters.AddWithValue("@ID", SeciliID);
                    var dt = new DataTable();
                    da.Fill(dt);
                    if (dt != null)
                    {
                        listBox1.DisplayMember = "FtpAdres";
                        listBox1.ValueMember = "HostID";
                        listBox1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        private void unvanlist_Click(object sender, EventArgs e)
        {
            GetirHostingler();
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.Items.Count != 0)
                {
                    int HostingIDisi = Convert.ToInt32(listBox1.SelectedValue);
                    var com =
                        new OleDbCommand(
                            "SELECT Hosting.HostID, Hosting.PKullanici, Hosting.PSifre, Hosting.FtpAdres, Hosting.FtpKullanici,Hosting.FtpSifre, Hosting.Baslangic, Hosting.Bitis,Hosting.Bakiye  FROM Hosting where HostID=@ID",
                            con);
                    com.Parameters.AddWithValue("@ID", HostingIDisi);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    OleDbDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            HostinginIDisi = Convert.ToInt32(dr["HostID"]);
                            Pkullanici.Text = dr["PKullanici"].ToString();
                            PSifre.Text = dr["PSifre"].ToString();
                            FtpAdres.Text = dr["FtpAdres"].ToString();
                            FtpKullanici.Text = dr["FtpKullanici"].ToString();
                            FtpSifre.Text = dr["FtpSifre"].ToString();
                            tutarhost.Text = dr["Bakiye"].ToString();
                            HostingBaslangic.Value = Convert.ToDateTime(dr["Baslangic"]);
                            HostingBitis.Value = Convert.ToDateTime(dr["Bitis"]);
                            GelenTutar = dr["Bakiye"].ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Daha Sonra Tekrar Deneyiniz...", "Hata");
                    }
                    dr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        private void HostingEkle_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Hosting Bilgileri Güncellensin mi?", "Güncellenme Onay",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlg == DialogResult.Yes)
            {
                try
                {
                    var com =
                        new OleDbCommand(
                            "Update Hosting set PKullanici=@PK,PSifre=@PS,FtpAdres=@FA,FtpKullanici=@FK,FtpSifre=@FS,Bakiye=@Bakiye,Baslangic=@BA,Bitis=@Bi where HostID=@ID",
                            con);
                    com.Parameters.AddWithValue("@PK", Pkullanici.Text);
                    com.Parameters.AddWithValue("@PS", PSifre.Text);
                    com.Parameters.AddWithValue("@FA", FtpAdres.Text);
                    com.Parameters.AddWithValue("@FK", FtpKullanici.Text);
                    com.Parameters.AddWithValue("@FS", FtpSifrelbl.Text);
                    com.Parameters.AddWithValue("@Bakiye", tutarhost.Text);
                    com.Parameters.AddWithValue("@BA", Convert.ToString(HostingBaslangic.Value.ToLongDateString()));
                    com.Parameters.AddWithValue("@Bi", Convert.ToString(HostingBitis.Value.ToLongDateString()));
                    com.Parameters.AddWithValue("@ID", HostinginIDisi);
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
                            ComBakiyeEkle.Parameters.AddWithValue("@Bak", tutarhost.Text);
                            ComBakiyeEkle.Parameters.AddWithValue("@ID", Convert.ToInt32(unvanlist.SelectedValue));
                            if (ComBakiyeEkle.ExecuteNonQuery() > 0)
                            {
                                MessageBox.Show("Bilgiler güncellendi.", "Güncelleme", MessageBoxButtons.OK,
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

        private void HostingRapor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Hosting Bilgileri Silinsin mi?", "Silinme Onay", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {
                try
                {
                    var comsil = new OleDbCommand("Update Hosting set IsActive=0 where HostID=@ID", con);
                    comsil.Parameters.AddWithValue("@ID", HostinginIDisi);
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