namespace StokTakip
{
    partial class Stok_Sil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stok_Sil));
            this.btn_yenile = new System.Windows.Forms.Button();
            this.btn_oncekiMenu = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.dataGrid_urunler = new System.Windows.Forms.DataGridView();
            this.cbox_urunAdi = new System.Windows.Forms.ComboBox();
            this.lbl_urunAdi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_urunler)).BeginInit();
            this.SuspendLayout();
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
            this.btn_yenile.Location = new System.Drawing.Point(588, 33);
            this.btn_yenile.Name = "btn_yenile";
            this.btn_yenile.Size = new System.Drawing.Size(98, 88);
            this.btn_yenile.TabIndex = 19;
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
            this.btn_oncekiMenu.Location = new System.Drawing.Point(484, 33);
            this.btn_oncekiMenu.Name = "btn_oncekiMenu";
            this.btn_oncekiMenu.Size = new System.Drawing.Size(98, 88);
            this.btn_oncekiMenu.TabIndex = 18;
            this.btn_oncekiMenu.UseVisualStyleBackColor = false;
            this.btn_oncekiMenu.Click += new System.EventHandler(this.btn_oncekiMenu_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.Transparent;
            this.btn_sil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_sil.BackgroundImage")));
            this.btn_sil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_sil.FlatAppearance.BorderSize = 0;
            this.btn_sil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_sil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sil.ForeColor = System.Drawing.Color.Transparent;
            this.btn_sil.Location = new System.Drawing.Point(12, 90);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(98, 88);
            this.btn_sil.TabIndex = 17;
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
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
            this.dataGrid_urunler.Size = new System.Drawing.Size(715, 297);
            this.dataGrid_urunler.TabIndex = 20;
            // 
            // cbox_urunAdi
            // 
            this.cbox_urunAdi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbox_urunAdi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbox_urunAdi.FormattingEnabled = true;
            this.cbox_urunAdi.Location = new System.Drawing.Point(16, 54);
            this.cbox_urunAdi.Name = "cbox_urunAdi";
            this.cbox_urunAdi.Size = new System.Drawing.Size(221, 24);
            this.cbox_urunAdi.TabIndex = 30;
            this.cbox_urunAdi.SelectedIndexChanged += new System.EventHandler(this.cbox_urunAdi_SelectedIndexChanged);
            // 
            // lbl_urunAdi
            // 
            this.lbl_urunAdi.AutoSize = true;
            this.lbl_urunAdi.BackColor = System.Drawing.Color.Transparent;
            this.lbl_urunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_urunAdi.ForeColor = System.Drawing.Color.White;
            this.lbl_urunAdi.Location = new System.Drawing.Point(12, 18);
            this.lbl_urunAdi.Name = "lbl_urunAdi";
            this.lbl_urunAdi.Size = new System.Drawing.Size(74, 20);
            this.lbl_urunAdi.TabIndex = 29;
            this.lbl_urunAdi.Text = "Ürün Adı";
            // 
            // Stok_Sil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(715, 481);
            this.Controls.Add(this.cbox_urunAdi);
            this.Controls.Add(this.lbl_urunAdi);
            this.Controls.Add(this.dataGrid_urunler);
            this.Controls.Add(this.btn_yenile);
            this.Controls.Add(this.btn_oncekiMenu);
            this.Controls.Add(this.btn_sil);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Stok_Sil";
            this.Text = "Stok Silme";
            this.Load += new System.EventHandler(this.Stok_Sil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_urunler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_yenile;
        private System.Windows.Forms.Button btn_oncekiMenu;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.DataGridView dataGrid_urunler;
        private System.Windows.Forms.ComboBox cbox_urunAdi;
        private System.Windows.Forms.Label lbl_urunAdi;
    }
}