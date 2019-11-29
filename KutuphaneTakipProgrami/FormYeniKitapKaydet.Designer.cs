namespace KutuphaneTakipProgrami
{
    partial class FormYeniKitapKaydet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormYeniKitapKaydet));
            this.labelKitapAdi = new System.Windows.Forms.Label();
            this.labelYazarAdi = new System.Windows.Forms.Label();
            this.labelYayinEvi = new System.Windows.Forms.Label();
            this.labelKitapTuru = new System.Windows.Forms.Label();
            this.labelBarkodNo = new System.Windows.Forms.Label();
            this.labelTeminTarihi = new System.Windows.Forms.Label();
            this.labelTeminBicimi = new System.Windows.Forms.Label();
            this.labelStokSayisi = new System.Windows.Forms.Label();
            this.textBoxKitapAdi = new System.Windows.Forms.TextBox();
            this.textBoxYazarAdi = new System.Windows.Forms.TextBox();
            this.textBoxYayinEvi = new System.Windows.Forms.TextBox();
            this.textBoxBarkodNo = new System.Windows.Forms.TextBox();
            this.textBoxStokSayisi = new System.Windows.Forms.TextBox();
            this.comboBoxTeminBicimi = new System.Windows.Forms.ComboBox();
            this.dateTimePickerTeminTarihi = new System.Windows.Forms.DateTimePicker();
            this.comboBoxKitapTuru = new System.Windows.Forms.ComboBox();
            this.buttonYeniKitapKaydet = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelKitapAdi
            // 
            this.labelKitapAdi.AutoSize = true;
            this.labelKitapAdi.Location = new System.Drawing.Point(39, 39);
            this.labelKitapAdi.Name = "labelKitapAdi";
            this.labelKitapAdi.Size = new System.Drawing.Size(49, 13);
            this.labelKitapAdi.TabIndex = 0;
            this.labelKitapAdi.Text = "Kitap Adı";
            // 
            // labelYazarAdi
            // 
            this.labelYazarAdi.AutoSize = true;
            this.labelYazarAdi.Location = new System.Drawing.Point(39, 65);
            this.labelYazarAdi.Name = "labelYazarAdi";
            this.labelYazarAdi.Size = new System.Drawing.Size(52, 13);
            this.labelYazarAdi.TabIndex = 1;
            this.labelYazarAdi.Text = "Yazar Adı";
            // 
            // labelYayinEvi
            // 
            this.labelYayinEvi.AutoSize = true;
            this.labelYayinEvi.Location = new System.Drawing.Point(39, 91);
            this.labelYayinEvi.Name = "labelYayinEvi";
            this.labelYayinEvi.Size = new System.Drawing.Size(51, 13);
            this.labelYayinEvi.TabIndex = 2;
            this.labelYayinEvi.Text = "Yayın Evi";
            // 
            // labelKitapTuru
            // 
            this.labelKitapTuru.AutoSize = true;
            this.labelKitapTuru.Location = new System.Drawing.Point(39, 118);
            this.labelKitapTuru.Name = "labelKitapTuru";
            this.labelKitapTuru.Size = new System.Drawing.Size(56, 13);
            this.labelKitapTuru.TabIndex = 3;
            this.labelKitapTuru.Text = "Kitap Türü";
            // 
            // labelBarkodNo
            // 
            this.labelBarkodNo.AutoSize = true;
            this.labelBarkodNo.Location = new System.Drawing.Point(39, 144);
            this.labelBarkodNo.Name = "labelBarkodNo";
            this.labelBarkodNo.Size = new System.Drawing.Size(58, 13);
            this.labelBarkodNo.TabIndex = 4;
            this.labelBarkodNo.Text = "Barkod No";
            // 
            // labelTeminTarihi
            // 
            this.labelTeminTarihi.AutoSize = true;
            this.labelTeminTarihi.Location = new System.Drawing.Point(39, 170);
            this.labelTeminTarihi.Name = "labelTeminTarihi";
            this.labelTeminTarihi.Size = new System.Drawing.Size(65, 13);
            this.labelTeminTarihi.TabIndex = 5;
            this.labelTeminTarihi.Text = "Temin Tarihi";
            // 
            // labelTeminBicimi
            // 
            this.labelTeminBicimi.AutoSize = true;
            this.labelTeminBicimi.Location = new System.Drawing.Point(39, 197);
            this.labelTeminBicimi.Name = "labelTeminBicimi";
            this.labelTeminBicimi.Size = new System.Drawing.Size(66, 13);
            this.labelTeminBicimi.TabIndex = 6;
            this.labelTeminBicimi.Text = "Temin Biçimi";
            // 
            // labelStokSayisi
            // 
            this.labelStokSayisi.AutoSize = true;
            this.labelStokSayisi.Location = new System.Drawing.Point(42, 219);
            this.labelStokSayisi.Name = "labelStokSayisi";
            this.labelStokSayisi.Size = new System.Drawing.Size(59, 13);
            this.labelStokSayisi.TabIndex = 7;
            this.labelStokSayisi.Text = "Stok Sayısı";
            // 
            // textBoxKitapAdi
            // 
            this.textBoxKitapAdi.Location = new System.Drawing.Point(134, 32);
            this.textBoxKitapAdi.Name = "textBoxKitapAdi";
            this.textBoxKitapAdi.Size = new System.Drawing.Size(204, 20);
            this.textBoxKitapAdi.TabIndex = 1;
            this.textBoxKitapAdi.TextChanged += new System.EventHandler(this.textBoxKitapAdi_TextChanged);
            // 
            // textBoxYazarAdi
            // 
            this.textBoxYazarAdi.Location = new System.Drawing.Point(134, 58);
            this.textBoxYazarAdi.Name = "textBoxYazarAdi";
            this.textBoxYazarAdi.Size = new System.Drawing.Size(204, 20);
            this.textBoxYazarAdi.TabIndex = 2;
            this.textBoxYazarAdi.TextChanged += new System.EventHandler(this.textBoxYazarAdi_TextChanged);
            // 
            // textBoxYayinEvi
            // 
            this.textBoxYayinEvi.Location = new System.Drawing.Point(134, 84);
            this.textBoxYayinEvi.Name = "textBoxYayinEvi";
            this.textBoxYayinEvi.Size = new System.Drawing.Size(204, 20);
            this.textBoxYayinEvi.TabIndex = 3;
            this.textBoxYayinEvi.TextChanged += new System.EventHandler(this.textBoxYayinEvi_TextChanged);
            // 
            // textBoxBarkodNo
            // 
            this.textBoxBarkodNo.Location = new System.Drawing.Point(134, 137);
            this.textBoxBarkodNo.Name = "textBoxBarkodNo";
            this.textBoxBarkodNo.Size = new System.Drawing.Size(204, 20);
            this.textBoxBarkodNo.TabIndex = 5;
            // 
            // textBoxStokSayisi
            // 
            this.textBoxStokSayisi.Location = new System.Drawing.Point(134, 216);
            this.textBoxStokSayisi.MaxLength = 4;
            this.textBoxStokSayisi.Name = "textBoxStokSayisi";
            this.textBoxStokSayisi.Size = new System.Drawing.Size(204, 20);
            this.textBoxStokSayisi.TabIndex = 8;
            this.textBoxStokSayisi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStokSayisi_KeyPress);
            // 
            // comboBoxTeminBicimi
            // 
            this.comboBoxTeminBicimi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxTeminBicimi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxTeminBicimi.FormattingEnabled = true;
            this.comboBoxTeminBicimi.Items.AddRange(new object[] {
            "HEDİYE",
            "SATIN ALMA"});
            this.comboBoxTeminBicimi.Location = new System.Drawing.Point(134, 189);
            this.comboBoxTeminBicimi.Name = "comboBoxTeminBicimi";
            this.comboBoxTeminBicimi.Size = new System.Drawing.Size(204, 21);
            this.comboBoxTeminBicimi.TabIndex = 7;
            this.comboBoxTeminBicimi.TextChanged += new System.EventHandler(this.comboBoxTeminBicimi_TextChanged);
            // 
            // dateTimePickerTeminTarihi
            // 
            this.dateTimePickerTeminTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTeminTarihi.Location = new System.Drawing.Point(134, 163);
            this.dateTimePickerTeminTarihi.Name = "dateTimePickerTeminTarihi";
            this.dateTimePickerTeminTarihi.Size = new System.Drawing.Size(204, 20);
            this.dateTimePickerTeminTarihi.TabIndex = 6;
            // 
            // comboBoxKitapTuru
            // 
            this.comboBoxKitapTuru.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxKitapTuru.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxKitapTuru.FormattingEnabled = true;
            this.comboBoxKitapTuru.Items.AddRange(new object[] {
            "EDEBİYAT",
            "AKADEMİK",
            "EĞİTİM",
            "ARAŞTIRMA-İNCELEME",
            "ÇOCUK",
            "HOBİ",
            "DERS",
            "GENEL",
            "",
            "",
            "",
            ""});
            this.comboBoxKitapTuru.Location = new System.Drawing.Point(134, 110);
            this.comboBoxKitapTuru.Name = "comboBoxKitapTuru";
            this.comboBoxKitapTuru.Size = new System.Drawing.Size(204, 21);
            this.comboBoxKitapTuru.TabIndex = 4;
            this.comboBoxKitapTuru.TextChanged += new System.EventHandler(this.comboBoxKitapTuru_TextChanged);
            // 
            // buttonYeniKitapKaydet
            // 
            this.buttonYeniKitapKaydet.Location = new System.Drawing.Point(249, 259);
            this.buttonYeniKitapKaydet.Name = "buttonYeniKitapKaydet";
            this.buttonYeniKitapKaydet.Size = new System.Drawing.Size(89, 48);
            this.buttonYeniKitapKaydet.TabIndex = 9;
            this.buttonYeniKitapKaydet.Text = "Kaydet";
            this.buttonYeniKitapKaydet.UseVisualStyleBackColor = true;
            this.buttonYeniKitapKaydet.Click += new System.EventHandler(this.buttonYeniKitapKaydet_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(154, 259);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(89, 48);
            this.buttonExit.TabIndex = 10;
            this.buttonExit.Text = "Kapat";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // FormYeniKitapKaydet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 333);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonYeniKitapKaydet);
            this.Controls.Add(this.comboBoxKitapTuru);
            this.Controls.Add(this.dateTimePickerTeminTarihi);
            this.Controls.Add(this.comboBoxTeminBicimi);
            this.Controls.Add(this.textBoxStokSayisi);
            this.Controls.Add(this.textBoxBarkodNo);
            this.Controls.Add(this.textBoxYayinEvi);
            this.Controls.Add(this.textBoxYazarAdi);
            this.Controls.Add(this.textBoxKitapAdi);
            this.Controls.Add(this.labelStokSayisi);
            this.Controls.Add(this.labelTeminBicimi);
            this.Controls.Add(this.labelTeminTarihi);
            this.Controls.Add(this.labelBarkodNo);
            this.Controls.Add(this.labelKitapTuru);
            this.Controls.Add(this.labelYayinEvi);
            this.Controls.Add(this.labelYazarAdi);
            this.Controls.Add(this.labelKitapAdi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormYeniKitapKaydet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Kitap Kaydı";
            this.Load += new System.EventHandler(this.FormYeniKitapKaydet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelKitapAdi;
        private System.Windows.Forms.Label labelYazarAdi;
        private System.Windows.Forms.Label labelYayinEvi;
        private System.Windows.Forms.Label labelKitapTuru;
        private System.Windows.Forms.Label labelBarkodNo;
        private System.Windows.Forms.Label labelTeminTarihi;
        private System.Windows.Forms.Label labelTeminBicimi;
        private System.Windows.Forms.Label labelStokSayisi;
        private System.Windows.Forms.TextBox textBoxYazarAdi;
        private System.Windows.Forms.TextBox textBoxYayinEvi;
        private System.Windows.Forms.TextBox textBoxBarkodNo;
        private System.Windows.Forms.TextBox textBoxStokSayisi;
        private System.Windows.Forms.ComboBox comboBoxTeminBicimi;
        private System.Windows.Forms.DateTimePicker dateTimePickerTeminTarihi;
        private System.Windows.Forms.ComboBox comboBoxKitapTuru;
        private System.Windows.Forms.Button buttonYeniKitapKaydet;
        private System.Windows.Forms.Button buttonExit;
        public System.Windows.Forms.TextBox textBoxKitapAdi;
    }
}