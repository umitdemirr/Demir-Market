using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace StokTakip
{
    public partial class Stok_Yonetim_Menusu : Form
    {
        public Stok_Yonetim_Menusu()
        {
            InitializeComponent();
        }
        private void btn_oncekiMenu_Click(object sender, EventArgs e)
        {
            try
            {
                DbContext db = new DbContext();
                db.connection.Open();

                string sorgu = "SELECT * FROM Kayitlilar";
                OleDbCommand command = new OleDbCommand(sorgu, db.connection);
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (Form1.kullaniciAdi == reader["KullaniciAdi"].ToString() && "Admin" == reader["Rol"].ToString())
                    {
                        AdminPaneli adminPaneli = new AdminPaneli();
                        this.Close();
                        adminPaneli.Show();
                        break;
                    }
                    else if (Form1.kullaniciAdi == reader["KullaniciAdi"].ToString() && "Personel" == reader["Rol"].ToString())
                    {
                        Ana_Sayfa anaSayfa = new Ana_Sayfa();
                        this.Close();
                        anaSayfa.Show();
                        break;
                    }
                }
                db.connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Hata : " + ex.Message);
            }
        }
        private void btn_stokGuncelle_Click(object sender, EventArgs e)
        {
            Stok_Güncelle sGuncelle = new Stok_Güncelle();
            this.Close();
            sGuncelle.Show();
        }
        private void btn_stokEkle_Click(object sender, EventArgs e)
        {
            Stok_Ekle sEkle = new Stok_Ekle();
            this.Close();
            sEkle.Show();
        }
        private void btn_stokSil_Click(object sender, EventArgs e)
        {
            Stok_Sil sSil = new Stok_Sil();
            this.Close();
            sSil.Show();
        }
    }
}