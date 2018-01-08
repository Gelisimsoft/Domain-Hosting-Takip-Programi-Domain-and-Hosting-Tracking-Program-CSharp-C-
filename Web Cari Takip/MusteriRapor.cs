using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Domain_Hosting
{
    public partial class MusteriRapor : Form
    {
        private static int SeciliID;
        private OleDbConnection con = new OleDbConnection(Dataconnect.connectline);

        public MusteriRapor()
        {
            InitializeComponent();
        }

        private void TemizlikEposta()
        {
            foreach (Control c in groupBox4.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = string.Empty;
                    YCep.Text = string.Empty;
                    Tlf.Text = string.Empty;
                    Faks.Text = string.Empty;
                }
            }
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
            var adp =
                new OleDbDataAdapter("select * from Musteriler where (((Musteriler.IsActive)=True)) AND Ad like @Ad",
                    con);
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
                MessageBox.Show("' " + Unvanbox.Text + " '" + " Adına Ait Cari Kayıt Bulunamamıştır.!");
                Unvanbox.Text = "";
            }
        }

        private void MusteriRapor_Load(object sender, EventArgs e)
        {
            MusteriGetir();
            KeyPreview = true;
        }

        private void Guncllbtn_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Güncellemek istediğinize emin misiniz?", "Güncelleme Onay",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dlg == DialogResult.Yes)
            {
                var comgun =
                    new OleDbCommand(
                        "update Musteriler set Ad=@Ad,Unvan=@Un,Yetkili=@Yet,Cep=@Cep,Telefon=@Telefon,Faks=@Faks,Posta=@Pos,Adres=@Adres,VDairesi=@VD,VergiNo=@VN,Web=@W where ((Musteriler.FirmaID)=@Firma)",
                        con);
                comgun.Parameters.AddWithValue("@Ad", FAdi.Text);
                comgun.Parameters.AddWithValue("@Un", FUnvan.Text);
                comgun.Parameters.AddWithValue("@Yet", YAdi.Text);
                comgun.Parameters.AddWithValue("@Cep", YCep.Text);
                comgun.Parameters.AddWithValue("@Telefon", Tlf.Text);
                comgun.Parameters.AddWithValue("@Faks", Faks.Text);
                comgun.Parameters.AddWithValue("@Pos", Eposta.Text);
                comgun.Parameters.AddWithValue("@Adres", Adres.Text);
                comgun.Parameters.AddWithValue("@VD", Vdairesi.Text);
                comgun.Parameters.AddWithValue("@VN", VNo.Text);
                comgun.Parameters.AddWithValue("@W", Webbox.Text);
                comgun.Parameters.AddWithValue("@Firma", SeciliID);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                try
                {
                    if (comgun.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Bilgiler Güncellendi.", "Güncelleme", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
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

        private void unvanlist_Click(object sender, EventArgs e)
        {
            if (unvanlist.Items.Count != 0)
            {
                SeciliID = Convert.ToInt32(unvanlist.SelectedValue);
                var com = new OleDbCommand("select* from Musteriler where FirmaID=@ID", con);
                com.Parameters.AddWithValue("@ID", SeciliID);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                OleDbDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    if (dr.HasRows)
                    {
                        int AlanIdisi = Convert.ToInt32(dr["FirmaID"].ToString());
                        FAdi.Text = dr["Ad"].ToString();
                        FUnvan.Text = dr["Unvan"].ToString();
                        YAdi.Text = dr["Yetkili"].ToString();
                        YCep.Text = dr["Cep"].ToString();
                        Tlf.Text = dr["Telefon"].ToString();
                        Faks.Text = dr["Faks"].ToString();
                        Eposta.Text = dr["Posta"].ToString();
                        Adres.Text = dr["Adres"].ToString();
                        Vdairesi.Text = dr["VDairesi"].ToString();
                        VNo.Text = dr["VergiNo"].ToString();
                        Bakiye.Text = dr["Bakiye"] + " TL";
                        Webbox.Text = dr["Web"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Daha Sonra Tekrar Deneyiniz !!!");
                    }
                }
                con.Close();
                dr.Close();
            }
        }

        private void MusteriRapor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Silmek istediğinize emin misiniz?", "Silme Onay",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dlg == DialogResult.Yes)
            {
                var comsil = new OleDbCommand("update Musteriler set IsActive=0 where FirmaID=@ID", con);
                comsil.Parameters.AddWithValue("@ID", Convert.ToInt32(unvanlist.SelectedValue));
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                try
                {
                    if (comsil.ExecuteNonQuery() > 0)
                    {
                        try
                        {
                            MessageBox.Show("Müşteri kaydı silindi.");
                            Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                            Close();
                        }
                        finally
                        {
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
    }
}