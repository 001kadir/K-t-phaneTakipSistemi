namespace KutuphaneTakipProgrami
{
    partial class FormKitapListele
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
            // FormKitapListele
            // 
            this.ClientSize = new System.Drawing.Size(373, 404);
            this.Name = "FormKitapListele";
            this.Load += new System.EventHandler(this.FormKitapListele_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonKitapsil;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonKitapGuncelle;
        private System.Windows.Forms.DataGridView dataGridViewKitapListesi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxKitapListesindeAra;
        private System.Windows.Forms.ComboBox comboBoxKitapListesindeAra;
        private System.Windows.Forms.ComboBox comboBoxKitapTuru;
        private System.Windows.Forms.DateTimePicker dateTimePickerTeminTarihi;
        private System.Windows.Forms.ComboBox comboBoxTeminBicimi;
        private System.Windows.Forms.TextBox textBoxStokSayisi;
        private System.Windows.Forms.TextBox textBoxBarkodNo;
        private System.Windows.Forms.TextBox textBoxYayinEvi;
        private System.Windows.Forms.TextBox textBoxYazarAdi;
        public System.Windows.Forms.TextBox textBoxKitapAdi;
        private System.Windows.Forms.Label labelStokSayisi;
        private System.Windows.Forms.Label labelTeminBicimi;
        private System.Windows.Forms.Label labelTeminTarihi;
        private System.Windows.Forms.Label labelBarkodNo;
        private System.Windows.Forms.Label labelKitapTuru;
        private System.Windows.Forms.Label labelYayinEvi;
        private System.Windows.Forms.Label labelYazarAdi;
        private System.Windows.Forms.Label labelKitapAdi;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}