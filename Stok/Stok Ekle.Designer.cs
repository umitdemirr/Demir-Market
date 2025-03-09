namespace StokTakip
{
    partial class Stok_Ekle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stok_Ekle));
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.dataGrid_urunler = new System.Windows.Forms.DataGridView();
            this.tbox_urunAdi = new System.Windows.Forms.TextBox();
            this.lbl_urunAdi = new System.Windows.Forms.Label();
            this.lbl_urunAdedi = new System.Windows.Forms.Label();
            this.tbox_urunAdedi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbox_birimFiyat = new System.Windows.Forms.TextBox();
            this.btn_oncekiMenu = new System.Windows.Forms.Button();
            this.btn_yenile = new System.Windows.Forms.Button();
            this.cbox_kategori = new System.Windows.Forms.ComboBox();
            this.btn_kategoriEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_urunler)).BeginInit();
            this.SuspendLayout();
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
            this.btn_kaydet.Location = new System.Drawing.Point(756, 73);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(98, 88);
            this.btn_kaydet.TabIndex = 5;
            this.btn_kaydet.UseVisualStyleBackColor = false;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // dataGrid_urunler
            // 
            this.dataGrid_urunler.AllowUserToAddRows = false;
            this.dataGrid_urunler.AllowUserToDeleteRows = false;
            this.dataGrid_urunler.AllowUserToResizeColumns = false;
            this.dataGrid_urunler.AllowUserToResizeRows = false;
            this.dataGrid_urunler.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dataGrid_urunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_urunler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGrid_urunler.Location = new System.Drawing.Point(0, 184);
            this.dataGrid_urunler.Name = "dataGrid_urunler";
            this.dataGrid_urunler.ReadOnly = true;
            this.dataGrid_urunler.RowHeadersWidth = 51;
            this.dataGrid_urunler.RowTemplate.Height = 24;
            this.dataGrid_urunler.Size = new System.Drawing.Size(864, 297);
            this.dataGrid_urunler.TabIndex = 6;
            // 
            // tbox_urunAdi
            // 
            this.tbox_urunAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbox_urunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbox_urunAdi.Location = new System.Drawing.Point(24, 53);
            this.tbox_urunAdi.Name = "tbox_urunAdi";
            this.tbox_urunAdi.Size = new System.Drawing.Size(208, 26);
            this.tbox_urunAdi.TabIndex = 7;
            // 
            // lbl_urunAdi
            // 
            this.lbl_urunAdi.AutoSize = true;
            this.lbl_urunAdi.BackColor = System.Drawing.Color.Transparent;
            this.lbl_urunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_urunAdi.ForeColor = System.Drawing.Color.White;
            this.lbl_urunAdi.Location = new System.Drawing.Point(21, 25);
            this.lbl_urunAdi.Name = "lbl_urunAdi";
            this.lbl_urunAdi.Size = new System.Drawing.Size(74, 20);
            this.lbl_urunAdi.TabIndex = 8;
            this.lbl_urunAdi.Text = "Ürün Adı";
            // 
            // lbl_urunAdedi
            // 
            this.lbl_urunAdedi.AutoSize = true;
            this.lbl_urunAdedi.BackColor = System.Drawing.Color.Transparent;
            this.lbl_urunAdedi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_urunAdedi.ForeColor = System.Drawing.Color.White;
            this.lbl_urunAdedi.Location = new System.Drawing.Point(21, 101);
            this.lbl_urunAdedi.Name = "lbl_urunAdedi";
            this.lbl_urunAdedi.Size = new System.Drawing.Size(92, 20);
            this.lbl_urunAdedi.TabIndex = 10;
            this.lbl_urunAdedi.Text = "Ürün Adedi";
            // 
            // tbox_urunAdedi
            // 
            this.tbox_urunAdedi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbox_urunAdedi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbox_urunAdedi.Location = new System.Drawing.Point(24, 129);
            this.tbox_urunAdedi.Name = "tbox_urunAdedi";
            this.tbox_urunAdedi.Size = new System.Drawing.Size(208, 26);
            this.tbox_urunAdedi.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(265, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Kategori";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(265, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Birim Fiyatı";
            // 
            // tbox_birimFiyat
            // 
            this.tbox_birimFiyat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbox_birimFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbox_birimFiyat.Location = new System.Drawing.Point(268, 53);
            this.tbox_birimFiyat.Name = "tbox_birimFiyat";
            this.tbox_birimFiyat.Size = new System.Drawing.Size(208, 26);
            this.tbox_birimFiyat.TabIndex = 11;
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
            this.btn_oncekiMenu.Location = new System.Drawing.Point(548, 73);
            this.btn_oncekiMenu.Name = "btn_oncekiMenu";
            this.btn_oncekiMenu.Size = new System.Drawing.Size(98, 88);
            this.btn_oncekiMenu.TabIndex = 15;
            this.btn_oncekiMenu.UseVisualStyleBackColor = false;
            this.btn_oncekiMenu.Click += new System.EventHandler(this.btn_oncekiMenu_Click);
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
            this.btn_yenile.Location = new System.Drawing.Point(652, 73);
            this.btn_yenile.Name = "btn_yenile";
            this.btn_yenile.Size = new System.Drawing.Size(98, 88);
            this.btn_yenile.TabIndex = 16;
            this.btn_yenile.UseVisualStyleBackColor = false;
            this.btn_yenile.Click += new System.EventHandler(this.btn_yenile_Click);
            // 
            // cbox_kategori
            // 
            this.cbox_kategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbox_kategori.FormattingEnabled = true;
            this.cbox_kategori.Location = new System.Drawing.Point(268, 128);
            this.cbox_kategori.Name = "cbox_kategori";
            this.cbox_kategori.Size = new System.Drawing.Size(207, 28);
            this.cbox_kategori.TabIndex = 17;
            // 
            // btn_kategoriEkle
            // 
            this.btn_kategoriEkle.BackColor = System.Drawing.Color.Transparent;
            this.btn_kategoriEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_kategoriEkle.BackgroundImage")));
            this.btn_kategoriEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_kategoriEkle.FlatAppearance.BorderSize = 0;
            this.btn_kategoriEkle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_kategoriEkle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_kategoriEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kategoriEkle.ForeColor = System.Drawing.Color.Transparent;
            this.btn_kategoriEkle.Location = new System.Drawing.Point(480, 121);
            this.btn_kategoriEkle.Name = "btn_kategoriEkle";
            this.btn_kategoriEkle.Size = new System.Drawing.Size(40, 40);
            this.btn_kategoriEkle.TabIndex = 18;
            this.btn_kategoriEkle.UseVisualStyleBackColor = false;
            this.btn_kategoriEkle.Click += new System.EventHandler(this.btn_kategoriEkle_Click);
            // 
            // Stok_Ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(864, 481);
            this.Controls.Add(this.btn_kategoriEkle);
            this.Controls.Add(this.cbox_kategori);
            this.Controls.Add(this.btn_yenile);
            this.Controls.Add(this.btn_oncekiMenu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbox_birimFiyat);
            this.Controls.Add(this.lbl_urunAdedi);
            this.Controls.Add(this.tbox_urunAdedi);
            this.Controls.Add(this.lbl_urunAdi);
            this.Controls.Add(this.tbox_urunAdi);
            this.Controls.Add(this.dataGrid_urunler);
            this.Controls.Add(this.btn_kaydet);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Stok_Ekle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Ekle";
            this.Load += new System.EventHandler(this.Stok_Ekle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_urunler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.DataGridView dataGrid_urunler;
        private System.Windows.Forms.TextBox tbox_urunAdi;
        private System.Windows.Forms.Label lbl_urunAdi;
        private System.Windows.Forms.Label lbl_urunAdedi;
        private System.Windows.Forms.TextBox tbox_urunAdedi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbox_birimFiyat;
        private System.Windows.Forms.Button btn_oncekiMenu;
        private System.Windows.Forms.Button btn_yenile;
        private System.Windows.Forms.ComboBox cbox_kategori;
        private System.Windows.Forms.Button btn_kategoriEkle;
    }
}