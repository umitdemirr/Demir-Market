using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace StokTakip
{
    public partial class Stok_Güncelle : Form
    {
        public static string urun;
        public Stok_Güncelle()
        {
            InitializeComponent();
        }
        private void Stok_Güncelle_Load(object sender, EventArgs e)
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
                    cbox_urunAdi.Items.Add(reader["UrunAdi"]);
                }
                db.connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata : " + ex.Message);
            }
        }
        private void btn_yenile_Click(object sender, EventArgs e)
        {
            VeriTablosu();
        }
        private void btn_oncekiMenu_Click(object sender, EventArgs e)
        {
            Stok_Yonetim_Menusu stokYonetimMenusu = new Stok_Yonetim_Menusu();
            this.Close();
            stokYonetimMenusu.Show();
        }
        private void cbox_urunAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            object obj = cbox_urunAdi.SelectedItem;
            urun = obj.ToString();
        }
        private void btn_adedGuncelle_Click(object sender, EventArgs e)
        {
            Ürün_Adedi_Güncelle adedGuncelle = new Ürün_Adedi_Güncelle();
            adedGuncelle.ShowDialog();
        }
        private void btn_fiyatGuncelle_Click(object sender, EventArgs e)
        {
            Ürün_Fiyatı_Güncelle fiyatGuncelle = new Ürün_Fiyatı_Güncelle();
            fiyatGuncelle.ShowDialog();
        }
    }
}