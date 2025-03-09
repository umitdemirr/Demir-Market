using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
using System;
namespace StokTakip
{
    public partial class Kullanici_Ekle : Form
    {
        public Kullanici_Ekle()
        {
            InitializeComponent();
        }
        private void Kullanici_Ekle_Load(object sender, System.EventArgs e)
        {
            VeriTablosu();
        }
        private void btn_oncekiMenu_Click(object sender, System.EventArgs e)
        {
            Kullanıcı_Yönetimi kullaniciYonetimi = new Kullanıcı_Yönetimi();
            this.Close();
            kullaniciYonetimi.Show();
        }
        private void btn_yenile_Click(object sender, System.EventArgs e)
        {
            VeriTablosu();
        }
        private void VeriTablosu()
        {
            string veriler = "Select Rol,AdSoyad,KullaniciAdi,Sifre From Kayitlilar";
            DbContext db = new DbContext();
            db.connection.Open();
            OleDbDataAdapter da = new OleDbDataAdapter(veriler, db.connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGrid_kayitlilar.DataSource = ds.Tables[0];
            db.connection.Close();
        }
        private void btn_kaydet_Click(object sender, System.EventArgs e)
        {
            string adSoyad = tbox_adSoyad.Text;
            string kullaniciAdi = tbox_kullaniciAdi.Text;
            string sifre = tbox_sifre.Text;
            string rol;
            DialogResult sonuc = MessageBox.Show(adSoyad + " adlı kullanıcı eklenecek Emin misiniz?", "Kullanıcı Ekleme İşlemi", MessageBoxButtons.YesNo);
            if(sonuc == DialogResult.Yes)
            {
                try
                {
                    if (rbtn_admin.Checked) { rol = "Admin"; }
                    else { rol = "Personel"; }

                    DbContext db = new DbContext();
                    db.connection.Open();

                    string sorgu = "INSERT INTO Kayitlilar (Rol, AdSoyad, KullaniciAdi, Sifre) VALUES (rol, adSoyad, kullaniciAdi, sifre)";
                    OleDbCommand command = new OleDbCommand(sorgu, db.connection);
                    command.Parameters.AddWithValue("rol", rol);
                    command.Parameters.AddWithValue("adSoyad", adSoyad);
                    command.Parameters.AddWithValue("kullaniciAdi", kullaniciAdi);
                    command.Parameters.AddWithValue("sifre", sifre);


                    int calistiMi = command.ExecuteNonQuery();
                    if (calistiMi > 0)
                    {
                        MessageBox.Show("Personel Eklendi");
                    }
                    else
                    {
                        MessageBox.Show("Personel Eklenemedi, Tekrar Deneyiniz");
                    }
                    db.connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata : " + ex.Message);
                }
            }            
        }
    }
}