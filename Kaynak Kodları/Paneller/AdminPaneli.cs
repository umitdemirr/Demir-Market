using System;
using System.Windows.Forms;

namespace StokTakip
{
    public partial class AdminPaneli : Form
    {
        public AdminPaneli()
        {
            InitializeComponent();
        }
        private void btn_urunStokYonetimi_Click(object sender, EventArgs e)
        {
            Stok_Yonetim_Menusu stokYonetimMenusu = new Stok_Yonetim_Menusu();
            this.Close();
            stokYonetimMenusu.Show();
        }
        private void btn_kullaniciYonetimi_Click(object sender, EventArgs e)
        {
            Kullanıcı_Yönetimi kullaniciYonetimi = new Kullanıcı_Yönetimi();
            this.Close();
            kullaniciYonetimi.Show();
        }
        private void btn_stokSayim_Click(object sender, EventArgs e)
        {
            Stok_Sayım stokSayim = new Stok_Sayım();
            this.Close();
            stokSayim.Show();
        }
        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}