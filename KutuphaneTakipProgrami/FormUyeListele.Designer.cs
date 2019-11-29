namespace KutuphaneTakipProgrami
{
    partial class FormUyeListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUyeListele));
            this.dataGridViewUyeListesi = new System.Windows.Forms.DataGridView();
            this.buttonUyeGuncelle = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonUyeSil = new System.Windows.Forms.Button();
            this.groupBoxUyeAra = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxUyelerListesindeAra = new System.Windows.Forms.TextBox();
            this.comboBoxUyelerListesindeAra = new System.Windows.Forms.ComboBox();
            this.dateTimePickerUyelikTarihi = new System.Windows.Forms.DateTimePicker();
            this.comboBoxCinsiyet = new System.Windows.Forms.ComboBox();
            this.comboBoxDogumYeri = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.textBoxAdres = new System.Windows.Forms.TextBox();
            this.textBoxEposta = new System.Windows.Forms.TextBox();
            this.textBoxTelefon = new System.Windows.Forms.TextBox();
            this.textBoxAdiSoyadi = new System.Windows.Forms.TextBox();
            this.textBoxTcKimlikNo = new System.Windows.Forms.TextBox();
            this.labelUyelikTarihi = new System.Windows.Forms.Label();
            this.labelAdres = new System.Windows.Forms.Label();
            this.labelEposta = new System.Windows.Forms.Label();
            this.labelTelefon = new System.Windows.Forms.Label();
            this.labelCinsiyet = new System.Windows.Forms.Label();
            this.labelDogumYeri = new System.Windows.Forms.Label();
            this.labelDogumTarihi = new System.Windows.Forms.Label();
            this.labelAdiSoyadi = new System.Windows.Forms.Label();
            this.labelTCKimlikNo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUyeListesi)).BeginInit();
            this.groupBoxUyeAra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUyeListesi
            // 
            this.dataGridViewUyeListesi.AllowUserToAddRows = false;
            this.dataGridViewUyeListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUyeListesi.Location = new System.Drawing.Point(12, 79);
            this.dataGridViewUyeListesi.Name = "dataGridViewUyeListesi";
            this.dataGridViewUyeListesi.ReadOnly = true;
            this.dataGridViewUyeListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUyeListesi.Size = new System.Drawing.Size(765, 244);
            this.dataGridViewUyeListesi.TabIndex = 14;
            this.dataGridViewUyeListesi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUyeListesi_CellClick);
            // 
            // buttonUyeGuncelle
            // 
            this.buttonUyeGuncelle.Location = new System.Drawing.Point(625, 329);
            this.buttonUyeGuncelle.Name = "buttonUyeGuncelle";
            this.buttonUyeGuncelle.Size = new System.Drawing.Size(89, 48);
            this.buttonUyeGuncelle.TabIndex = 22;
            this.buttonUyeGuncelle.Text = "Güncelle";
            this.buttonUyeGuncelle.UseVisualStyleBackColor = true;
            this.buttonUyeGuncelle.Click += new System.EventHandler(this.buttonUyeGuncelle_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(625, 435);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(89, 48);
            this.buttonExit.TabIndex = 21;
            this.buttonExit.Text = "Kapat";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonUyeSil
            // 
            this.buttonUyeSil.Location = new System.Drawing.Point(625, 381);
            this.buttonUyeSil.Name = "buttonUyeSil";
            this.buttonUyeSil.Size = new System.Drawing.Size(89, 48);
            this.buttonUyeSil.TabIndex = 20;
            this.buttonUyeSil.Text = "Sil";
            this.buttonUyeSil.UseVisualStyleBackColor = true;
            this.buttonUyeSil.Click += new System.EventHandler(this.buttonUyeSil_Click);
            // 
            // groupBoxUyeAra
            // 
            this.groupBoxUyeAra.Controls.Add(this.label8);
            this.groupBoxUyeAra.Controls.Add(this.label9);
            this.groupBoxUyeAra.Controls.Add(this.textBoxUyelerListesindeAra);
            this.groupBoxUyeAra.Controls.Add(this.comboBoxUyelerListesindeAra);
            this.groupBoxUyeAra.Location = new System.Drawing.Point(12, 1);
            this.groupBoxUyeAra.Name = "groupBoxUyeAra";
            this.groupBoxUyeAra.Size = new System.Drawing.Size(357, 61);
            this.groupBoxUyeAra.TabIndex = 43;
            this.groupBoxUyeAra.TabStop = false;
            this.groupBoxUyeAra.Text = "Üye Listesinde Ara";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(192, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Sütun seçiniz...";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "Aranacak kelimeyi giriniz...";
            // 
            // textBoxUyelerListesindeAra
            // 
            this.textBoxUyelerListesindeAra.Location = new System.Drawing.Point(5, 32);
            this.textBoxUyelerListesindeAra.Name = "textBoxUyelerListesindeAra";
            this.textBoxUyelerListesindeAra.Size = new System.Drawing.Size(178, 20);
            this.textBoxUyelerListesindeAra.TabIndex = 3;
            this.textBoxUyelerListesindeAra.TextChanged += new System.EventHandler(this.textBoxUyelerListesindeAra_TextChanged);
            // 
            // comboBoxUyelerListesindeAra
            // 
            this.comboBoxUyelerListesindeAra.FormattingEnabled = true;
            this.comboBoxUyelerListesindeAra.Items.AddRange(new object[] {
            "Adı Soyadı",
            "Tc Kimlik No",
            "Doğum Yeri"});
            this.comboBoxUyelerListesindeAra.Location = new System.Drawing.Point(195, 32);
            this.comboBoxUyelerListesindeAra.Name = "comboBoxUyelerListesindeAra";
            this.comboBoxUyelerListesindeAra.Size = new System.Drawing.Size(124, 21);
            this.comboBoxUyelerListesindeAra.TabIndex = 2;
            this.comboBoxUyelerListesindeAra.Text = "Adı Soyadı";
            this.comboBoxUyelerListesindeAra.SelectedIndexChanged += new System.EventHandler(this.comboBoxUyelerListesindeAra_SelectedIndexChanged);
            // 
            // dateTimePickerUyelikTarihi
            // 
            this.dateTimePickerUyelikTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerUyelikTarihi.Location = new System.Drawing.Point(392, 332);
            this.dateTimePickerUyelikTarihi.Name = "dateTimePickerUyelikTarihi";
            this.dateTimePickerUyelikTarihi.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerUyelikTarihi.TabIndex = 56;
            // 
            // comboBoxCinsiyet
            // 
            this.comboBoxCinsiyet.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxCinsiyet.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxCinsiyet.FormattingEnabled = true;
            this.comboBoxCinsiyet.Items.AddRange(new object[] {
            "ERKEK",
            "BAYAN"});
            this.comboBoxCinsiyet.Location = new System.Drawing.Point(99, 434);
            this.comboBoxCinsiyet.Name = "comboBoxCinsiyet";
            this.comboBoxCinsiyet.Size = new System.Drawing.Size(200, 21);
            this.comboBoxCinsiyet.TabIndex = 54;
            // 
            // comboBoxDogumYeri
            // 
            this.comboBoxDogumYeri.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxDogumYeri.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxDogumYeri.FormattingEnabled = true;
            this.comboBoxDogumYeri.Items.AddRange(new object[] {
            "ADANA",
            "ADIYAMAN",
            "AFYONKARAHİSAR",
            "AĞRI",
            "AKSARAY",
            "AMASYA",
            "ANKARA",
            "ANTALYA",
            "ARDAHAN",
            "ARTVİN",
            "AYDIN",
            "BALIKESİR",
            "BARTIN",
            "BATMAN",
            "BAYBURT",
            "BİLECİK",
            "BİNGÖL",
            "BİTLİS",
            "BOLU",
            "BURDUR",
            "BURSA",
            "ÇANAKKALE",
            "ÇANKIRI",
            "ÇORUM",
            "DENİZLİ",
            "DİYARBAKIR",
            "DÜZCE",
            "EDİRNE",
            "ELAZIĞ",
            "ERZİNCAN",
            "ERZURUM",
            "ESKİŞEHİR",
            "GAZİANTEP",
            "GİRESUN",
            "GÜMÜŞHANE",
            "HAKKÂRİ",
            "HATAY",
            "IĞDIR",
            "ISPARTA",
            "İSTANBUL",
            "İZMİR",
            "KAHRAMANMARAŞ",
            "KARABÜK",
            "KARAMAN",
            "KARS",
            "KASTAMONU",
            "KAYSERİ",
            "KIRIKKALE",
            "KIRKLARELİ",
            "KIRŞEHİR",
            "KİLİS",
            "KOCAELİ",
            "KONYA",
            "KÜTAHYA",
            "MALATYA",
            "MANİSA",
            "MARDİN",
            "MERSİN",
            "MUĞLA",
            "MUŞ",
            "NEVŞEHİR",
            "NİĞDE",
            "ORDU",
            "OSMANİYE",
            "RİZE",
            "SAKARYA",
            "SAMSUN",
            "SİİRT",
            "SİNOP",
            "SİVAS",
            "ŞANLIURFA",
            "ŞIRNAK",
            "TEKİRDAĞ",
            "TOKAT",
            "TRABZON",
            "TUNCELİ",
            "UŞAK",
            "VAN",
            "YALOVA",
            "YOZGAT",
            "ZONGULDAK"});
            this.comboBoxDogumYeri.Location = new System.Drawing.Point(99, 407);
            this.comboBoxDogumYeri.Name = "comboBoxDogumYeri";
            this.comboBoxDogumYeri.Size = new System.Drawing.Size(200, 21);
            this.comboBoxDogumYeri.Sorted = true;
            this.comboBoxDogumYeri.TabIndex = 52;
            // 
            // dateTimePickerDogumTarihi
            // 
            this.dateTimePickerDogumTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDogumTarihi.Location = new System.Drawing.Point(99, 381);
            this.dateTimePickerDogumTarihi.Name = "dateTimePickerDogumTarihi";
            this.dateTimePickerDogumTarihi.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDogumTarihi.TabIndex = 50;
            // 
            // textBoxAdres
            // 
            this.textBoxAdres.Location = new System.Drawing.Point(392, 412);
            this.textBoxAdres.Multiline = true;
            this.textBoxAdres.Name = "textBoxAdres";
            this.textBoxAdres.Size = new System.Drawing.Size(200, 71);
            this.textBoxAdres.TabIndex = 61;
            this.textBoxAdres.TextChanged += new System.EventHandler(this.textBoxAdres_TextChanged);
            // 
            // textBoxEposta
            // 
            this.textBoxEposta.Location = new System.Drawing.Point(392, 360);
            this.textBoxEposta.Name = "textBoxEposta";
            this.textBoxEposta.Size = new System.Drawing.Size(200, 20);
            this.textBoxEposta.TabIndex = 57;
            // 
            // textBoxTelefon
            // 
            this.textBoxTelefon.Location = new System.Drawing.Point(392, 386);
            this.textBoxTelefon.Name = "textBoxTelefon";
            this.textBoxTelefon.Size = new System.Drawing.Size(200, 20);
            this.textBoxTelefon.TabIndex = 59;
            // 
            // textBoxAdiSoyadi
            // 
            this.textBoxAdiSoyadi.Location = new System.Drawing.Point(99, 355);
            this.textBoxAdiSoyadi.Name = "textBoxAdiSoyadi";
            this.textBoxAdiSoyadi.Size = new System.Drawing.Size(200, 20);
            this.textBoxAdiSoyadi.TabIndex = 48;
            // 
            // textBoxTcKimlikNo
            // 
            this.textBoxTcKimlikNo.Location = new System.Drawing.Point(99, 329);
            this.textBoxTcKimlikNo.MaxLength = 11;
            this.textBoxTcKimlikNo.Name = "textBoxTcKimlikNo";
            this.textBoxTcKimlikNo.Size = new System.Drawing.Size(200, 20);
            this.textBoxTcKimlikNo.TabIndex = 45;
            // 
            // labelUyelikTarihi
            // 
            this.labelUyelikTarihi.AutoSize = true;
            this.labelUyelikTarihi.Location = new System.Drawing.Point(307, 339);
            this.labelUyelikTarihi.Name = "labelUyelikTarihi";
            this.labelUyelikTarihi.Size = new System.Drawing.Size(65, 13);
            this.labelUyelikTarihi.TabIndex = 60;
            this.labelUyelikTarihi.Text = "Üyelik Tarihi";
            // 
            // labelAdres
            // 
            this.labelAdres.AutoSize = true;
            this.labelAdres.Location = new System.Drawing.Point(307, 434);
            this.labelAdres.Name = "labelAdres";
            this.labelAdres.Size = new System.Drawing.Size(34, 13);
            this.labelAdres.TabIndex = 58;
            this.labelAdres.Text = "Adres";
            // 
            // labelEposta
            // 
            this.labelEposta.AutoSize = true;
            this.labelEposta.Location = new System.Drawing.Point(307, 367);
            this.labelEposta.Name = "labelEposta";
            this.labelEposta.Size = new System.Drawing.Size(43, 13);
            this.labelEposta.TabIndex = 55;
            this.labelEposta.Text = "E-posta";
            // 
            // labelTelefon
            // 
            this.labelTelefon.AutoSize = true;
            this.labelTelefon.Location = new System.Drawing.Point(307, 393);
            this.labelTelefon.Name = "labelTelefon";
            this.labelTelefon.Size = new System.Drawing.Size(43, 13);
            this.labelTelefon.TabIndex = 53;
            this.labelTelefon.Text = "Telefon";
            // 
            // labelCinsiyet
            // 
            this.labelCinsiyet.AutoSize = true;
            this.labelCinsiyet.Location = new System.Drawing.Point(14, 442);
            this.labelCinsiyet.Name = "labelCinsiyet";
            this.labelCinsiyet.Size = new System.Drawing.Size(43, 13);
            this.labelCinsiyet.TabIndex = 51;
            this.labelCinsiyet.Text = "Cinsiyet";
            // 
            // labelDogumYeri
            // 
            this.labelDogumYeri.AutoSize = true;
            this.labelDogumYeri.Location = new System.Drawing.Point(14, 415);
            this.labelDogumYeri.Name = "labelDogumYeri";
            this.labelDogumYeri.Size = new System.Drawing.Size(62, 13);
            this.labelDogumYeri.TabIndex = 49;
            this.labelDogumYeri.Text = "Doğum Yeri";
            // 
            // labelDogumTarihi
            // 
            this.labelDogumTarihi.AutoSize = true;
            this.labelDogumTarihi.Location = new System.Drawing.Point(14, 388);
            this.labelDogumTarihi.Name = "labelDogumTarihi";
            this.labelDogumTarihi.Size = new System.Drawing.Size(70, 13);
            this.labelDogumTarihi.TabIndex = 47;
            this.labelDogumTarihi.Text = "Doğum Tarihi";
            // 
            // labelAdiSoyadi
            // 
            this.labelAdiSoyadi.AutoSize = true;
            this.labelAdiSoyadi.Location = new System.Drawing.Point(14, 362);
            this.labelAdiSoyadi.Name = "labelAdiSoyadi";
            this.labelAdiSoyadi.Size = new System.Drawing.Size(57, 13);
            this.labelAdiSoyadi.TabIndex = 46;
            this.labelAdiSoyadi.Text = "Adı Soyadı";
            // 
            // labelTCKimlikNo
            // 
            this.labelTCKimlikNo.AutoSize = true;
            this.labelTCKimlikNo.Location = new System.Drawing.Point(14, 336);
            this.labelTCKimlikNo.Name = "labelTCKimlikNo";
            this.labelTCKimlikNo.Size = new System.Drawing.Size(68, 13);
            this.labelTCKimlikNo.TabIndex = 44;
            this.labelTCKimlikNo.Text = "TC Kimlik No";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::KutuphaneTakipProgrami.Properties.Resources.Kütüphane_Takip_Programı;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(683, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 72;
            this.pictureBox1.TabStop = false;
            // 
            // FormUyeListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 497);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dateTimePickerUyelikTarihi);
            this.Controls.Add(this.comboBoxCinsiyet);
            this.Controls.Add(this.comboBoxDogumYeri);
            this.Controls.Add(this.dateTimePickerDogumTarihi);
            this.Controls.Add(this.textBoxAdres);
            this.Controls.Add(this.textBoxEposta);
            this.Controls.Add(this.textBoxTelefon);
            this.Controls.Add(this.textBoxAdiSoyadi);
            this.Controls.Add(this.textBoxTcKimlikNo);
            this.Controls.Add(this.labelUyelikTarihi);
            this.Controls.Add(this.labelAdres);
            this.Controls.Add(this.labelEposta);
            this.Controls.Add(this.labelTelefon);
            this.Controls.Add(this.labelCinsiyet);
            this.Controls.Add(this.labelDogumYeri);
            this.Controls.Add(this.labelDogumTarihi);
            this.Controls.Add(this.labelAdiSoyadi);
            this.Controls.Add(this.labelTCKimlikNo);
            this.Controls.Add(this.groupBoxUyeAra);
            this.Controls.Add(this.buttonUyeGuncelle);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonUyeSil);
            this.Controls.Add(this.dataGridViewUyeListesi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormUyeListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayıtlı Üyeler";
            this.Load += new System.EventHandler(this.FormUyeListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUyeListesi)).EndInit();
            this.groupBoxUyeAra.ResumeLayout(false);
            this.groupBoxUyeAra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUyeGuncelle;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonUyeSil;
        public System.Windows.Forms.DataGridView dataGridViewUyeListesi;
        private System.Windows.Forms.GroupBox groupBoxUyeAra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxUyelerListesindeAra;
        private System.Windows.Forms.ComboBox comboBoxUyelerListesindeAra;
        private System.Windows.Forms.DateTimePicker dateTimePickerUyelikTarihi;
        private System.Windows.Forms.ComboBox comboBoxCinsiyet;
        private System.Windows.Forms.ComboBox comboBoxDogumYeri;
        private System.Windows.Forms.DateTimePicker dateTimePickerDogumTarihi;
        private System.Windows.Forms.TextBox textBoxAdres;
        private System.Windows.Forms.TextBox textBoxEposta;
        private System.Windows.Forms.TextBox textBoxTelefon;
        private System.Windows.Forms.TextBox textBoxAdiSoyadi;
        private System.Windows.Forms.TextBox textBoxTcKimlikNo;
        private System.Windows.Forms.Label labelUyelikTarihi;
        private System.Windows.Forms.Label labelAdres;
        private System.Windows.Forms.Label labelEposta;
        private System.Windows.Forms.Label labelTelefon;
        private System.Windows.Forms.Label labelCinsiyet;
        private System.Windows.Forms.Label labelDogumYeri;
        private System.Windows.Forms.Label labelDogumTarihi;
        private System.Windows.Forms.Label labelAdiSoyadi;
        private System.Windows.Forms.Label labelTCKimlikNo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}