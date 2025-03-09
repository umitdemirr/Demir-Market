namespace StokTakip
{
    partial class Ürün_Fiyatı_Güncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ürün_Fiyatı_Güncelle));
            this.btn_oncekiMenu = new System.Windows.Forms.Button();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.lbl_fiyat = new System.Windows.Forms.Label();
            this.tbox_fiyat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
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
            this.btn_oncekiMenu.Location = new System.Drawing.Point(292, 12);
            this.btn_oncekiMenu.Name = "btn_oncekiMenu";
            this.btn_oncekiMenu.Size = new System.Drawing.Size(98, 88);
            this.btn_oncekiMenu.TabIndex = 20;
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
            this.btn_kaydet.Location = new System.Drawing.Point(12, 94);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(98, 88);
            this.btn_kaydet.TabIndex = 19;
            this.btn_kaydet.UseVisualStyleBackColor = false;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // lbl_fiyat
            // 
            this.lbl_fiyat.AutoSize = true;
            this.lbl_fiyat.BackColor = System.Drawing.Color.Transparent;
            this.lbl_fiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_fiyat.ForeColor = System.Drawing.Color.White;
            this.lbl_fiyat.Location = new System.Drawing.Point(12, 24);
            this.lbl_fiyat.Name = "lbl_fiyat";
            this.lbl_fiyat.Size = new System.Drawing.Size(153, 24);
            this.lbl_fiyat.TabIndex = 18;
            this.lbl_fiyat.Text = "Yeni Fiyatı Giriniz";
            // 
            // tbox_fiyat
            // 
            this.tbox_fiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbox_fiyat.Location = new System.Drawing.Point(12, 51);
            this.tbox_fiyat.Name = "tbox_fiyat";
            this.tbox_fiyat.Size = new System.Drawing.Size(240, 28);
            this.tbox_fiyat.TabIndex = 17;
            // 
            // Ürün_Fiyatı_Güncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(402, 194);
            this.Controls.Add(this.btn_oncekiMenu);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.lbl_fiyat);
            this.Controls.Add(this.tbox_fiyat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Ürün_Fiyatı_Güncelle";
            this.Text = "Ürün Fiyatı Güncelle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_oncekiMenu;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Label lbl_fiyat;
        private System.Windows.Forms.TextBox tbox_fiyat;
    }
}