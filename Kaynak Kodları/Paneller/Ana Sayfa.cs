using System;
using System.Windows.Forms;

namespace StokTakip
{
    public partial class Ana_Sayfa : Form
    {
        public Ana_Sayfa()
        {
            InitializeComponent();
        }
        private void btn_urunStokYonetimi_Click(object sender, EventArgs e)
        {
            Stok_Yonetim_Menusu stokYonetimMenusu = new Stok_Yonetim_Menusu();
            this.Close();
            stokYonetimMenusu.Show();
        }
        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btn_stokSayim_Click(object sender, EventArgs e)
        {
            Stok_Sayım stokSayim = new Stok_Sayım();
            this.Close();
            stokSayim.Show();
        }
    }
}