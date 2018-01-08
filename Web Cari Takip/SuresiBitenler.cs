using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Domain_Hosting
{
    public partial class SuresiBitenler : Form
    {
        private OleDbConnection con = new OleDbConnection(Dataconnect.connectline);

        public SuresiBitenler()
        {
            InitializeComponent();
        }

        private void GetirBitenHostingleri(string Tarih)
        {
            var dap =
                new OleDbDataAdapter(
                    "SELECT Hosting.HostID, Hosting.FtpAdres FROM Hosting WHERE (((Hosting.Bitis)=@Gelen))", con);
            dap.SelectCommand.Parameters.AddWithValue("@Gelen", Tarih);
            var dt = new DataTable();
            dap.Fill(dt);
            if (dt.Rows.Count != 0)
            {
                HostinglistBox.DisplayMember = "FtpAdres";
                HostinglistBox.ValueMember = "HostID";
                HostinglistBox.DataSource = dt;
            }
            else
            {
                HostingSuresiLbl.Text = "Yenileme Süresi Yaklaşan Hosting Bulunamadı";
            }
        }

        private void GetirBitenDomainler(string Tarih)
        {
            var dapDomain =
                new OleDbDataAdapter(
                    "SELECT AlanAdiTablosu.AlanID, AlanAdiTablosu.DomainIsim FROM AlanAdiTablosu WHERE (((AlanAdiTablosu.DomainBitis)=@Gelen))",
                    con);
            dapDomain.SelectCommand.Parameters.AddWithValue("@Gelen", Tarih);
            var dt = new DataTable();
            dapDomain.Fill(dt);
            if (dt.Rows.Count != 0)
            {
                DomainlistBox.DisplayMember = "DomainIsim";
                DomainlistBox.ValueMember = "AlanID";
                DomainlistBox.DataSource = dt;
            }
            else
            {
                DomainSuresiLbl.Text = "Yenileme Süresi Yaklaşan Domain Bulunamadı";
            }
        }

        private void SuresiBitenler_Load(object sender, EventArgs e)
        {
            string Geliyor = AnaMenu.Tarihimiz;
            GetirBitenDomainler(Geliyor);
            GetirBitenHostingleri(Geliyor);
        }
    }
}