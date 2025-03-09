namespace StokTakip
{
    partial class Stok_Sayım
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stok_Sayım));
            this.cbox_urunler = new System.Windows.Forms.ComboBox();
            this.lbl_urunler = new System.Windows.Forms.Label();
            this.btn_oncekiMenu = new System.Windows.Forms.Button();
            this.btn_sonrakiMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbox_urunler
            // 
            this.cbox_urunler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbox_urunler.FormattingEnabled = true;
            this.cbox_urunler.Location = new System.Drawing.Point(27, 49);
            this.cbox_urunler.Name = "cbox_urunler";
            this.cbox_urunler.Size = new System.Drawing.Size(307, 28);
            this.cbox_urunler.TabIndex = 38;
            this.cbox_urunler.SelectedIndexChanged += new System.EventHandler(this.cbox_urunler_SelectedIndexChanged);
            // 
            // lbl_urunler
            // 
            this.lbl_urunler.AutoSize = true;
            this.lbl_urunler.BackColor = System.Drawing.Color.Transparent;
            this.lbl_urunler.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_urunler.ForeColor = System.Drawing.Color.White;
            this.lbl_urunler.Location = new System.Drawing.Point(24, 24);
            this.lbl_urunler.Name = "lbl_urunler";
            this.lbl_urunler.Size = new System.Drawing.Size(70, 22);
            this.lbl_urunler.TabIndex = 37;
            this.lbl_urunler.Text = "Ürünler";
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
            this.btn_oncekiMenu.Location = new System.Drawing.Point(28, 83);
            this.btn_oncekiMenu.Name = "btn_oncekiMenu";
            this.btn_oncekiMenu.Size = new System.Drawing.Size(98, 88);
            this.btn_oncekiMenu.TabIndex = 35;
            this.btn_oncekiMenu.UseVisualStyleBackColor = false;
            this.btn_oncekiMenu.Click += new System.EventHandler(this.btn_oncekiMenu_Click);
            // 
            // btn_sonrakiMenu
            // 
            this.btn_sonrakiMenu.BackColor = System.Drawing.Color.Transparent;
            this.btn_sonrakiMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_sonrakiMenu.BackgroundImage")));
            this.btn_sonrakiMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_sonrakiMenu.FlatAppearance.BorderSize = 0;
            this.btn_sonrakiMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_sonrakiMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_sonrakiMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sonrakiMenu.ForeColor = System.Drawing.Color.Transparent;
            this.btn_sonrakiMenu.Location = new System.Drawing.Point(236, 83);
            this.btn_sonrakiMenu.Name = "btn_sonrakiMenu";
            this.btn_sonrakiMenu.Size = new System.Drawing.Size(98, 88);
            this.btn_sonrakiMenu.TabIndex = 34;
            this.btn_sonrakiMenu.UseVisualStyleBackColor = false;
            this.btn_sonrakiMenu.Click += new System.EventHandler(this.btn_sonrakiMenu_Click);
            // 
            // Stok_Sayım
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(352, 201);
            this.Controls.Add(this.cbox_urunler);
            this.Controls.Add(this.lbl_urunler);
            this.Controls.Add(this.btn_oncekiMenu);
            this.Controls.Add(this.btn_sonrakiMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Stok_Sayım";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Sayım";
            this.Load += new System.EventHandler(this.Stok_Sayım_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbox_urunler;
        private System.Windows.Forms.Label lbl_urunler;
        private System.Windows.Forms.Button btn_oncekiMenu;
        private System.Windows.Forms.Button btn_sonrakiMenu;
    }
}