namespace KutuphaneTakipProgrami
{
    partial class FormKullaniciSifreGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKullaniciSifreGuncelle));
            this.textBoxKullaniciAdi = new System.Windows.Forms.TextBox();
            this.textBoxKullaniciSifre = new System.Windows.Forms.TextBox();
            this.labelKullaniciAdi = new System.Windows.Forms.Label();
            this.labelKullaniciSifre = new System.Windows.Forms.Label();
            this.buttonKullaniciKaydet = new System.Windows.Forms.Button();
            this.textBoxYeniSifre = new System.Windows.Forms.TextBox();
            this.textBoxYeniSifreTekrar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxKullaniciAdi
            // 
            this.textBoxKullaniciAdi.Location = new System.Drawing.Point(114, 30);
            this.textBoxKullaniciAdi.Name = "textBoxKullaniciAdi";
            this.textBoxKullaniciAdi.Size = new System.Drawing.Size(171, 20);
            this.textBoxKullaniciAdi.TabIndex = 0;
            // 
            // textBoxKullaniciSifre
            // 
            this.textBoxKullaniciSifre.Location = new System.Drawing.Point(114, 56);
            this.textBoxKullaniciSifre.Name = "textBoxKullaniciSifre";
            this.textBoxKullaniciSifre.Size = new System.Drawing.Size(171, 20);
            this.textBoxKullaniciSifre.TabIndex = 2;
            // 
            // labelKullaniciAdi
            // 
            this.labelKullaniciAdi.AutoSize = true;
            this.labelKullaniciAdi.Location = new System.Drawing.Point(22, 37);
            this.labelKullaniciAdi.Name = "labelKullaniciAdi";
            this.labelKullaniciAdi.Size = new System.Drawing.Size(64, 13);
            this.labelKullaniciAdi.TabIndex = 4;
            this.labelKullaniciAdi.Text = "Kullanıcı Adı";
            // 
            // labelKullaniciSifre
            // 
            this.labelKullaniciSifre.AutoSize = true;
            this.labelKullaniciSifre.Location = new System.Drawing.Point(22, 63);
            this.labelKullaniciSifre.Name = "labelKullaniciSifre";
            this.labelKullaniciSifre.Size = new System.Drawing.Size(28, 13);
            this.labelKullaniciSifre.TabIndex = 5;
            this.labelKullaniciSifre.Text = "Şifre";
            // 
            // buttonKullaniciKaydet
            // 
            this.buttonKullaniciKaydet.Location = new System.Drawing.Point(196, 148);
            this.buttonKullaniciKaydet.Name = "buttonKullaniciKaydet";
            this.buttonKullaniciKaydet.Size = new System.Drawing.Size(89, 48);
            this.buttonKullaniciKaydet.TabIndex = 6;
            this.buttonKullaniciKaydet.Text = "Kaydet";
            this.buttonKullaniciKaydet.UseVisualStyleBackColor = true;
            this.buttonKullaniciKaydet.Click += new System.EventHandler(this.buttonKullaniciKaydet_Click);
            // 
            // textBoxYeniSifre
            // 
            this.textBoxYeniSifre.Location = new System.Drawing.Point(114, 82);
            this.textBoxYeniSifre.Name = "textBoxYeniSifre";
            this.textBoxYeniSifre.Size = new System.Drawing.Size(171, 20);
            this.textBoxYeniSifre.TabIndex = 7;
            // 
            // textBoxYeniSifreTekrar
            // 
            this.textBoxYeniSifreTekrar.Location = new System.Drawing.Point(114, 108);
            this.textBoxYeniSifreTekrar.Name = "textBoxYeniSifreTekrar";
            this.textBoxYeniSifreTekrar.Size = new System.Drawing.Size(171, 20);
            this.textBoxYeniSifreTekrar.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Yeni Şifre Tekrar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Yeni Şifre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // FormKullaniciSifreGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 262);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxYeniSifreTekrar);
            this.Controls.Add(this.textBoxYeniSifre);
            this.Controls.Add(this.buttonKullaniciKaydet);
            this.Controls.Add(this.labelKullaniciSifre);
            this.Controls.Add(this.labelKullaniciAdi);
            this.Controls.Add(this.textBoxKullaniciSifre);
            this.Controls.Add(this.textBoxKullaniciAdi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormKullaniciSifreGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Şifre Güncelle";
            this.Load += new System.EventHandler(this.FormKullaniciSifreGuncelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxKullaniciAdi;
        private System.Windows.Forms.TextBox textBoxKullaniciSifre;
        private System.Windows.Forms.Label labelKullaniciAdi;
        private System.Windows.Forms.Label labelKullaniciSifre;
        private System.Windows.Forms.Button buttonKullaniciKaydet;
        private System.Windows.Forms.TextBox textBoxYeniSifre;
        private System.Windows.Forms.TextBox textBoxYeniSifreTekrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}