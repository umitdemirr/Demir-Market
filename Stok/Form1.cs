using System;
using System.Windows.Forms;
using System.Data.OleDb;

namespace StokTakip
{
    public partial class Form1 : Form
    {
        public static string kullaniciAdi;
        static string sifre;
        public Form1()
        {
            InitializeComponent();
        }
        private void tbox_kullaniciAdi_TextChanged(object sender, EventArgs e)
        {
            kullaniciAdi = tbox_kullaniciAdi.Text;
        }
        private void tbox_sifre_TextChanged(object sender, EventArgs e)
        {
            sifre = tbox_sifre.Text;
        }
        private void button_girisYap_Click(object sender, EventArgs e)
        {
            try
            {
                DbContext db = new DbContext();
                db.connection.Open();

                string sorgu = "SELECT * FROM Kayitlilar";
                OleDbCommand command = new OleDbCommand(sorgu, db.connection);
                OleDbDataReader reader = command.ExecuteReader();

                bool girisBasarili = false;
                bool adminMi = false;
                while (reader.Read())
                {
                    if (kullaniciAdi == reader["KullaniciAdi"].ToString() && sifre == reader["Sifre"].ToString())
                    {
                        girisBasarili = true;
                        if (girisBasarili == true && "Admin" == reader["Rol"].ToString())
                        { adminMi = true; }
                    }
                    
                }
                if (girisBasarili)
                {
                    if (adminMi)
                    {
                        MessageBox.Show("Admin Girişi Başarılı");
                        AdminPaneli adminPaneli = new AdminPaneli();
                        adminPaneli.Show();
                    }
                    else
                    {
                        MessageBox.Show("Personel Girişi Başarılı");
                        Ana_Sayfa anaSayfa = new Ana_Sayfa();
                        anaSayfa.Show();
                    }
                }
                else
                    MessageBox.Show("Tekrar Deneyiniz!");
                db.connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata : " + ex.Message);
            }
        }
    }
}