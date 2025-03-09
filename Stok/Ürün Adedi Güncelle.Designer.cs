namespace StokTakip
{
    partial class Ürün_Adedi_Güncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ürün_Adedi_Güncelle));
            this.label_sifre = new System.Windows.Forms.Label();
            this.tbox_aded = new System.Windows.Forms.TextBox();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.btn_oncekiMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_sifre
            // 
            this.label_sifre.AutoSize = true;
            this.label_sifre.BackColor = System.Drawing.Color.Transparent;
            this.label_sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_sifre.ForeColor = System.Drawing.Color.White;
            this.label_sifre.Location = new System.Drawing.Point(12, 26);
            this.label_sifre.Name = "label_sifre";
            this.label_sifre.Size = new System.Drawing.Size(160, 24);
            this.label_sifre.TabIndex = 11;
            this.label_sifre.Text = "Yeni Adedi Giriniz";
            // 
            // tbox_aded
            // 
            this.tbox_aded.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbox_aded.Location = new System.Drawing.Point(12, 53);
            this.tbox_aded.Name = "tbox_aded";
            this.tbox_aded.Size = new System.Drawing.Size(240, 28);
            this.tbox_aded.TabIndex = 10;
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
            this.btn_kaydet.Location = new System.Drawing.Point(12, 96);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(98, 88);
            this.btn_kaydet.TabIndex = 12;
            this.btn_kaydet.UseVisualStyleBackColor = false;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
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
            this.btn_oncekiMenu.Location = new System.Drawing.Point(281, 12);
            this.btn_oncekiMenu.Name = "btn_oncekiMenu";
            this.btn_oncekiMenu.Size = new System.Drawing.Size(98, 88);
            this.btn_oncekiMenu.TabIndex = 16;
            this.btn_oncekiMenu.UseVisualStyleBackColor = false;
            this.btn_oncekiMenu.Click += new System.EventHandler(this.btn_oncekiMenu_Click);
            // 
            // Ürün_Adedi_Güncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(402, 194);
            this.Controls.Add(this.btn_oncekiMenu);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.label_sifre);
            this.Controls.Add(this.tbox_aded);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Ürün_Adedi_Güncelle";
            this.Text = "Ürün Adedi Güncelle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_sifre;
        private System.Windows.Forms.TextBox tbox_aded;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Button btn_oncekiMenu;
    }
}