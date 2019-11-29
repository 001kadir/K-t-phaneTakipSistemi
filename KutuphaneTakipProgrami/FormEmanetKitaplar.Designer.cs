namespace KutuphaneTakipProgrami
{
    partial class FormEmanetKitaplar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmanetKitaplar));
            this.dataGridViewEmanetKitaplar = new System.Windows.Forms.DataGridView();
            this.checkBoxSuresiBitenler = new System.Windows.Forms.CheckBox();
            this.buttonTeslimAl = new System.Windows.Forms.Button();
            this.checkBoxHasarliTeslimAl = new System.Windows.Forms.CheckBox();
            this.groupBoxKitapTeslim = new System.Windows.Forms.GroupBox();
            this.dateTimePickerTeslimTarihi = new System.Windows.Forms.DateTimePicker();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxEmanetListesindeAra = new System.Windows.Forms.TextBox();
            this.comboBoxEmanetListesindeAra = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmanetKitaplar)).BeginInit();
            this.groupBoxKitapTeslim.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEmanetKitaplar
            // 
            this.dataGridViewEmanetKitaplar.AllowUserToAddRows = false;
            this.dataGridViewEmanetKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmanetKitaplar.Location = new System.Drawing.Point(12, 79);
            this.dataGridViewEmanetKitaplar.Name = "dataGridViewEmanetKitaplar";
            this.dataGridViewEmanetKitaplar.ReadOnly = true;
            this.dataGridViewEmanetKitaplar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEmanetKitaplar.Size = new System.Drawing.Size(831, 272);
            this.dataGridViewEmanetKitaplar.TabIndex = 0;
            this.dataGridViewEmanetKitaplar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmanetKitaplar_CellClick);
            // 
            // checkBoxSuresiBitenler
            // 
            this.checkBoxSuresiBitenler.AutoSize = true;
            this.checkBoxSuresiBitenler.Location = new System.Drawing.Point(340, 35);
            this.checkBoxSuresiBitenler.Name = "checkBoxSuresiBitenler";
            this.checkBoxSuresiBitenler.Size = new System.Drawing.Size(93, 17);
            this.checkBoxSuresiBitenler.TabIndex = 24;
            this.checkBoxSuresiBitenler.Text = "Süresi Bitenler";
            this.checkBoxSuresiBitenler.UseVisualStyleBackColor = true;
            this.checkBoxSuresiBitenler.CheckedChanged += new System.EventHandler(this.checkBoxSuresiBitenler_CheckedChanged);
            // 
            // buttonTeslimAl
            // 
            this.buttonTeslimAl.Location = new System.Drawing.Point(165, 19);
            this.buttonTeslimAl.Name = "buttonTeslimAl";
            this.buttonTeslimAl.Size = new System.Drawing.Size(89, 48);
            this.buttonTeslimAl.TabIndex = 25;
            this.buttonTeslimAl.Text = "Teslim Al";
            this.buttonTeslimAl.UseVisualStyleBackColor = true;
            this.buttonTeslimAl.Click += new System.EventHandler(this.buttonTeslimAl_Click);
            // 
            // checkBoxHasarliTeslimAl
            // 
            this.checkBoxHasarliTeslimAl.AutoSize = true;
            this.checkBoxHasarliTeslimAl.Location = new System.Drawing.Point(8, 50);
            this.checkBoxHasarliTeslimAl.Name = "checkBoxHasarliTeslimAl";
            this.checkBoxHasarliTeslimAl.Size = new System.Drawing.Size(58, 17);
            this.checkBoxHasarliTeslimAl.TabIndex = 26;
            this.checkBoxHasarliTeslimAl.Text = "Hasarlı";
            this.checkBoxHasarliTeslimAl.UseVisualStyleBackColor = true;
            this.checkBoxHasarliTeslimAl.CheckedChanged += new System.EventHandler(this.checkBoxHasarliTeslimAl_CheckedChanged);
            // 
            // groupBoxKitapTeslim
            // 
            this.groupBoxKitapTeslim.Controls.Add(this.dateTimePickerTeslimTarihi);
            this.groupBoxKitapTeslim.Controls.Add(this.buttonTeslimAl);
            this.groupBoxKitapTeslim.Controls.Add(this.checkBoxHasarliTeslimAl);
            this.groupBoxKitapTeslim.Location = new System.Drawing.Point(269, 357);
            this.groupBoxKitapTeslim.Name = "groupBoxKitapTeslim";
            this.groupBoxKitapTeslim.Size = new System.Drawing.Size(260, 73);
            this.groupBoxKitapTeslim.TabIndex = 27;
            this.groupBoxKitapTeslim.TabStop = false;
            this.groupBoxKitapTeslim.Text = "KitapTeslim";
            // 
            // dateTimePickerTeslimTarihi
            // 
            this.dateTimePickerTeslimTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTeslimTarihi.Location = new System.Drawing.Point(8, 19);
            this.dateTimePickerTeslimTarihi.Name = "dateTimePickerTeslimTarihi";
            this.dateTimePickerTeslimTarihi.Size = new System.Drawing.Size(148, 20);
            this.dateTimePickerTeslimTarihi.TabIndex = 27;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(535, 376);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(94, 48);
            this.buttonExit.TabIndex = 28;
            this.buttonExit.Text = "Kapat";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxEmanetListesindeAra);
            this.groupBox1.Controls.Add(this.checkBoxSuresiBitenler);
            this.groupBox1.Controls.Add(this.comboBoxEmanetListesindeAra);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 61);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Emanet Listesinde Ara";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(193, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Sütun seçiniz...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Aranacak kelimeyi giriniz...";
            // 
            // textBoxEmanetListesindeAra
            // 
            this.textBoxEmanetListesindeAra.Location = new System.Drawing.Point(6, 32);
            this.textBoxEmanetListesindeAra.Name = "textBoxEmanetListesindeAra";
            this.textBoxEmanetListesindeAra.Size = new System.Drawing.Size(178, 20);
            this.textBoxEmanetListesindeAra.TabIndex = 1;
            this.textBoxEmanetListesindeAra.TextChanged += new System.EventHandler(this.textBoxEmanetListesindeAra_TextChanged);
            // 
            // comboBoxEmanetListesindeAra
            // 
            this.comboBoxEmanetListesindeAra.FormattingEnabled = true;
            this.comboBoxEmanetListesindeAra.Items.AddRange(new object[] {
            "Adı Soyadı",
            "Tc Kimlik No",
            "Kitap Adı",
            "Yazar Adı",
            "Kitap Türü"});
            this.comboBoxEmanetListesindeAra.Location = new System.Drawing.Point(196, 32);
            this.comboBoxEmanetListesindeAra.Name = "comboBoxEmanetListesindeAra";
            this.comboBoxEmanetListesindeAra.Size = new System.Drawing.Size(119, 21);
            this.comboBoxEmanetListesindeAra.TabIndex = 0;
            this.comboBoxEmanetListesindeAra.Text = "Adı Soyadı";
            this.comboBoxEmanetListesindeAra.SelectedIndexChanged += new System.EventHandler(this.comboBoxEmanetListesindeAra_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::KutuphaneTakipProgrami.Properties.Resources.Kütüphane_Takip_Programı;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(749, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 72;
            this.pictureBox1.TabStop = false;
            // 
            // FormEmanetKitaplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 442);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.groupBoxKitapTeslim);
            this.Controls.Add(this.dataGridViewEmanetKitaplar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormEmanetKitaplar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emanet Kitaplar";
            this.Load += new System.EventHandler(this.FormEmanetKitaplar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmanetKitaplar)).EndInit();
            this.groupBoxKitapTeslim.ResumeLayout(false);
            this.groupBoxKitapTeslim.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEmanetKitaplar;
        private System.Windows.Forms.CheckBox checkBoxSuresiBitenler;
        private System.Windows.Forms.Button buttonTeslimAl;
        private System.Windows.Forms.CheckBox checkBoxHasarliTeslimAl;
        private System.Windows.Forms.GroupBox groupBoxKitapTeslim;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.DateTimePicker dateTimePickerTeslimTarihi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxEmanetListesindeAra;
        private System.Windows.Forms.ComboBox comboBoxEmanetListesindeAra;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}