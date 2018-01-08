using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Domain_Hosting
{
    public partial class HostingKayit : Form
    {
        private static int HostID;
        private OleDbConnection con = new OleDbConnection(Dataconnect.connectline);

        public HostingKayit()
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

        private void HostingEkle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(AlinanFirmaBox.Text) && !string.IsNullOrEmpty(PanelAdresbox.Text) &&
                !string.IsNullOrEmpty(tutarhost.Text) && !string.IsNullOrEmpty(FtpAdres.Text) &&
                FirmaCombo.SelectedIndex != 0)
            {
                string Tarih = Convert.ToString(DateTime.Now.ToLongDateString());
                int IDim = Convert.ToInt32(FirmaCombo.SelectedValue);
                DialogResult dlg = MessageBox.Show("Hosting Bilgileri Sisteme Kaydedilsin mi?", "Kaydetme Onay",
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
                        var com1 =
                            new OleDbCommand(
                                "Insert Into Hosting(AlinanFirma,PAdres,PKullanici,PSifre,FtpAdres,FtpKullanici,FtpSifre,Baslangic,Bitis,Bakiye) values(@AF,@PD,@PK,@PS,@FA,@FK,@FS,@Bas,@Bit,@Bakiye)",
                                con);
                        com1.Parameters.AddWithValue("@AF", Convert.ToInt32(FirmaCombo.SelectedValue));
                        com1.Parameters.AddWithValue("@PD", PanelAdresbox.Text);
                        com1.Parameters.AddWithValue("@PK", Pkullanici.Text);
                        com1.Parameters.AddWithValue("@PS", PSifre.Text);
                        com1.Parameters.AddWithValue("@FA", FtpAdres.Text);
                        com1.Parameters.AddWithValue("@FK", FtpKullanici.Text);
                        com1.Parameters.AddWithValue("@FS", FtpSifre.Text);
                        com1.Parameters.AddWithValue("@Bas", Convert.ToString(HostingBaslangic.Value.ToLongDateString()));
                        com1.Parameters.AddWithValue("@Bit", Convert.ToString(HostingBitis.Value.ToLongDateString()));
                        com1.Parameters.AddWithValue("@Bakiye", tutarhost.Text);
                        com1.Transaction = tracnco;
                        if (com1.ExecuteNonQuery() > 0)
                        {
                            var com2 = new OleDbCommand("select MAX(HostID) from Hosting", con, tracnco);
                            HostID = Convert.ToInt32(com2.ExecuteScalar());
                            com2.Transaction = tracnco;

                            var com3 = new OleDbCommand("Insert Into FirmaHosting(FirmaID,HostID) values(@F,@H)", con,
                                tracnco);
                            com3.Parameters.AddWithValue("@F", Convert.ToInt32(FirmaCombo.SelectedValue));
                            com3.Parameters.AddWithValue("@H", HostID);
                            com3.Transaction = tracnco;
                            com3.ExecuteNonQuery();
                        }
                        var com4 = new OleDbCommand("Update Musteriler set Bakiye=Bakiye+@Bak where FirmaID=@ID", con);
                        com4.Parameters.AddWithValue("@Bak", tutarhost.Text);
                        com4.Parameters.AddWithValue("@ID", Convert.ToInt32(FirmaCombo.SelectedValue));
                        com4.Transaction = tracnco;
                        if (com4.ExecuteNonQuery() > 0)
                        {
                            tracnco.Commit();
                            MessageBox.Show("Hosting Kayıt Edildi.", "Kayıt", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            Close();
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
                else
                {
                    MessageBox.Show("Bilgi girişi iptal edildi", "Kayıt İptal", MessageBoxButtons.OK,
                        MessageBoxIcon.Stop);
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

        private void DomainEkleBtn_Click(object sender, EventArgs e)
        {
            var DK = new DomainKayit();
            DK.ShowDialog();
        }

        private void MusteriEkleBtn_Click(object sender, EventArgs e)
        {
            var c = new Cari();
            c.ShowDialog();
            MusteriGetir();
        }
    }
}