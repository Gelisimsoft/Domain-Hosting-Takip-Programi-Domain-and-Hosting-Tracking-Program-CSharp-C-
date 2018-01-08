using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Domain_Hosting
{
    public partial class EPosta : Form
    {
        private static int PostaninIDisi;
        private OleDbConnection con = new OleDbConnection(Dataconnect.connectline);

        public EPosta()
        {
            InitializeComponent();
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
                MessageBox.Show("' " + Unvanbox.Text + " '" + " Adına Ait Müşteri Bulunamamıştır.!");
                Unvanbox.Text = "";
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

        private void Temizlik()
        {
            foreach (Control c in groupBox3.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = string.Empty;
                }
            }
        }

        private void EPosta_Load(object sender, EventArgs e)
        {
            MusteriGetir();
            KeyPreview = true;
        }

        private void GetirEPostalar()
        {
            if (unvanlist.Items.Count != 0)
            {
                int SeciliID = Convert.ToInt32(unvanlist.SelectedValue);
                var da =
                    new OleDbDataAdapter(
                        "SELECT EPosta.Adres, EPosta.PostaID FROM (EPosta INNER JOIN FirmaEPosta ON EPosta.PostaID = FirmaEPosta.PostaID) INNER JOIN Musteriler ON FirmaEPosta.FirmaID = Musteriler.FirmaID WHERE (((EPosta.IsActive)=True) AND ((Musteriler.FirmaID)=@ID))",
                        con);
                da.SelectCommand.Parameters.AddWithValue("@ID", SeciliID);
                var dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    Maillist.DisplayMember = "Adres";
                    Maillist.ValueMember = "PostaID";
                    Maillist.DataSource = dt;
                }
            }
        }

        private void PostaEkle_Click(object sender, EventArgs e)
        {
            var com = new OleDbCommand("Update EPosta set Adres=@A,Sifre=@S where PostaID=@ID", con);
            com.Parameters.AddWithValue("@A", EpostaAd.Text);
            com.Parameters.AddWithValue("@S", EpostaSifre.Text);
            com.Parameters.AddWithValue("@ID", PostaninIDisi);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                if (com.ExecuteNonQuery() > 0)
                {
                    Temizlik();
                    GetirEPostalar();
                    MusteriGetir();
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
            if (Maillist.Items.Count != 0)
            {
                int PostamIDisi = Convert.ToInt32(Maillist.SelectedValue);
                var com =
                    new OleDbCommand("SELECT EPosta.PostaID,EPosta.Adres,EPosta.Sifre FROM EPosta where PostaID=@ID",
                        con);
                com.Parameters.AddWithValue("@ID", PostamIDisi);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                OleDbDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    if (dr.HasRows)
                    {
                        PostaninIDisi = Convert.ToInt32(dr["PostaID"]);
                        EpostaAd.Text = dr["Adres"].ToString();
                        EpostaSifre.Text = dr["Sifre"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Daha Sonra Tekrar Deneyiniz...", "Hata");
                    }
                }
                con.Close();
                dr.Close();
            }
        }

        private void unvanlist_Click(object sender, EventArgs e)
        {
            GetirEPostalar();
        }

        private void EPosta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var comSil = new OleDbCommand("update EPosta set IsActive=0 where PostaID=@ID ", con);
            comSil.Parameters.AddWithValue("@ID", PostaninIDisi);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                if (comSil.ExecuteNonQuery() > 0)
                {
                    Temizlik();
                    GetirEPostalar();
                    MusteriGetir();
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