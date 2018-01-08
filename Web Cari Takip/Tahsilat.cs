using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Domain_Hosting
{
    public partial class Tahsilat : Form
    {
        private OleDbConnection con = new OleDbConnection(Dataconnect.connectline);
        private DataTable dtDomain;
        private DataTable dtHosting;

        public Tahsilat()
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
            MusteriCombo.DataSource = Olddt;
            MusteriCombo.DisplayMember = "Ad";
            MusteriCombo.ValueMember = "FirmaID";
        }

        private void MusteriGetirAlt()
        {
            var oldap = new OleDbDataAdapter(
                "select * from Musteriler WHERE (((Musteriler.IsActive)=True)) order by Ad", con);
            var Olddt = new DataTable();
            oldap.Fill(Olddt);
            DataRow dr = Olddt.NewRow();
            dr["Ad"] = "Lütfen Seçiniz";
            Olddt.Rows.InsertAt(dr, 0);
            RaporMusteriGetirCombo.DataSource = Olddt;
            RaporMusteriGetirCombo.DisplayMember = "Ad";
            RaporMusteriGetirCombo.ValueMember = "FirmaID";
        }

        private void Tahsilat_Load(object sender, EventArgs e)
        {
            MusteriGetir();
            TahsilatGetirHepsi();
            KeyPreview = true;
            MusteriGetirAlt();
        }

        private void HizmetCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (HizmetCombo.Text != "Lütfen Seçiniz")
            {
                int SeciliID = Convert.ToInt32(MusteriCombo.SelectedValue);
                if (HizmetCombo.SelectedIndex == 0)
                {
                    UrunCombo.Enabled = true;
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
                        DataRow dr = dtHosting.NewRow();
                        dr["FtpAdres"] = "Lütfen Seçiniz";
                        dtHosting.Rows.InsertAt(dr, 0);
                        UrunCombo.DisplayMember = "FtpAdres";
                        UrunCombo.ValueMember = "HostID";
                        UrunCombo.DataSource = dtHosting;
                    }
                }
                else
                {
                    UrunCombo.Enabled = true;
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
                        DataRow dr = dtDomain.NewRow();
                        dr["DomainIsim"] = "Lütfen Seçiniz";
                        dtDomain.Rows.InsertAt(dr, 0);
                        UrunCombo.DisplayMember = "DomainIsim";
                        UrunCombo.ValueMember = "AlanID";
                        UrunCombo.DataSource = dtDomain;
                    }
                }
            }
            else
            {
                UrunCombo.Enabled = false;
            }
        }

        private void TahsilatGetir()
        {
            listView1.Items.Clear();
            var cmd =
                new OleDbCommand(
                    "SELECT Tahsilat.Hizmet, Tahsilat.Urun, Tahsilat.Bakiye, Tahsilat.Tarih, Tahsilat.Aciklama, Musteriler.Ad FROM Tahsilat INNER JOIN Musteriler ON Tahsilat.FirmaID = Musteriler.FirmaID WHERE (((Musteriler.FirmaID)=@ID))",
                    con);
            cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(RaporMusteriGetirCombo.SelectedValue));
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            OleDbDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    var list = new ListViewItem();
                    list.Text = rdr["Ad"].ToString();
                    list.SubItems.Add(rdr["Hizmet"].ToString());
                    list.SubItems.Add(rdr["Urun"].ToString());
                    list.SubItems.Add(rdr["Bakiye"].ToString());
                    list.SubItems.Add(rdr["Tarih"].ToString());
                    list.SubItems.Add(rdr["Aciklama"].ToString());
                    listView1.Items.Add(list);
                }
            }
            else
            {
                MessageBox.Show("Kayıt Bulunamadı !", "Arama", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
        }

        private void TahsilatGetirHepsi()
        {
            listView1.Items.Clear();
            var cmd =
                new OleDbCommand(
                    "SELECT Tahsilat.Hizmet, Tahsilat.Urun, Tahsilat.Bakiye, Tahsilat.Tarih, Tahsilat.Aciklama, Musteriler.Ad FROM Tahsilat INNER JOIN Musteriler ON Tahsilat.FirmaID = Musteriler.FirmaID",
                    con);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            OleDbDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                if (rdr.HasRows)
                {
                    var list = new ListViewItem();
                    list.Text = rdr["Ad"].ToString();
                    list.SubItems.Add(rdr["Hizmet"].ToString());
                    list.SubItems.Add(rdr["Urun"].ToString());
                    list.SubItems.Add(rdr["Bakiye"].ToString());
                    list.SubItems.Add(rdr["Tarih"].ToString());
                    list.SubItems.Add(rdr["Aciklama"].ToString());
                    listView1.Items.Add(list);
                }
            }
            con.Close();
        }

        private void Tahsilat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void MusteriCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MusteriCombo.SelectedIndex != 0)
            {
                HizmetCombo.Enabled = true;
            }
            else
            {
                HizmetCombo.Enabled = false;
            }
        }

        private void KayitekleBtn_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Tahsilat Kayıt Edilsin mi?", "Tahsilat Kayıt", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dlg == DialogResult.Yes)
            {
                if (HizmetCombo.Text != "Lütfen Seçiniz" && MusteriCombo.SelectedIndex != 0 &&
                    UrunCombo.SelectedIndex != 0 && !string.IsNullOrEmpty(tutarbox.Text))
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    OleDbTransaction trancik = con.BeginTransaction();
                    try
                    {
                        string Hizmet = HizmetCombo.Text;
                        string Urun = UrunCombo.Text;
                        string Tarih = Convert.ToString(DateTime.Now.ToLongDateString());
                        int FirmaIydim = Convert.ToInt32(MusteriCombo.SelectedValue);
                        var comgel =
                            new OleDbCommand(
                                "insert into Tahsilat(Hizmet,Urun,Bakiye,Tarih,Aciklama,FirmaID) values(@H,@U,@B,@D,@A,@F)",
                                con, trancik);
                        comgel.Parameters.AddWithValue("@H", Convert.ToString(HizmetCombo.Text));
                        comgel.Parameters.AddWithValue("@U", Convert.ToString(UrunCombo.Text));
                        comgel.Parameters.AddWithValue("@B", tutarbox.Text);
                        comgel.Parameters.AddWithValue("@D", Convert.ToString(dateTimePicker1.Value.ToLongDateString()));
                        comgel.Parameters.AddWithValue("@A", aciklamabox.Text);
                        comgel.Parameters.AddWithValue("@F", Convert.ToInt32(MusteriCombo.SelectedValue));
                        if (comgel.ExecuteNonQuery() > 0)
                        {
                            var comGun =
                                new OleDbCommand("Update Musteriler set Bakiye=Bakiye-@Bakiye where FirmaID=@ID", con,
                                    trancik);
                            comGun.Parameters.AddWithValue("@Bakiye", Convert.ToDouble(tutarbox.Text));
                            comGun.Parameters.AddWithValue("@ID", Convert.ToInt32(MusteriCombo.SelectedValue));

                            if (comGun.ExecuteNonQuery() > 0)
                            {
                                trancik.Commit();
                                TahsilatGetirHepsi();
                                MessageBox.Show("Tahsilat Kayıt Edildi.", "Kayıt", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                            }
                        }
                    }
                    catch (Exception Ex)
                    {
                        trancik.Rollback();
                        MessageBox.Show(Ex.ToString());
                    }
                    finally
                    {
                        con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Tüm Alanları Doldurunuz !", "Uyarı", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
        }

        private void TahBilgileriniGetirBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (RaporMusteriGetirCombo.SelectedIndex != 0)
                {
                    TahsilatGetir();
                }
                else
                {
                    MessageBox.Show("Lütfen müşteri seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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