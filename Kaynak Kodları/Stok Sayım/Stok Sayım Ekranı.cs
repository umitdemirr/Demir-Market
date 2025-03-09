using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace StokTakip
{
    public partial class Stok_Sayım_Ekranı : Form
    {
        int aded;
        public Stok_Sayım_Ekranı()
        {
            InitializeComponent();
        }
        private void Stok_Sayım_Ekranı_Load(object sender, EventArgs e)
        {
            pbarVeriCek();
            int a = pbar_urun.Maximum;
            int yuzde = aded * 100 / a;
            
            lbl_urun.Text = Stok_Sayım.urun;
            lbl_yuzde.Text = "%" + yuzde;
            lbl_stokOranı.Text = aded + " / " + a;
            pbar_urun.Value = aded;
        }
        private void pbarVeriCek()
        {
            try
            {
                DbContext db = new DbContext();
                db.connection.Open();

                string sorgu = "SELECT UrunAdedi FROM Urunler WHERE UrunAdi = " + Stok_Sayım.urun;
                OleDbCommand command = new OleDbCommand(sorgu, db.connection);
                command.Parameters.AddWithValue("@urunAdi", Stok_Sayım.urun);

                object obje = command.ExecuteScalar();
                aded = Convert.ToInt32(obje);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata : " + ex.Message);
            }           
        }
        private void btn_oncekiMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}