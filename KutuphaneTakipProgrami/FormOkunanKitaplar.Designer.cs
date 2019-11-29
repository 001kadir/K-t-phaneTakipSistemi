namespace KutuphaneTakipProgrami
{
    partial class FormOkunanKitaplar
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
            // FormOkunanKitaplar
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "FormOkunanKitaplar";
            this.Load += new System.EventHandler(this.FormOkunanKitaplar_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOkunanKitaplar;
        private System.Windows.Forms.Button buttonKapat;
        private System.Windows.Forms.Button buttonUyeninOkuduguKitaplar;
        private System.Windows.Forms.Button buttonKitabiOkuyanUyeler;
        private System.Windows.Forms.GroupBox groupBoxUyeBilgileri;
        private System.Windows.Forms.Label labelAdiSoyadi2;
        private System.Windows.Forms.Label labelTcKimlikNo2;
        private System.Windows.Forms.GroupBox groupBoxKitapBilgileri;
        private System.Windows.Forms.Label labelYazarAdi2;
        private System.Windows.Forms.Label labelKitapAdi2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonHasarlıGetirenler;
        private System.Windows.Forms.Button buttonEnCokOkunanlar;
        private System.Windows.Forms.Button buttonEnokOkuyanlar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxOkunanKitaplardaAra;
        private System.Windows.Forms.ComboBox comboBoxOkunanKitaplardaAra;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonBuAyOkunanlar;
        private System.Windows.Forms.DateTimePicker dateTimePickerBaslangicTarihi;
        private System.Windows.Forms.DateTimePicker dateTimePickerBitisTarihi;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}