using System;
using System.Data.OleDb;
using System.Windows.Forms;
namespace StokTakip
{
    public partial class Kullanici_Sil : Form
    {
        string kullanici;
        public Kullanici_Sil()
        {
            InitializeComponent();
        }
        private void Kullanici_Sil_Load(object sender, EventArgs e)
        {
            cboxVeriCek();
        }
        private void cboxVeriCek()
        {
            try
            {
                DbContext db = new DbContext();
                db.connection.Open();
                string sorgu = "SELECT AdSoyad FROM Kayitlilar";
                OleDbCommand command = new OleDbCommand(sorgu, db.connection);
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    cbox_kullanicilar.Items.Add(reader["AdSoyad"]);
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
            this.Close();
        }
        private void btn_yenile_Click(object sender, EventArgs e)
        {
            cboxVeriCek();
        }
        private void btn_sil_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show(kullanici + " adlı kullanıcının kaydını silmek üzeresiniz Emin misiniz?", "Kullanıcı Silme İşlemi", MessageBoxButtons.YesNo);
            if (sonuc == DialogResult.Yes)
            {
                try
                {
                    DbContext db = new DbContext();
                    db.connection.Open();

                    string sorgu = "SELECT ID FROM Kayitlilar WHERE AdSoyad = " + kullanici;
                    OleDbCommand command = new OleDbCommand(sorgu, db.connection);
                    command.Parameters.AddWithValue("@kullanici" , kullanici);
                    object obje = command.ExecuteScalar();
                    string id = obje.ToString();

                    string sorgu2 = "DELETE FROM Kayitlilar WHERE ID = " + id;
                    OleDbCommand command2 = new OleDbCommand(sorgu2, db.connection);
                    command2.Parameters.AddWithValue("@id" , id);

                    int calistiMi = command2.ExecuteNonQuery();

                    if (calistiMi > 0)
                    {
                        MessageBox.Show("Kullanıcı Silindi");
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı Silinemedi, Tekrar Deneyiniz");
                    }
                    db.connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata : " + ex.Message);
                }
            }
        }
        private void cbox_kullanicilar_SelectedIndexChanged(object sender, EventArgs e)
        {
            object obj = cbox_kullanicilar.SelectedItem;
            kullanici = obj.ToString();
        }
    }
}