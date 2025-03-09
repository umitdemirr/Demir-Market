using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace StokTakip
{
    public partial class Stok_Sil : Form
    {
        string urun;
        public Stok_Sil()
        {
            InitializeComponent();
        }
        private void VeriTablosu()
        {
            string veriler = "Select * From Urunler";
            DbContext db = new DbContext();
            db.connection.Open();
            OleDbDataAdapter da = new OleDbDataAdapter(veriler, db.connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGrid_urunler.DataSource = ds.Tables[0];
            db.connection.Close();
        }
        private void Stok_Sil_Load(object sender, EventArgs e)
        {
            VeriTablosu();
            cboxVeriCek();
        }
        private void btn_oncekiMenu_Click(object sender, EventArgs e)
        {
            Stok_Yonetim_Menusu stokYonetimMenusu = new Stok_Yonetim_Menusu();
            this.Close();
            stokYonetimMenusu.Show();
        }
        private void btn_yenile_Click(object sender, EventArgs e)
        {
            VeriTablosu();
        }
        private void cboxVeriCek()
        {
            try
            {
                DbContext db = new DbContext();
                db.connection.Open();
                string sorgu = "SELECT UrunAdi FROM Urunler";
                OleDbCommand command = new OleDbCommand(sorgu, db.connection);
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    cbox_urunAdi.Items.Add(reader["UrunAdi"]);
                }
                db.connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata : " + ex.Message);
            }
        }
        private void btn_sil_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show(urun + " adlı veriyi VeriTabanından Silmek Üzeresiniz Emin Misiniz ?","Veri Silme İşlemi" , MessageBoxButtons.YesNo);
            if (sonuc == DialogResult.Yes)
            {
                try
                {
                    DbContext db = new DbContext();
                    db.connection.Open();

                    string sorgu = "SELECT ID FROM Urunler WHERE UrunAdi = " + urun;
                    OleDbCommand command = new OleDbCommand(sorgu, db.connection);
                    command.Parameters.AddWithValue("@urun", urun);
                    object obje = command.ExecuteScalar();
                    string id = obje.ToString();

                    string sorgu2 = "DELETE FROM Urunler WHERE ID = " + id;
                    OleDbCommand command2 = new OleDbCommand(sorgu2, db.connection);
                    command2.Parameters.AddWithValue("@id", id);

                    int calistiMi = command2.ExecuteNonQuery();
                    if (calistiMi > 0)
                        MessageBox.Show("Satır Silindi");
                    else
                        MessageBox.Show("Satır Silinemedi, Tekrar Deneyin!");
                    db.connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata : " + ex.Message);
                }
            }
        }
        private void cbox_urunAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            object obj = cbox_urunAdi.SelectedItem;
            urun = obj.ToString();
        }
    }
}