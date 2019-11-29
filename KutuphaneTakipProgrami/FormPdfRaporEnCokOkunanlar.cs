using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.IO;


namespace KutuphaneTakipProgrami
{
    public partial class FormPdfRaporEnCokOkunanlar : Form
    {
        public FormPdfRaporEnCokOkunanlar()
        {
            InitializeComponent();
        }

        SqlConnection Baglanti = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=KutuphaneDB;Integrated Security=true");
      
        private void FormPdfRaporEnCokOkunanlar_Load(object sender, EventArgs e)
        {
            DataTable DataTable = new DataTable();
            SqlDataAdapter Adapter = new SqlDataAdapter("SELECT DISTINCT TbKitaplar.KitapAdi,TbKitaplar.YazarAdi,TbKitaplar.KitapTuru,TbKitaplar.YayinEvi ,COUNT(TbKitaplar.KitapAdi) AS 'SAYI' From TbKitaplar INNER JOIN TbOkunanKitaplar ON TbKitaplar.KitapAdi=TbOkunanKitaplar.KitapAdi AND TbKitaplar.YazarAdi=TbOkunanKitaplar.YazarAdi  INNER JOIN TbUyeler ON TbOkunanKitaplar.TcKimlikNo=TbUyeler.TcKimlikNo  GROUP BY TbKitaplar.KitapAdi,TbKitaplar.YazarAdi,TbKitaplar.KitapTuru,TbKitaplar.YayinEvi ORDER BY SAYI DESC", Baglanti);
            Adapter.Fill(DataTable);
            RaporEnCokOkunanlar RaporEnCokOkunanlar = new RaporEnCokOkunanlar();
            RaporEnCokOkunanlar.SetDataSource(DataTable);
            string Yol = string.Concat(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Rapor.pdf");
            RaporEnCokOkunanlar.ExportToDisk(ExportFormatType.PortableDocFormat, Yol);
            PdfRapor.src = Yol;
            File.Delete(Yol);
        }

        private void FormPdfRaporEnCokOkunanlar_Load_1(object sender, EventArgs e)
        {

        }
    }
}
