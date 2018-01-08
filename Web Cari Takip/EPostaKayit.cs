using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Domain_Hosting
{
    public partial class EPostaKayit : Form
    {
        private static int EPostaID;
        private OleDbConnection con = new OleDbConnection(Dataconnect.connectline);

        public EPostaKayit()
        {
            InitializeComponent();
        }

        private void MusteriGetir()
        {
            var oldap = new OleDbDataAdapter(
                "select * from Musteriler WHERE (((Musteriler.IsActive)=True)) order by Ad", con);
            var Olddt = new DataTable();
            oldap.Fill(Olddt);
            DataRow dr = Olddt.NewRow();
            dr["Ad"] = "Lütfen Seçiniz";
            Olddt.Rows.InsertAt(dr, 0);
            FirmaCombo.DataSource = Olddt;
            FirmaCombo.DisplayMember = "Ad";
            FirmaCombo.ValueMember = "FirmaID";
        }

        private void WebHosting_Load(object sender, EventArgs e)
        {
            MusteriGetir();
            KeyPreview = true;
        }

        private void PostaEkle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(EpostaAd.Text) && !string.IsNullOrEmpty(EpostaSifre.Text) &&
                FirmaCombo.SelectedIndex != 0)
            {
                DialogResult dlg = MessageBox.Show("E - Posta Bilgileri Sisteme Kaydedilsin mi?", "Kaydetme Onay",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dlg == DialogResult.Yes)
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    OleDbTransaction tracnco = con.BeginTransaction();
                    try
                    {
                        var com1 = new OleDbCommand("Insert Into EPosta(Adres,Sifre) values(@A,@S)", con);
                        com1.Parameters.AddWithValue("@A", EpostaAd.Text);
                        com1.Parameters.AddWithValue("@S", EpostaSifre.Text);
                        com1.Transaction = tracnco;
                        if (com1.ExecuteNonQuery() > 0)
                        {
                            var com2 = new OleDbCommand("select MAX(PostaID) from EPosta", con, tracnco);
                            EPostaID = Convert.ToInt32(com2.ExecuteScalar());
                            com2.Transaction = tracnco;
                        }
                        var com3 = new OleDbCommand("Insert Into FirmaEPosta(PostaID,FirmaID) values(@P,@F)", con,
                            tracnco);
                        com3.Parameters.AddWithValue("@P", EPostaID);
                        com3.Parameters.AddWithValue("@F", Convert.ToInt32(FirmaCombo.SelectedValue));
                        com3.Transaction = tracnco;
                        if (com3.ExecuteNonQuery() > 0)
                        {
                            tracnco.Commit();
                            MessageBox.Show("E-Posta Kayıt Edildi.", "Kayıt", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Bilgi girişi iptal edildi", "Kayıt İptal", MessageBoxButtons.OK,
                                MessageBoxIcon.Stop);
                        }
                    }
                    catch (Exception Ex)
                    {
                        tracnco.Rollback();
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
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void WebHosting_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void MusteriEkleBtn_Click(object sender, EventArgs e)
        {
            var c = new Cari();
            c.ShowDialog();
            MusteriGetir();
        }
    }
}