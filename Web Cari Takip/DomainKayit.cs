using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Domain_Hosting
{
    public partial class DomainKayit : Form
    {
        private static int AlanID;
        private OleDbConnection con = new OleDbConnection(Dataconnect.connectline);

        public DomainKayit()
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

        private void DomainEkle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(AlinanFirma.Text) && !string.IsNullOrEmpty(AlanAdi.Text) &&
                !string.IsNullOrEmpty(tutardomainbox.Text) && FirmaCombo.SelectedIndex != 0)
            {
                string Tarih = Convert.ToString(DateTime.Now.ToLongDateString());
                int IDim = Convert.ToInt32(FirmaCombo.SelectedValue);
                DialogResult dlg = MessageBox.Show("Domain Bilgileri Sisteme Kaydedilsin mi?", "Kaydetme Onay",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dlg == DialogResult.Yes)
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    try
                    {
                        DomainEkleMetot();
                        SonDomainIDYakala();
                        FirmaDomain();
                        DomainBakiyeGuncelle();
                        MessageBox.Show("Domain Kayıt Edildi.", "Kayıt", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        Close();
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
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void DomainEkleMetot()
        {
            var com =
                new OleDbCommand(
                    "Insert Into AlanAdiTablosu(AlinanFirma,DomainIsim,Bakiye,DomainBaslangic,DomainBitis) values(@AlinanFirma,@DomainIsim,@Bakiye,@Baslangic,@Bitis)",
                    con);
            com.Parameters.AddWithValue("@AlinanFirma", AlinanFirma.Text);
            com.Parameters.AddWithValue("@DomainIsim", AlanAdi.Text);
            com.Parameters.AddWithValue("@Bakiye", tutardomainbox.Text);
            com.Parameters.AddWithValue("@Baslangic", Convert.ToString(DomainBaslangic.Value.ToLongDateString()));
            com.Parameters.AddWithValue("@Bitis", Convert.ToString(DomainBitis.Value.ToLongDateString()));
            com.ExecuteNonQuery();
        }

        private void SonDomainIDYakala()
        {
            var com2 = new OleDbCommand("select MAX(AlanID) from AlanAdiTablosu", con);
            AlanID = Convert.ToInt32(com2.ExecuteScalar());
        }

        private void FirmaDomain()
        {
            var com3 = new OleDbCommand("Insert Into FirmaAlanAdi(FirmaID,AlanID) values(@F,@A)", con);
            com3.Parameters.AddWithValue("@F", Convert.ToInt32(FirmaCombo.SelectedValue));
            com3.Parameters.AddWithValue("@A", AlanID);
            com3.ExecuteNonQuery();
        }

        private void DomainBakiyeGuncelle()
        {
            var comBakiye = new OleDbCommand("Update Musteriler set Bakiye=Bakiye+@Bak where FirmaID=@ID", con);
            comBakiye.Parameters.AddWithValue("@Bak", tutardomainbox.Text);
            comBakiye.Parameters.AddWithValue("@ID", Convert.ToInt32(FirmaCombo.SelectedValue));
            comBakiye.ExecuteNonQuery();
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