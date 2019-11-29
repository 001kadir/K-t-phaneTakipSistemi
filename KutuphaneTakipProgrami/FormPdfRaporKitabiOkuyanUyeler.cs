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
    public partial class FormPdfRaporKitabiOkuyanUyeler : Form
    {
        public FormPdfRaporKitabiOkuyanUyeler()
        {
            InitializeComponent();
        }

        SqlConnection Baglanti = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=KutuphaneDB;Integrated Security=true");


        private void FormPdfRaporKitabiOkuyanUyeler_Load(object sender, EventArgs e)
        {
            DataTable DataTableKitap = new DataTable();
            SqlDataAdapter AdapterKitap = new SqlDataAdapter("SELECT * FROM TbKitaplar where  KitapAdi='" + FormOkunanKitaplar.KitapAdi + "'  AND YazarAdi='" + FormOkunanKitaplar.YazarAdi + "'", Baglanti);
            AdapterKitap.Fill(DataTableKitap);//alt rapor için

            DataTable DataTableUye = new DataTable();
            SqlDataAdapter AdapterUye = new SqlDataAdapter("SELECT DISTINCT TbUyeler.TcKimlikNo,TbUyeler.AdiSoyadi,TbUyeler.DogumTarihi,TbUyeler.DogumYeri,TbUyeler.Cinsiyet,TbUyeler.UyelikTarihi From TbKitaplar INNER JOIN TbOkunanKitaplar ON TbKitaplar.KitapAdi=TbOkunanKitaplar.KitapAdi AND TbKitaplar.YazarAdi=TbOkunanKitaplar.YazarAdi  INNER JOIN TbUyeler ON TbOkunanKitaplar.TcKimlikNo=TbUyeler.TcKimlikNo WHERE TbOkunanKitaplar.KitapAdi='" + FormOkunanKitaplar.KitapAdi + "' AND TbOkunanKitaplar.YazarAdi='" + FormOkunanKitaplar.YazarAdi + "'", Baglanti);
            AdapterUye.Fill(DataTableUye);//ana rapor için

            RaporKitabiOkuyanUyeler RaporKitabiOkuyanUyeler = new RaporKitabiOkuyanUyeler();
            RaporKitabiOkuyanUyeler.SetDataSource(DataTableUye);
            RaporKitabiOkuyanUyeler.Subreports["KitapBilgileri"].SetDataSource(DataTableKitap);  
            string Yol = string.Concat(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Rapor.pdf");
            RaporKitabiOkuyanUyeler.ExportToDisk(ExportFormatType.PortableDocFormat,Yol);
            PdfRapor.src = Yol;
            File.Delete(Yol);
        }
    }
}
