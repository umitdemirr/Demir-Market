using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace StokTakip
{
    public partial class Kategori_Ekle : Form
    {
        public Kategori_Ekle()
        {
            InitializeComponent();
        }
        private void Kategori_Ekle_Load(object sender, EventArgs e)
        {
            VeriTablosu();
        }
        private void VeriTablosu()
        {
            string veriler = "Select KategoriAdi From Kategori";
            DbContext db = new DbContext();
            db.connection.Open();
            OleDbDataAdapter da = new OleDbDataAdapter(veriler, db.connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGrid_kategoriler.DataSource = ds.Tables[0];
        }
        private void btn_yenile_Click(object sender, EventArgs e)
        {
            VeriTablosu();
        }
        private void btn_oncekiMenu_Click(object sender, EventArgs e)
        {
            Stok_Ekle stokEkle = new Stok_Ekle();
            this.Close();
        }
        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                DbContext db = new DbContext();
                db.connection.Open();
                string veri = "INSERT INTO Kategori (KategoriAdi) VALUES (tbox_kategoriEkle.Text)";
                OleDbCommand command = new OleDbCommand(veri, db.connection);
                command.Parameters.AddWithValue("@KategoriAdi", tbox_kategoriEkle.Text);
                int a = command.ExecuteNonQuery();
                if (a > 0)
                    MessageBox.Show("Yeni Kategori Veri Tabanına Eklendi!");
                else
                    MessageBox.Show("Kategori Eklenemedi!");
                db.connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Hata : " + ex.Message);
            }           
        }
    }
}