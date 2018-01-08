using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Domain_Hosting
{
    public partial class Cari : Form
    {
        private OleDbConnection con = new OleDbConnection(Dataconnect.connectline);

        public Cari()
        {
            InitializeComponent();
        }

        private void Ekle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(FAdi.Text) && !string.IsNullOrEmpty(FUnvan.Text) &&
                !string.IsNullOrEmpty(YAdi.Text))
            {
                var con = new OleDbConnection(Dataconnect.connectline);
                DialogResult dlg = MessageBox.Show("Müşteri Bilgileri Sisteme Kaydedilsin mi?", "Kaydetme Onay",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dlg == DialogResult.Yes)
                {
                    var comcuk =
                        new OleDbCommand(
                            "Insert Into Musteriler(Ad,Unvan,Yetkili,Cep,Telefon,Faks,Posta,Adres,VDairesi,VergiNo,Web) values(@A,@U,@Y,@C,@T,@F,@P,@Ad,@VD,@VN,@Web)",
                            con);
                    comcuk.Parameters.AddWithValue("@A", FAdi.Text);
                    comcuk.Parameters.AddWithValue("@U", FUnvan.Text);
                    comcuk.Parameters.AddWithValue("@Y", YAdi.Text);
                    comcuk.Parameters.AddWithValue("@C", YCep.Text);
                    comcuk.Parameters.AddWithValue("@T", Tlf.Text);
                    comcuk.Parameters.AddWithValue("@F", Faks.Text);
                    comcuk.Parameters.AddWithValue("@P", Eposta.Text);
                    comcuk.Parameters.AddWithValue("@Ad", Adres.Text);
                    comcuk.Parameters.AddWithValue("@VD", Vdairesi.Text);
                    comcuk.Parameters.AddWithValue("@VN", VNo.Text);
                    comcuk.Parameters.AddWithValue("@Web", Webbox.Text);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    try
                    {
                        if (comcuk.ExecuteNonQuery() > 0)
                        {
                            Temizlik();
                        }
                        GetirBilgi();
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
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }

        private void Temizlik()
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    c.Text = string.Empty;
                    YCep.Text = string.Empty;
                    Faks.Text = string.Empty;
                    Tlf.Text = string.Empty;
                }
            }
        }

        private void Temizle_Click(object sender, EventArgs e)
        {
            Temizlik();
        }

        private void GetirBilgi()
        {
            listView1.Items.Clear();
            var cmd =
                new OleDbCommand(
                    "SELECT Musteriler.Ad, Musteriler.Unvan, Musteriler.Yetkili, Musteriler.Cep FROM Musteriler WHERE (((Musteriler.IsActive)=True)) order by Ad",
                    con);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            OleDbDataReader rdr = cmd.ExecuteReader();
            if (rdr != null)
            {
                while (rdr.Read())
                {
                    var list = new ListViewItem();
                    list.Text = rdr["Ad"].ToString();
                    list.SubItems.Add(rdr["Unvan"].ToString());
                    list.SubItems.Add(rdr["Yetkili"].ToString());
                    list.SubItems.Add(rdr["Cep"].ToString());
                    listView1.Items.Add(list);
                }
            }
            else
            {
                MessageBox.Show("Listelenecek Kayıt Bulunamadı", "Raporlama Sonuç", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            con.Close();
        }

        private void Cari_Load(object sender, EventArgs e)
        {
            GetirBilgi();
            KeyPreview = true;
        }

        private void Cari_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
            else if (e.KeyCode == Keys.F5)
            {
                GetirBilgi();
            }
        }
    }
}