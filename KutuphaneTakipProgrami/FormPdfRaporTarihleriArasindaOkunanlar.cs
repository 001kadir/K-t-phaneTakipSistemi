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
    public partial class FormPdfRaporTarihleriArasindaOkunanlar : Form
    {
        public FormPdfRaporTarihleriArasindaOkunanlar()
        {
            InitializeComponent();
        }
        SqlConnection Baglanti = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=KutuphaneDB;Integrated Security=true");
        private void FormPdfRaporBuAyOkunanlar_Load(object sender, EventArgs e)
        {            
            DataTable DataTable = new DataTable();
            SqlDataAdapter Adapter = new SqlDataAdapter("SELECT DISTINCT TbKitaplar.KitapAdi,TbKitaplar.YazarAdi,TbKitaplar.KitapTuru,TbKitaplar.YayinEvi  From TbKitaplar INNER JOIN TbOkunanKitaplar ON TbKitaplar.KitapAdi=TbOkunanKitaplar.KitapAdi AND TbKitaplar.YazarAdi=TbOkunanKitaplar.YazarAdi  INNER JOIN TbUyeler ON TbOkunanKitaplar.TcKimlikNo=TbUyeler.TcKimlikNo  GROUP BY TbKitaplar.KitapAdi,TbKitaplar.YazarAdi,TbKitaplar.KitapTuru,TbKitaplar.YayinEvi,TbOkunanKitaplar.TeslimTarihi having TbOkunanKitaplar.TeslimTarihi between '" + FormOkunanKitaplar.BaslangicTarihi.ToString() + "' and '" + FormOkunanKitaplar.BitisTarihi.ToString() + "'  ", Baglanti);
            Adapter.Fill(DataTable);

            DataTable DataTableSR = new DataTable();
            SqlDataAdapter AdapterSR = new SqlDataAdapter("SELECT  convert(nvarchar(50), max(TbOkunanKitaplar.TeslimTarihi), 104) as 'SonTarih',convert(nvarchar(50),min(TbOkunanKitaplar.TeslimTarihi ),104) as 'ilkTarih'  From TbOkunanKitaplar  where TbOkunanKitaplar.TeslimTarihi between '" + FormOkunanKitaplar.BaslangicTarihi.ToString() + "' and '" + FormOkunanKitaplar.BitisTarihi.ToString() + "'  ", Baglanti);
            AdapterSR.Fill(DataTableSR);
            RaporTarihleriArasindaOkunanlar RaporTarihleriArasindaOkunanlar = new RaporTarihleriArasindaOkunanlar();
            RaporTarihleriArasindaOkunanlar.SetDataSource(DataTable);
            RaporTarihleriArasindaOkunanlar.Subreports["SubReportTarih"].SetDataSource(DataTableSR); 

            string Yol = string.Concat(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Rapor.pdf");
            RaporTarihleriArasindaOkunanlar.ExportToDisk(ExportFormatType.PortableDocFormat, Yol);
            PdfRapor.src = Yol;
            File.Delete(Yol);
        }
    }
}
