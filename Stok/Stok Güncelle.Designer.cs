namespace StokTakip
{
    partial class Stok_Güncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stok_Güncelle));
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.btn_yenile = new System.Windows.Forms.Button();
            this.btn_oncekiMenu = new System.Windows.Forms.Button();
            this.dataGrid_urunler = new System.Windows.Forms.DataGridView();
            this.lbl_urunAdi = new System.Windows.Forms.Label();
            this.cbox_urunAdi = new System.Windows.Forms.ComboBox();
            this.btn_fiyatGuncelle = new System.Windows.Forms.Button();
            this.btn_adedGuncelle = new System.Windows.Forms.Button();
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
            this.btn_kaydet.Location = new System.Drawing.Point(641, 59);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(98, 88);
            this.btn_kaydet.TabIndex = 5;
            this.btn_kaydet.UseVisualStyleBackColor = false;
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
            this.btn_yenile.Location = new System.Drawing.Point(537, 59);
            this.btn_yenile.Name = "btn_yenile";
            this.btn_yenile.Size = new System.Drawing.Size(98, 88);
            this.btn_yenile.TabIndex = 18;
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
            this.btn_oncekiMenu.Location = new System.Drawing.Point(433, 59);
            this.btn_oncekiMenu.Name = "btn_oncekiMenu";
            this.btn_oncekiMenu.Size = new System.Drawing.Size(98, 88);
            this.btn_oncekiMenu.TabIndex = 17;
            this.btn_oncekiMenu.UseVisualStyleBackColor = false;
            this.btn_oncekiMenu.Click += new System.EventHandler(this.btn_oncekiMenu_Click);
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
            this.dataGrid_urunler.Location = new System.Drawing.Point(0, 153);
            this.dataGrid_urunler.Name = "dataGrid_urunler";
            this.dataGrid_urunler.ReadOnly = true;
            this.dataGrid_urunler.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGrid_urunler.RowTemplate.Height = 24;
            this.dataGrid_urunler.Size = new System.Drawing.Size(751, 266);
            this.dataGrid_urunler.TabIndex = 19;
            // 
            // lbl_urunAdi
            // 
            this.lbl_urunAdi.AutoSize = true;
            this.lbl_urunAdi.BackColor = System.Drawing.Color.Transparent;
            this.lbl_urunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_urunAdi.ForeColor = System.Drawing.Color.White;
            this.lbl_urunAdi.Location = new System.Drawing.Point(12, 19);
            this.lbl_urunAdi.Name = "lbl_urunAdi";
            this.lbl_urunAdi.Size = new System.Drawing.Size(74, 20);
            this.lbl_urunAdi.TabIndex = 21;
            this.lbl_urunAdi.Text = "Ürün Adı";
            // 
            // cbox_urunAdi
            // 
            this.cbox_urunAdi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbox_urunAdi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbox_urunAdi.FormattingEnabled = true;
            this.cbox_urunAdi.Location = new System.Drawing.Point(16, 55);
            this.cbox_urunAdi.Name = "cbox_urunAdi";
            this.cbox_urunAdi.Size = new System.Drawing.Size(221, 24);
            this.cbox_urunAdi.TabIndex = 28;
            this.cbox_urunAdi.SelectedIndexChanged += new System.EventHandler(this.cbox_urunAdi_SelectedIndexChanged);
            // 
            // btn_fiyatGuncelle
            // 
            this.btn_fiyatGuncelle.BackColor = System.Drawing.Color.Transparent;
            this.btn_fiyatGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_fiyatGuncelle.FlatAppearance.BorderSize = 3;
            this.btn_fiyatGuncelle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_fiyatGuncelle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_fiyatGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fiyatGuncelle.ForeColor = System.Drawing.Color.Transparent;
            this.btn_fiyatGuncelle.Location = new System.Drawing.Point(139, 85);
            this.btn_fiyatGuncelle.Name = "btn_fiyatGuncelle";
            this.btn_fiyatGuncelle.Size = new System.Drawing.Size(98, 51);
            this.btn_fiyatGuncelle.TabIndex = 30;
            this.btn_fiyatGuncelle.Text = "Ürün Fiyatını Güncelle";
            this.btn_fiyatGuncelle.UseVisualStyleBackColor = false;
            this.btn_fiyatGuncelle.Click += new System.EventHandler(this.btn_fiyatGuncelle_Click);
            // 
            // btn_adedGuncelle
            // 
            this.btn_adedGuncelle.BackColor = System.Drawing.Color.Transparent;
            this.btn_adedGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_adedGuncelle.FlatAppearance.BorderSize = 3;
            this.btn_adedGuncelle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_adedGuncelle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_adedGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adedGuncelle.ForeColor = System.Drawing.Color.Transparent;
            this.btn_adedGuncelle.Location = new System.Drawing.Point(16, 85);
            this.btn_adedGuncelle.Name = "btn_adedGuncelle";
            this.btn_adedGuncelle.Size = new System.Drawing.Size(98, 51);
            this.btn_adedGuncelle.TabIndex = 31;
            this.btn_adedGuncelle.Text = "Ürün Adedi Güncelle";
            this.btn_adedGuncelle.UseVisualStyleBackColor = false;
            this.btn_adedGuncelle.Click += new System.EventHandler(this.btn_adedGuncelle_Click);
            // 
            // Stok_Güncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(751, 419);
            this.Controls.Add(this.btn_adedGuncelle);
            this.Controls.Add(this.btn_fiyatGuncelle);
            this.Controls.Add(this.cbox_urunAdi);
            this.Controls.Add(this.lbl_urunAdi);
            this.Controls.Add(this.dataGrid_urunler);
            this.Controls.Add(this.btn_yenile);
            this.Controls.Add(this.btn_oncekiMenu);
            this.Controls.Add(this.btn_kaydet);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Stok_Güncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Güncelle";
            this.Load += new System.EventHandler(this.Stok_Güncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_urunler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Button btn_yenile;
        private System.Windows.Forms.Button btn_oncekiMenu;
        private System.Windows.Forms.DataGridView dataGrid_urunler;
        private System.Windows.Forms.Label lbl_urunAdi;
        private System.Windows.Forms.ComboBox cbox_urunAdi;
        private System.Windows.Forms.Button btn_fiyatGuncelle;
        private System.Windows.Forms.Button btn_adedGuncelle;
    }
}