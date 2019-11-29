namespace KutuphaneTakipProgrami
{
    partial class FormPdfRaporKitabiOkuyanUyeler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPdfRaporKitabiOkuyanUyeler));
            this.PdfRapor = new AxAcroPDFLib.AxAcroPDF();
            ((System.ComponentModel.ISupportInitialize)(this.PdfRapor)).BeginInit();
            this.SuspendLayout();
            // 
            // PdfRapor
            // 
            this.PdfRapor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PdfRapor.Enabled = true;
            this.PdfRapor.Location = new System.Drawing.Point(0, 0);
            this.PdfRapor.Name = "PdfRapor";
            this.PdfRapor.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("PdfRapor.OcxState")));
            this.PdfRapor.Size = new System.Drawing.Size(966, 641);
            this.PdfRapor.TabIndex = 0;
            // 
            // FormPdfRaporKitabiOkuyanUyeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 641);
            this.Controls.Add(this.PdfRapor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormPdfRaporKitabiOkuyanUyeler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rapor";
            this.Load += new System.EventHandler(this.FormPdfRaporKitabiOkuyanUyeler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PdfRapor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxAcroPDFLib.AxAcroPDF PdfRapor;
    }
}