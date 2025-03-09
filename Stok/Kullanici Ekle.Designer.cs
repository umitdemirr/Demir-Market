namespace StokTakip
{
    partial class Kullanici_Ekle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kullanici_Ekle));
            this.dataGrid_kayitlilar = new System.Windows.Forms.DataGridView();
            this.lbl_sifre = new System.Windows.Forms.Label();
            this.tbox_sifre = new System.Windows.Forms.TextBox();
            this.lbl_kullaniciAdi = new System.Windows.Forms.Label();
            this.tbox_kullaniciAdi = new System.Windows.Forms.TextBox();
            this.lbl_adSoyad = new System.Windows.Forms.Label();
            this.tbox_adSoyad = new System.Windows.Forms.TextBox();
            this.rbtn_admin = new System.Windows.Forms.RadioButton();
            this.lbl_rol = new System.Windows.Forms.Label();
            this.rbtn_personel = new System.Windows.Forms.RadioButton();
            this.btn_yenile = new System.Windows.Forms.Button();
            this.btn_oncekiMenu = new System.Windows.Forms.Button();
            this.btn_kaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_kayitlilar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid_kayitlilar
            // 
            this.dataGrid_kayitlilar.AllowUserToAddRows = false;
            this.dataGrid_kayitlilar.AllowUserToDeleteRows = false;
            this.dataGrid_kayitlilar.AllowUserToResizeColumns = false;
            this.dataGrid_kayitlilar.AllowUserToResizeRows = false;
            this.dataGrid_kayitlilar.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dataGrid_kayitlilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_kayitlilar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGrid_kayitlilar.Location = new System.Drawing.Point(0, 177);
            this.dataGrid_kayitlilar.Name = "dataGrid_kayitlilar";
            this.dataGrid_kayitlilar.ReadOnly = true;
            this.dataGrid_kayitlilar.RowHeadersWidth = 51;
            this.dataGrid_kayitlilar.RowTemplate.Height = 24;
            this.dataGrid_kayitlilar.Size = new System.Drawing.Size(800, 262);
            this.dataGrid_kayitlilar.TabIndex = 7;
            // 
            // lbl_sifre
            // 
            this.lbl_sifre.AutoSize = true;
            this.lbl_sifre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sifre.ForeColor = System.Drawing.Color.White;
            this.lbl_sifre.Location = new System.Drawing.Point(13, 94);
            this.lbl_sifre.Name = "lbl_sifre";
            this.lbl_sifre.Size = new System.Drawing.Size(44, 20);
            this.lbl_sifre.TabIndex = 23;
            this.lbl_sifre.Text = "Şifre";
            // 
            // tbox_sifre
            // 
            this.tbox_sifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbox_sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbox_sifre.Location = new System.Drawing.Point(16, 122);
            this.tbox_sifre.Name = "tbox_sifre";
            this.tbox_sifre.Size = new System.Drawing.Size(208, 26);
            this.tbox_sifre.TabIndex = 22;
            // 
            // lbl_kullaniciAdi
            // 
            this.lbl_kullaniciAdi.AutoSize = true;
            this.lbl_kullaniciAdi.BackColor = System.Drawing.Color.Transparent;
            this.lbl_kullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kullaniciAdi.ForeColor = System.Drawing.Color.White;
            this.lbl_kullaniciAdi.Location = new System.Drawing.Point(12, 19);
            this.lbl_kullaniciAdi.Name = "lbl_kullaniciAdi";
            this.lbl_kullaniciAdi.Size = new System.Drawing.Size(101, 20);
            this.lbl_kullaniciAdi.TabIndex = 21;
            this.lbl_kullaniciAdi.Text = "Kullanıcı Adı";
            // 
            // tbox_kullaniciAdi
            // 
            this.tbox_kullaniciAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbox_kullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbox_kullaniciAdi.Location = new System.Drawing.Point(15, 47);
            this.tbox_kullaniciAdi.Name = "tbox_kullaniciAdi";
            this.tbox_kullaniciAdi.Size = new System.Drawing.Size(208, 26);
            this.tbox_kullaniciAdi.TabIndex = 20;
            // 
            // lbl_adSoyad
            // 
            this.lbl_adSoyad.AutoSize = true;
            this.lbl_adSoyad.BackColor = System.Drawing.Color.Transparent;
            this.lbl_adSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_adSoyad.ForeColor = System.Drawing.Color.White;
            this.lbl_adSoyad.Location = new System.Drawing.Point(256, 19);
            this.lbl_adSoyad.Name = "lbl_adSoyad";
            this.lbl_adSoyad.Size = new System.Drawing.Size(80, 20);
            this.lbl_adSoyad.TabIndex = 19;
            this.lbl_adSoyad.Text = "Ad Soyad";
            // 
            // tbox_adSoyad
            // 
            this.tbox_adSoyad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbox_adSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbox_adSoyad.Location = new System.Drawing.Point(259, 47);
            this.tbox_adSoyad.Name = "tbox_adSoyad";
            this.tbox_adSoyad.Size = new System.Drawing.Size(208, 26);
            this.tbox_adSoyad.TabIndex = 18;
            // 
            // rbtn_admin
            // 
            this.rbtn_admin.AutoSize = true;
            this.rbtn_admin.BackColor = System.Drawing.Color.Transparent;
            this.rbtn_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtn_admin.ForeColor = System.Drawing.Color.White;
            this.rbtn_admin.Location = new System.Drawing.Point(259, 124);
            this.rbtn_admin.Name = "rbtn_admin";
            this.rbtn_admin.Size = new System.Drawing.Size(77, 24);
            this.rbtn_admin.TabIndex = 33;
            this.rbtn_admin.TabStop = true;
            this.rbtn_admin.Text = "Admin";
            this.rbtn_admin.UseVisualStyleBackColor = false;
            // 
            // lbl_rol
            // 
            this.lbl_rol.AutoSize = true;
            this.lbl_rol.BackColor = System.Drawing.Color.Transparent;
            this.lbl_rol.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rol.ForeColor = System.Drawing.Color.White;
            this.lbl_rol.Location = new System.Drawing.Point(255, 95);
            this.lbl_rol.Name = "lbl_rol";
            this.lbl_rol.Size = new System.Drawing.Size(72, 22);
            this.lbl_rol.TabIndex = 32;
            this.lbl_rol.Text = "ROLLER";
            // 
            // rbtn_personel
            // 
            this.rbtn_personel.AutoSize = true;
            this.rbtn_personel.BackColor = System.Drawing.Color.Transparent;
            this.rbtn_personel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtn_personel.ForeColor = System.Drawing.Color.White;
            this.rbtn_personel.Location = new System.Drawing.Point(359, 125);
            this.rbtn_personel.Name = "rbtn_personel";
            this.rbtn_personel.Size = new System.Drawing.Size(96, 24);
            this.rbtn_personel.TabIndex = 34;
            this.rbtn_personel.TabStop = true;
            this.rbtn_personel.Text = "Personel";
            this.rbtn_personel.UseVisualStyleBackColor = false;
            // 
            // btn_yenile
            // 
            this.btn_yenile.BackColor = System.Drawing.Color.Transparent;
            this.btn_yenile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_yenile.BackgroundImage")));
            this.btn_yenile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_yenile.FlatAppearance.BorderSize = 0;
            this.btn_yenile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_yenile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_yenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_yenile.ForeColor = System.Drawing.Color.Transparent;
            this.btn_yenile.Location = new System.Drawing.Point(591, 83);
            this.btn_yenile.Name = "btn_yenile";
            this.btn_yenile.Size = new System.Drawing.Size(98, 88);
            this.btn_yenile.TabIndex = 37;
            this.btn_yenile.UseVisualStyleBackColor = false;
            this.btn_yenile.Click += new System.EventHandler(this.btn_yenile_Click);
            // 
            // btn_oncekiMenu
            // 
            this.btn_oncekiMenu.BackColor = System.Drawing.Color.Transparent;
            this.btn_oncekiMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_oncekiMenu.BackgroundImage")));
            this.btn_oncekiMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_oncekiMenu.FlatAppearance.BorderSize = 0;
            this.btn_oncekiMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_oncekiMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_oncekiMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_oncekiMenu.ForeColor = System.Drawing.Color.Transparent;
            this.btn_oncekiMenu.Location = new System.Drawing.Point(487, 83);
            this.btn_oncekiMenu.Name = "btn_oncekiMenu";
            this.btn_oncekiMenu.Size = new System.Drawing.Size(98, 88);
            this.btn_oncekiMenu.TabIndex = 36;
            this.btn_oncekiMenu.UseVisualStyleBackColor = false;
            this.btn_oncekiMenu.Click += new System.EventHandler(this.btn_oncekiMenu_Click);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.BackColor = System.Drawing.Color.Transparent;
            this.btn_kaydet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_kaydet.BackgroundImage")));
            this.btn_kaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_kaydet.FlatAppearance.BorderSize = 0;
            this.btn_kaydet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_kaydet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_kaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kaydet.ForeColor = System.Drawing.Color.Transparent;
            this.btn_kaydet.Location = new System.Drawing.Point(695, 83);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(98, 88);
            this.btn_kaydet.TabIndex = 35;
            this.btn_kaydet.UseVisualStyleBackColor = false;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // Kullanici_Ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 439);
            this.Controls.Add(this.btn_yenile);
            this.Controls.Add(this.btn_oncekiMenu);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.rbtn_personel);
            this.Controls.Add(this.rbtn_admin);
            this.Controls.Add(this.lbl_rol);
            this.Controls.Add(this.lbl_sifre);
            this.Controls.Add(this.tbox_sifre);
            this.Controls.Add(this.lbl_kullaniciAdi);
            this.Controls.Add(this.tbox_kullaniciAdi);
            this.Controls.Add(this.lbl_adSoyad);
            this.Controls.Add(this.tbox_adSoyad);
            this.Controls.Add(this.dataGrid_kayitlilar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Kullanici_Ekle";
            this.Text = "Kullanici Ekle";
            this.Load += new System.EventHandler(this.Kullanici_Ekle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_kayitlilar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid_kayitlilar;
        private System.Windows.Forms.Label lbl_sifre;
        private System.Windows.Forms.TextBox tbox_sifre;
        private System.Windows.Forms.Label lbl_kullaniciAdi;
        private System.Windows.Forms.TextBox tbox_kullaniciAdi;
        private System.Windows.Forms.Label lbl_adSoyad;
        private System.Windows.Forms.TextBox tbox_adSoyad;
        private System.Windows.Forms.RadioButton rbtn_admin;
        private System.Windows.Forms.Label lbl_rol;
        private System.Windows.Forms.RadioButton rbtn_personel;
        private System.Windows.Forms.Button btn_yenile;
        private System.Windows.Forms.Button btn_oncekiMenu;
        private System.Windows.Forms.Button btn_kaydet;
    }
}