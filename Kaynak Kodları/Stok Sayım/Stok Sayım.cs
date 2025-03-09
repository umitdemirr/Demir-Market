using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace StokTakip
{
    public partial class Stok_Sayım : Form
    {
        public static string urun;
        public Stok_Sayım()
        {
            InitializeComponent();
        }
        private void Stok_Sayım_Load(object sender, EventArgs e)
        {
            cboxVeriCek();
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
                    cbox_urunler.Items.Add(reader["UrunAdi"]);
                }
                db.connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata : " + ex.Message);
            }
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
                        AdminPaneli admiPaneli = new AdminPaneli();
                        this.Close();
                        admiPaneli.Show();
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
            catch (Exception ex)
            {
                MessageBox.Show("Hata : " + ex.Message);
            }
        }
        private void btn_sonrakiMenu_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show(urun + " adlı ürüne gideceksiniz.", "Stok Sayım Ekranı", MessageBoxButtons.YesNo);
            if (sonuc == DialogResult.Yes)
            {
                try
                {
                    Stok_Sayım_Ekranı stokSayimEkrani = new Stok_Sayım_Ekranı();
                    stokSayimEkrani.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata : " + ex.Message);
                }
            }

        }
        private void cbox_urunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            object obj = cbox_urunler.SelectedItem;
            urun = obj.ToString();
        }
    }
}