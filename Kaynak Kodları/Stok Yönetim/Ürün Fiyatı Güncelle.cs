using System;
using System.Data.OleDb;
using System.Windows.Forms;
namespace StokTakip
{
    public partial class Ürün_Fiyatı_Güncelle : Form
    {
        public Ürün_Fiyatı_Güncelle()
        {
            InitializeComponent();
        }
        private void btn_oncekiMenu_Click(object sender, EventArgs e)
        {
            Stok_Güncelle stokGuncelle = new Stok_Güncelle();
            this.Close();
        }
        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            bool intMi = true;
            while (intMi)
            {
                try
                {
                    int fiyat = Convert.ToInt32(tbox_fiyat.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata : " + ex.Message);
                    break;
                }

                try
                {
                    string yeniFiyat = tbox_fiyat.Text;

                    DbContext db = new DbContext();
                    db.connection.Open();

                    string sorgu = "UPDATE Urunler SET UrunBirimFiyat = YeniFiyat WHERE UrunAdi = " + Stok_Güncelle.urun;
                    OleDbCommand command = new OleDbCommand(sorgu, db.connection);
                    command.Parameters.AddWithValue("@YeniFiyat", yeniFiyat);
                    command.Parameters.AddWithValue("@urunAdi", Stok_Güncelle.urun);

                    int calisti = command.ExecuteNonQuery();
                    if (calisti > 0)
                    {
                        MessageBox.Show("Veri Güncellendi");
                    }
                    else
                    {
                        MessageBox.Show("Veri Güncellenemedi");
                    }
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