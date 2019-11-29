namespace KutuphaneTakipProgrami
{
    partial class FormPdfRaporEnCokOkunanlar
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
            // FormPdfRaporEnCokOkunanlar
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "FormPdfRaporEnCokOkunanlar";
            this.Load += new System.EventHandler(this.FormPdfRaporEnCokOkunanlar_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private AxAcroPDFLib.AxAcroPDF PdfRapor;
    }
}