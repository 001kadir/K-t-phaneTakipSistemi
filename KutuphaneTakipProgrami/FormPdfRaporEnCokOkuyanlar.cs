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
    public partial class FormPdfRaporEnCokOkuyanlar : Form
    {
        public FormPdfRaporEnCokOkuyanlar()
        {
            InitializeComponent();
        }

        
         SqlConnection Baglanti = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=KutuphaneDB;Integrated Security=true");

        private void FormPdfRaporEnCokOkuyanlar_Load(object sender, EventArgs e)
        {
            DataTable DataTable = new DataTable();
            SqlDataAdapter Adapter = new SqlDataAdapter("SELECT DISTINCT TbUyeler.TcKimlikNo,TbUyeler.AdiSoyadi,TbUyeler.DogumTarihi,TbUyeler.DogumYeri, COUNT(TbUyeler.TcKimlikNo) AS 'SAYI' From TbKitaplar INNER JOIN TbOkunanKitaplar ON TbKitaplar.KitapAdi=TbOkunanKitaplar.KitapAdi AND TbKitaplar.YazarAdi=TbOkunanKitaplar.YazarAdi  INNER JOIN TbUyeler ON TbOkunanKitaplar.TcKimlikNo=TbUyeler.TcKimlikNo  GROUP BY TbUyeler.AdiSoyadi,TbUyeler.TcKimlikNo,TbUyeler.DogumTarihi,TbUyeler.DogumYeri ORDER BY SAYI DESC", Baglanti);
            Adapter.Fill(DataTable);

            RaporEnCokOkuyanlar RaporEnCokOkuyanlar = new RaporEnCokOkuyanlar();
            RaporEnCokOkuyanlar.SetDataSource(DataTable);
            string Yol = string.Concat(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Rapor.pdf");
            RaporEnCokOkuyanlar.ExportToDisk(ExportFormatType.PortableDocFormat,Yol);
            PdfRapor.src = Yol;
            File.Delete(Yol);
        }

       
    }
}
