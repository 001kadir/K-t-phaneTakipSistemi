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
    public partial class FormPdfRaporHasarliGetirenler : Form
    {
        public FormPdfRaporHasarliGetirenler()
        {
            InitializeComponent();
        }

      
        SqlConnection Baglanti = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=KutuphaneDB;Integrated Security=true");

        private void FormPdfRaporHasarliGetirenler_Load(object sender, EventArgs e)
        {
            DataTable DataTable = new DataTable();
            SqlDataAdapter Adapter = new SqlDataAdapter("SELECT TbUyeler.TcKimlikNo,TbUyeler.AdiSoyadi,TbKitaplar.KitapAdi,TbKitaplar.YazarAdi,TbOkunanKitaplar.VerilisTarihi,TbOkunanKitaplar.BitisTarihi,TbOkunanKitaplar.TeslimTarihi,TbOkunanKitaplar.HasarDurumu From TbKitaplar INNER JOIN TbOkunanKitaplar ON TbKitaplar.KitapAdi=TbOkunanKitaplar.KitapAdi AND TbKitaplar.YazarAdi=TbOkunanKitaplar.YazarAdi  INNER JOIN TbUyeler ON TbOkunanKitaplar.TcKimlikNo=TbUyeler.TcKimlikNo WHERE HasarDurumu='Hasarlı Getirdi'", Baglanti);
            Adapter.Fill(DataTable);
            RaporHasarliGetirenler RaporHasarliGetirenler = new RaporHasarliGetirenler();
            RaporHasarliGetirenler.SetDataSource(DataTable);
            string Yol = string.Concat(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Rapor.pdf");
            RaporHasarliGetirenler.ExportToDisk(ExportFormatType.PortableDocFormat, Yol);
            PdfRapor.src = Yol;
            File.Delete(Yol);
        }

        private void PdfRapor_OnError(object sender, EventArgs e)
        {

        }

        private void FormPdfRaporHasarliGetirenler_Load_1(object sender, EventArgs e)
        {

        }
    }
}
