using System;
using System.Windows.Forms;

namespace StokTakip
{
    public partial class Kullanıcı_Yönetimi : Form
    {
        public Kullanıcı_Yönetimi()
        {
            InitializeComponent();
        }
        private void btn_oncekiMenu_Click(object sender, EventArgs e)
        {
            AdminPaneli adminPaneli = new AdminPaneli();
            this.Close();
            adminPaneli.Show();
        }
        private void btn_kullaniciSil_Click(object sender, EventArgs e)
        {
            Kullanici_Sil kullanici_Sil = new Kullanici_Sil();
            this.Close();
            kullanici_Sil.Show();
        }
        private void btn_kullaniciEkle_Click(object sender, EventArgs e)
        {
            Kullanici_Ekle kullanici_Ekle = new Kullanici_Ekle();
            this.Close();
            kullanici_Ekle.Show();
        }
    }
}