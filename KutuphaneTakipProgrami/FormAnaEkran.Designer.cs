namespace KutuphaneTakipProgrami
{
    partial class FormAnaEkran
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
            this.SuspendLayout();
            // 
            // FormAnaEkran
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "FormAnaEkran";
            this.Load += new System.EventHandler(this.FormAnaEkran_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonYeniKitapKaydet;
        private System.Windows.Forms.Button buttonYeniUyeKaydet;
        private System.Windows.Forms.Button buttonKitapListele;
        private System.Windows.Forms.Button buttonUyeListele;
        private System.Windows.Forms.Button buttonEmanetKitaplar;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.GroupBox groupBoxUyeAra;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxAdiSoyadi;
        private System.Windows.Forms.TextBox textBoxTcKimlikNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxYayinEvi;
        private System.Windows.Forms.TextBox textBoxYazarAdi;
        private System.Windows.Forms.TextBox textBoxKitapAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelYayinEvi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBoxKitapTeslim;
        private System.Windows.Forms.Button buttonTeslimEt;
        private System.Windows.Forms.DateTimePicker dateTimePickerVerilisTarihi;
        private System.Windows.Forms.Label labelTeslimTarihi;
        private System.Windows.Forms.Label labelBitisTarihi;
        private System.Windows.Forms.DateTimePicker dateTimePickerBitisTarihi;
        public System.Windows.Forms.DataGridView dataGridViewKitapListesi;
        public System.Windows.Forms.DataGridView dataGridViewUyeListesi;
        private System.Windows.Forms.Button buttonOkunanKitaplar;
        private System.Windows.Forms.TextBox textBoxKitapTuru;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniKullanıcıKaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripKullaniciSifreDegistir;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox textBoxKitapListesindeAra;
        private System.Windows.Forms.ComboBox comboBoxKitapListesindeAra;
        private System.Windows.Forms.TextBox textBoxUyelerListesindeAra;
        private System.Windows.Forms.ComboBox comboBoxUyelerListesindeAra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

