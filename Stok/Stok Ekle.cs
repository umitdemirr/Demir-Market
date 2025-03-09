
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace StokTakip
{
    public partial class Stok_Ekle : Form
    {
        public Stok_Ekle()
        {
            InitializeComponent();
        }
        private void Stok_Ekle_Load(object sender, EventArgs e)
        {
            VeriTablosu();
            cboxVeriCek();
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
        private void btn_kategoriEkle_Click(object sender, EventArgs e)
        {
            Kategori_Ekle kategoriEkle = new Kategori_Ekle();
            kategoriEkle.ShowDialog();
        }
        private void cboxVeriCek()
        {
            try
            {
                DbContext db = new DbContext();
                db.connection.Open();
                string sorgu = "SELECT KategoriAdi FROM Kategori";
                OleDbCommand command = new OleDbCommand(sorgu, db.connection);
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    cbox_kategori.Items.Add(reader["KategoriAdi"]);
                }
                db.connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata : " + ex.Message);
            }
        }
        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            bool intMi = true;
            while (intMi)
            {
                try
                {
                    int biriFiyat = Convert.ToInt32(tbox_birimFiyat.Text);
                    int urunAded = Convert.ToInt32(tbox_urunAdedi.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata : " + ex.Message);
                    break;
                }

                try
                {
                    string urunAdi = tbox_urunAdi.Text;
                    string urunAdedi = tbox_urunAdedi.Text;
                    string birimFiyat = tbox_birimFiyat.Text;
                    string kategori = cbox_kategori.Text;

                    DbContext db = new DbContext();
                    db.connection.Open();

                    string veri = "INSERT INTO Urunler (UrunAdi, UrunAdedi, UrunBirimFiyat) VALUES (urunAdi, urunAdedi, birinFiyat)";
                    OleDbCommand command = new OleDbCommand(veri, db.connection);
                    command.Parameters.AddWithValue("@urunAdi", urunAdi);
                    command.Parameters.AddWithValue("@urunAdedi", urunAdedi);
                    command.Parameters.AddWithValue("@urunBirimFiyat", birimFiyat);

                    int a = command.ExecuteNonQuery();
                    if (a > 0)
                        MessageBox.Show("Yeni Ürün Veri Tabanına Eklendi!");
                    else
                        MessageBox.Show("Ürün Eklenemedi!");
                    db.connection.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata : " + ex.Message);
                }
                intMi = false;
            }
        }
    }
}