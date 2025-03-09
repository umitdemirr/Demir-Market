namespace StokTakip
{
    partial class Stok_Sayım_Ekranı
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stok_Sayım_Ekranı));
            this.pbar_urun = new System.Windows.Forms.ProgressBar();
            this.lbl_urun = new System.Windows.Forms.Label();
            this.btn_oncekiMenu = new System.Windows.Forms.Button();
            this.lbl_stokOranı = new System.Windows.Forms.Label();
            this.lbl_yuzde = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pbar_urun
            // 
            this.pbar_urun.Location = new System.Drawing.Point(16, 47);
            this.pbar_urun.Maximum = 30;
            this.pbar_urun.Name = "pbar_urun";
            this.pbar_urun.Size = new System.Drawing.Size(373, 36);
            this.pbar_urun.TabIndex = 0;
            // 
            // lbl_urun
            // 
            this.lbl_urun.AutoSize = true;
            this.lbl_urun.BackColor = System.Drawing.Color.Transparent;
            this.lbl_urun.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_urun.ForeColor = System.Drawing.Color.White;
            this.lbl_urun.Location = new System.Drawing.Point(12, 22);
            this.lbl_urun.Name = "lbl_urun";
            this.lbl_urun.Size = new System.Drawing.Size(87, 22);
            this.lbl_urun.TabIndex = 33;
            this.lbl_urun.Text = "{urunAdi}";
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
            this.btn_oncekiMenu.Location = new System.Drawing.Point(12, 89);
            this.btn_oncekiMenu.Name = "btn_oncekiMenu";
            this.btn_oncekiMenu.Size = new System.Drawing.Size(98, 88);
            this.btn_oncekiMenu.TabIndex = 36;
            this.btn_oncekiMenu.UseVisualStyleBackColor = false;
            this.btn_oncekiMenu.Click += new System.EventHandler(this.btn_oncekiMenu_Click);
            // 
            // lbl_stokOranı
            // 
            this.lbl_stokOranı.AutoSize = true;
            this.lbl_stokOranı.BackColor = System.Drawing.Color.Transparent;
            this.lbl_stokOranı.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stokOranı.ForeColor = System.Drawing.Color.White;
            this.lbl_stokOranı.Location = new System.Drawing.Point(365, 132);
            this.lbl_stokOranı.Name = "lbl_stokOranı";
            this.lbl_stokOranı.Size = new System.Drawing.Size(81, 26);
            this.lbl_stokOranı.TabIndex = 37;
            this.lbl_stokOranı.Text = "11 / 30";
            // 
            // lbl_yuzde
            // 
            this.lbl_yuzde.AutoSize = true;
            this.lbl_yuzde.BackColor = System.Drawing.Color.Transparent;
            this.lbl_yuzde.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_yuzde.ForeColor = System.Drawing.Color.White;
            this.lbl_yuzde.Location = new System.Drawing.Point(393, 51);
            this.lbl_yuzde.Name = "lbl_yuzde";
            this.lbl_yuzde.Size = new System.Drawing.Size(59, 29);
            this.lbl_yuzde.TabIndex = 38;
            this.lbl_yuzde.Text = "%35";
            // 
            // Stok_Sayım_Ekranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(458, 178);
            this.Controls.Add(this.lbl_yuzde);
            this.Controls.Add(this.lbl_stokOranı);
            this.Controls.Add(this.btn_oncekiMenu);
            this.Controls.Add(this.lbl_urun);
            this.Controls.Add(this.pbar_urun);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Stok_Sayım_Ekranı";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Sayım Ekranı";
            this.Load += new System.EventHandler(this.Stok_Sayım_Ekranı_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pbar_urun;
        private System.Windows.Forms.Label lbl_urun;
        private System.Windows.Forms.Button btn_oncekiMenu;
        private System.Windows.Forms.Label lbl_stokOranı;
        private System.Windows.Forms.Label lbl_yuzde;
    }
}