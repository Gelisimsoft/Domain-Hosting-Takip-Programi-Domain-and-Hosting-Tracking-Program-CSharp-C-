using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Domain_Hosting
{
    public partial class Passchange : Form
    {
        private OleDbConnection con = new OleDbConnection(Dataconnect.connectline);

        public Passchange()
        {
            InitializeComponent();
        }

        private void Passchange_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
        }

        private void Passchange_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var comgun = new OleDbCommand("update Giris set Kullanici=@K,Sifre=@S where GirisID=1", con);
                comgun.Parameters.AddWithValue("@K", kullanicibox.Text);
                comgun.Parameters.AddWithValue("@S", sifrebox.Text);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                if (comgun.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Kullanıcı adı ve şifre güncellendi.");
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