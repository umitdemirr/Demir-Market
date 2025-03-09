namespace StokTakip
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbox_kullaniciAdi = new System.Windows.Forms.TextBox();
            this.tbox_sifre = new System.Windows.Forms.TextBox();
            this.button_girisYap = new System.Windows.Forms.Button();
            this.link_sifremiUnuttum = new System.Windows.Forms.LinkLabel();
            this.pbox_kullaniciAdi = new System.Windows.Forms.PictureBox();
            this.pbox_sifre = new System.Windows.Forms.PictureBox();
            this.label_kullaniciAdi = new System.Windows.Forms.Label();
            this.label_sifre = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_kullaniciAdi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_sifre)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbox_kullaniciAdi
            // 
            this.tbox_kullaniciAdi.BackColor = System.Drawing.SystemColors.Window;
            this.tbox_kullaniciAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbox_kullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbox_kullaniciAdi.Location = new System.Drawing.Point(59, 36);
            this.tbox_kullaniciAdi.Name = "tbox_kullaniciAdi";
            this.tbox_kullaniciAdi.Size = new System.Drawing.Size(240, 28);
            this.tbox_kullaniciAdi.TabIndex = 0;
            this.tbox_kullaniciAdi.TextChanged += new System.EventHandler(this.tbox_kullaniciAdi_TextChanged);
            // 
            // tbox_sifre
            // 
            this.tbox_sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbox_sifre.Location = new System.Drawing.Point(59, 105);
            this.tbox_sifre.Name = "tbox_sifre";
            this.tbox_sifre.PasswordChar = '*';
            this.tbox_sifre.Size = new System.Drawing.Size(240, 28);
            this.tbox_sifre.TabIndex = 1;
            this.tbox_sifre.TextChanged += new System.EventHandler(this.tbox_sifre_TextChanged);
            // 
            // button_girisYap
            // 
            this.button_girisYap.BackColor = System.Drawing.Color.Transparent;
            this.button_girisYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_girisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_girisYap.ForeColor = System.Drawing.Color.White;
            this.button_girisYap.Location = new System.Drawing.Point(89, 180);
            this.button_girisYap.Name = "button_girisYap";
            this.button_girisYap.Size = new System.Drawing.Size(137, 48);
            this.button_girisYap.TabIndex = 4;
            this.button_girisYap.Text = "Giriş Yap";
            this.button_girisYap.UseVisualStyleBackColor = false;
            this.button_girisYap.Click += new System.EventHandler(this.button_girisYap_Click);
            // 
            // link_sifremiUnuttum
            // 
            this.link_sifremiUnuttum.AutoSize = true;
            this.link_sifremiUnuttum.BackColor = System.Drawing.Color.Transparent;
            this.link_sifremiUnuttum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.link_sifremiUnuttum.LinkColor = System.Drawing.Color.White;
            this.link_sifremiUnuttum.Location = new System.Drawing.Point(89, 141);
            this.link_sifremiUnuttum.Name = "link_sifremiUnuttum";
            this.link_sifremiUnuttum.Size = new System.Drawing.Size(142, 24);
            this.link_sifremiUnuttum.TabIndex = 5;
            this.link_sifremiUnuttum.TabStop = true;
            this.link_sifremiUnuttum.Text = "Şifremi Unuttum";
            // 
            // pbox_kullaniciAdi
            // 
            this.pbox_kullaniciAdi.BackColor = System.Drawing.Color.Transparent;
            this.pbox_kullaniciAdi.Image = ((System.Drawing.Image)(resources.GetObject("pbox_kullaniciAdi.Image")));
            this.pbox_kullaniciAdi.Location = new System.Drawing.Point(0, 14);
            this.pbox_kullaniciAdi.Name = "pbox_kullaniciAdi";
            this.pbox_kullaniciAdi.Size = new System.Drawing.Size(50, 50);
            this.pbox_kullaniciAdi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox_kullaniciAdi.TabIndex = 6;
            this.pbox_kullaniciAdi.TabStop = false;
            // 
            // pbox_sifre
            // 
            this.pbox_sifre.BackColor = System.Drawing.Color.Transparent;
            this.pbox_sifre.Image = ((System.Drawing.Image)(resources.GetObject("pbox_sifre.Image")));
            this.pbox_sifre.Location = new System.Drawing.Point(0, 83);
            this.pbox_sifre.Name = "pbox_sifre";
            this.pbox_sifre.Size = new System.Drawing.Size(50, 50);
            this.pbox_sifre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox_sifre.TabIndex = 7;
            this.pbox_sifre.TabStop = false;
            // 
            // label_kullaniciAdi
            // 
            this.label_kullaniciAdi.AutoSize = true;
            this.label_kullaniciAdi.BackColor = System.Drawing.Color.Transparent;
            this.label_kullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_kullaniciAdi.ForeColor = System.Drawing.Color.White;
            this.label_kullaniciAdi.Location = new System.Drawing.Point(55, 9);
            this.label_kullaniciAdi.Name = "label_kullaniciAdi";
            this.label_kullaniciAdi.Size = new System.Drawing.Size(113, 24);
            this.label_kullaniciAdi.TabIndex = 8;
            this.label_kullaniciAdi.Text = "Kullanıcı Adı";
            // 
            // label_sifre
            // 
            this.label_sifre.AutoSize = true;
            this.label_sifre.BackColor = System.Drawing.Color.Transparent;
            this.label_sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_sifre.ForeColor = System.Drawing.Color.White;
            this.label_sifre.Location = new System.Drawing.Point(59, 78);
            this.label_sifre.Name = "label_sifre";
            this.label_sifre.Size = new System.Drawing.Size(47, 24);
            this.label_sifre.TabIndex = 9;
            this.label_sifre.Text = "Şifre";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pbox_kullaniciAdi);
            this.panel1.Controls.Add(this.label_sifre);
            this.panel1.Controls.Add(this.tbox_kullaniciAdi);
            this.panel1.Controls.Add(this.label_kullaniciAdi);
            this.panel1.Controls.Add(this.tbox_sifre);
            this.panel1.Controls.Add(this.pbox_sifre);
            this.panel1.Controls.Add(this.button_girisYap);
            this.panel1.Controls.Add(this.link_sifremiUnuttum);
            this.panel1.Location = new System.Drawing.Point(212, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 231);
            this.panel1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(765, 454);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Takip - Giriş";
            ((System.ComponentModel.ISupportInitialize)(this.pbox_kullaniciAdi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_sifre)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbox_kullaniciAdi;
        private System.Windows.Forms.TextBox tbox_sifre;
        private System.Windows.Forms.Button button_girisYap;
        private System.Windows.Forms.LinkLabel link_sifremiUnuttum;
        private System.Windows.Forms.PictureBox pbox_kullaniciAdi;
        private System.Windows.Forms.PictureBox pbox_sifre;
        private System.Windows.Forms.Label label_kullaniciAdi;
        private System.Windows.Forms.Label label_sifre;
        private System.Windows.Forms.Panel panel1;
    }
}

