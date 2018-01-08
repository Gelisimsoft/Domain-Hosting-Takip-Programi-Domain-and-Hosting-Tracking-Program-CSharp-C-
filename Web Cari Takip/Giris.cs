using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Domain_Hosting
{
    public partial class Giris : Form
    {
        private OleDbConnection con = new OleDbConnection(Dataconnect.connectline);

        public Giris()
        {
            InitializeComponent();
        }

        private void Giris_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
        }

        private void Giris_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var com = new OleDbCommand("select Kullanici,Sifre from Giris where GirisID=1", con);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            OleDbDataReader dr = com.ExecuteReader();
            try
            {
                while (dr.Read())
                {
                    if (dr.HasRows)
                    {
                        if (kullanicibox.Text == dr["Kullanici"].ToString() || sifrebox.Text == dr["Sifre"].ToString())
                        {
                            var ana = new AnaMenu();
                            ana.Show();
                            Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı adı ve şifre hatalı", "Hata", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Daha Sonra Tekrar Deneyiniz !!!");
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
                dr.Close();
            }
        }
    }
}