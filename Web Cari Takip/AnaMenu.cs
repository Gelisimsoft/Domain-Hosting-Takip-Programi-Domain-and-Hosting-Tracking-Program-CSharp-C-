using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Net.Sockets;
using System.Windows.Forms;

namespace Domain_Hosting
{
    public partial class AnaMenu : Form
    {
        public static string GidenUrun;
        public static string GidenEposta;
        public static string mustericep;
        public static string AdresLink;
        public static string Tarihimiz;
        private OleDbConnection con = new OleDbConnection(Dataconnect.connectline);

        public AnaMenu()
        {
            InitializeComponent();
        }

        private void AnaMenu_Load(object sender, EventArgs e)
        {
            MusteriGetir();
        }

        private void MusteriGetir()
        {
            var oldap =
                new OleDbDataAdapter(
                    "SELECT Musteriler.Ad as [Firma Adı], Musteriler.Unvan as [Firma Ünvan], Musteriler.Yetkili as [Firma Yetkilisi], Musteriler.Cep, Musteriler.Bakiye FROM Musteriler WHERE (((Musteriler.IsActive)=True)) order by Ad",
                    con);
            var Olddt = new DataTable();
            oldap.Fill(Olddt);
            if (Olddt.Rows.Count != 0)
            {
                dataGridView1.DataSource = Olddt;
                DataGridViewColumn columnFA = dataGridView1.Columns[0];
                columnFA.Width = 260;
                //
                DataGridViewColumn columnFU = dataGridView1.Columns[1];
                columnFU.Width = 160;
                //
                DataGridViewColumn columnYA = dataGridView1.Columns[2];
                columnYA.Width = 130;

            
            }
            else
            {
                KayitliMusteriLbl.Text = "Kayıt İşlemleri > Müşteri Kayıt menüsünden kayıt açabilirsiniz.";
            }
        }

        private void AnaMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }

        private void AnaMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void programcıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var a = new About();
            a.ShowDialog();
        }
        private void kullanıcıİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var pas = new Passchange();
            pas.Show();
        }

        private void bugünBitenlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tarihimiz = Convert.ToString(DateTime.Now.ToLongDateString());
            var SB = new SuresiBitenler();
            SB.Show();
        }

        private void günSonraBitenlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tarihimiz = Convert.ToString(DateTime.Now.AddMonths(1).ToLongDateString());
            var SB = new SuresiBitenler();
            SB.Show();
        }

        private void haftaSonraBitenlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tarihimiz = Convert.ToString(DateTime.Now.AddDays(7).ToLongDateString());
            var SB = new SuresiBitenler();
            SB.Show();
        }

        private void aySonraBitenlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tarihimiz = Convert.ToString(DateTime.Now.AddMonths(1).ToLongDateString());
            var SB = new SuresiBitenler();
            SB.Show();
        }

        private void domainRaporlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var DomRapor = new DomainRapor();
            DomRapor.ShowDialog();
        }

        private void müşteriRaporlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var MusRapor = new MusteriRapor();
            MusRapor.ShowDialog();
        }

        private void hostingRaporlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var HostRapor = new HostingRapor();
            HostRapor.ShowDialog();
        }

        private void ePostaRaporlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var postacik = new EPosta();
            postacik.ShowDialog();
        }

        private void tahsilatKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tahsil = new Tahsilat();
            tahsil.ShowDialog();
        }

        private void tahsilatRaporlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tah = new TahsilatRapor();
            tah.ShowDialog();
        }

        private void müşteriKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var MusteriCari = new Cari();
            MusteriCari.ShowDialog();
        }

        private void hostingKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var host = new HostingKayit();
            host.ShowDialog();
        }

        private void domainKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dk = new DomainKayit();
            dk.ShowDialog();
        }

        private void ePostaKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var EK = new EPostaKayit();
            EK.ShowDialog();
        }

        private void VersiyonBilgiLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.gelisimsoft.com");
        }
    }
}