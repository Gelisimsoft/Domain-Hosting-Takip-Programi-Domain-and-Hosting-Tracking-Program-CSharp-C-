using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Domain_Hosting
{
    public partial class TahsilatRapor : Form
    {
        private static int TahsilatIDisi;
        private static string Gelentutar;
        private OleDbConnection con = new OleDbConnection(Dataconnect.connectline);
        private DataTable dtDomain;
        private DataTable dtHosting;

        public TahsilatRapor()
        {
            InitializeComponent();
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
                MessageBox.Show("' " + Unvanbox.Text + " '" + " Adına Ait Müşteri Bulunamamıştır.!");
                Unvanbox.Text = "";
            }
        }

        private void Guncllbtn_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Güncellemek istediğinize emin misiniz?", "Güncelleme Onay",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dlg == DialogResult.Yes)
            {
                var comgel =
                    new OleDbCommand(
                        "Update Tahsilat set Hizmet=@H,Urun=@U,Bakiye=@B,Tarih=@D,Aciklama=@A,FirmaID=@F where TahsilatID=@ID",
                        con);
                comgel.Parameters.AddWithValue("@H", Convert.ToString(HizmetCombo.Text));
                comgel.Parameters.AddWithValue("@U", Convert.ToString(UrunCombo.Text));
                comgel.Parameters.AddWithValue("@B", tutarbox.Text);
                comgel.Parameters.AddWithValue("@D", Convert.ToString(dateTimePicker1.Value.ToLongDateString()));
                comgel.Parameters.AddWithValue("@A", aciklamabox.Text);
                comgel.Parameters.AddWithValue("@F", Convert.ToInt32(unvanlist.SelectedValue));
                comgel.Parameters.AddWithValue("@ID", TahsilatIDisi);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                try
                {
                    if (comgel.ExecuteNonQuery() > 0)
                    {
                        var ComBakSil = new OleDbCommand("update Musteriler set Bakiye=Bakiye+@Bak where FirmaID=@ID",
                            con);
                        ComBakSil.Parameters.AddWithValue("@Bak", Gelentutar);
                        ComBakSil.Parameters.AddWithValue("@ID", Convert.ToInt32(unvanlist.SelectedValue));
                        if (ComBakSil.ExecuteNonQuery() > 0)
                        {
                            var ComBakiyeEk =
                                new OleDbCommand("update Musteriler set Bakiye=Bakiye-@Bak where FirmaID=@ID", con);
                            ComBakiyeEk.Parameters.AddWithValue("@Bak", tutarbox.Text);
                            ComBakiyeEk.Parameters.AddWithValue("@ID", Convert.ToInt32(unvanlist.SelectedValue));
                            if (ComBakiyeEk.ExecuteNonQuery() > 0)
                            {
                                var comOzet =
                                    new OleDbCommand(
                                        "insert into Ozet(Hizmet,Urun,Tahsilat,Tarih,Aciklama,FirmaID) values(@H,@U,@S,@T,@A,@F)",
                                        con);
                                comOzet.Parameters.AddWithValue("@H", Convert.ToString(HizmetCombo.Text));
                                comOzet.Parameters.AddWithValue("@U", Convert.ToString(UrunCombo.Text));
                                comOzet.Parameters.AddWithValue("@S", tutarbox.Text);
                                comOzet.Parameters.AddWithValue("@T", Convert.ToString(DateTime.Now.ToLongDateString()));
                                comOzet.Parameters.AddWithValue("@A", "Güncelleme");
                                comOzet.Parameters.AddWithValue("@F", Convert.ToInt32(unvanlist.SelectedValue));
                                if (comOzet.ExecuteNonQuery() > 0)
                                {
                                    Close();
                                }
                            }
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

        private void GetirTahsilatlari()
        {
            if (unvanlist.Items.Count != 0)
            {
                int SeciliID = Convert.ToInt32(unvanlist.SelectedValue);
                var da =
                    new OleDbDataAdapter(
                        "SELECT Tahsilat.TahsilatID, Tahsilat.Urun FROM Tahsilat INNER JOIN Musteriler ON Tahsilat.FirmaID = Musteriler.FirmaID WHERE (((Tahsilat.IsActive)=True) AND ((Musteriler.FirmaID)=@ID))",
                        con);
                da.SelectCommand.Parameters.AddWithValue("@ID", SeciliID);
                var dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    TahsilatGroupBox.Enabled = true;
                    listBox1.DisplayMember = "Urun";
                    listBox1.ValueMember = "TahsilatID";
                    listBox1.DataSource = dt;
                }
                else
                {
                    TahsilatGroupBox.Enabled = false;
                }
            }
        }

        private void TahsilatRapor_Load(object sender, EventArgs e)
        {
            MusteriGetir();
            KeyPreview = true;
        }

        private void TahsilatRapor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void unvanlist_Click(object sender, EventArgs e)
        {
            GetirTahsilatlari();
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count != 0)
            {
                TahsilatIDisi = Convert.ToInt32(listBox1.SelectedValue);
                var com =
                    new OleDbCommand(
                        "SELECT Tahsilat.Hizmet, Tahsilat.Urun, Tahsilat.Bakiye, Tahsilat.Tarih, Tahsilat.Aciklama FROM Tahsilat WHERE (((Tahsilat.TahsilatID)=@ID))",
                        con);
                com.Parameters.AddWithValue("@ID", TahsilatIDisi);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                OleDbDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    if (dr.HasRows)
                    {
                        HizmetCombo.Text = dr["Hizmet"].ToString();
                        UrunCombo.Text = dr["Urun"].ToString();
                        dateTimePicker1.Value = Convert.ToDateTime(dr["Tarih"]);
                        tutarbox.Text = Convert.ToString(dr["Bakiye"]);
                        aciklamabox.Text = dr["Aciklama"].ToString();
                        Gelentutar = dr["Bakiye"].ToString();
                        GuncellemeGroupBox.Enabled = true;
                    }
                    else
                    {
                        GuncellemeGroupBox.Enabled = false;
                    }
                }
                con.Close();
                dr.Close();
            }
        }

        private void HizmetCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int SeciliID = Convert.ToInt32(unvanlist.SelectedValue);
            if (HizmetCombo.SelectedIndex == 0)
            {
                if (dtDomain != null)
                {
                    dtDomain.Dispose();
                }
                var daHosting =
                    new OleDbDataAdapter(
                        "SELECT Hosting.HostID, Hosting.FtpAdres FROM (Hosting INNER JOIN FirmaHosting ON Hosting.HostID = FirmaHosting.HostID) INNER JOIN Musteriler ON FirmaHosting.FirmaID = Musteriler.FirmaID WHERE (((Musteriler.FirmaID)=@ID))",
                        con);
                daHosting.SelectCommand.Parameters.AddWithValue("@ID", SeciliID);
                dtHosting = new DataTable();
                daHosting.Fill(dtHosting);
                if (dtHosting != null)
                {
                    UrunCombo.DisplayMember = "FtpAdres";
                    UrunCombo.ValueMember = "HostID";
                    UrunCombo.DataSource = dtHosting;
                }
            }
            else
            {
                if (dtHosting != null)
                {
                    dtHosting.Dispose();
                }
                var dadomain =
                    new OleDbDataAdapter(
                        "SELECT AlanAdiTablosu.AlanID, AlanAdiTablosu.DomainIsim FROM Musteriler INNER JOIN (AlanAdiTablosu INNER JOIN FirmaAlanAdi ON AlanAdiTablosu.AlanID = FirmaAlanAdi.AlanID) ON Musteriler.FirmaID = FirmaAlanAdi.FirmaID WHERE (((Musteriler.FirmaID)=@ID))",
                        con);
                dadomain.SelectCommand.Parameters.AddWithValue("@ID", SeciliID);
                dtDomain = new DataTable();
                dadomain.Fill(dtDomain);
                if (dtDomain != null)
                {
                    UrunCombo.DisplayMember = "DomainIsim";
                    UrunCombo.ValueMember = "AlanID";
                    UrunCombo.DataSource = dtDomain;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Silmek istediğinize emin misiniz?", "Silme Onay",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dlg == DialogResult.Yes)
            {
                var comSil = new OleDbCommand("Update Tahsilat set IsActive=0 where TahsilatID=@ID", con);
                comSil.Parameters.AddWithValue("@ID", TahsilatIDisi);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                try
                {
                    if (comSil.ExecuteNonQuery() > 0)
                    {
                        var comSil2 = new OleDbCommand("delete from Ozet where Hizmet=@H and Urun=@U", con);
                        comSil2.Parameters.AddWithValue("@H", HizmetCombo.Text);
                        comSil2.Parameters.AddWithValue("@U", UrunCombo.Text);
                        if (comSil2.ExecuteNonQuery() > 0)
                        {
                            Close();
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