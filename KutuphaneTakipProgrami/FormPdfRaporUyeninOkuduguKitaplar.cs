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
    public partial class FormPdfRaporUyeninOkuduguKitaplar : Form
    {
        public FormPdfRaporUyeninOkuduguKitaplar()
        {
            InitializeComponent();
        }


        SqlConnection Baglanti = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=KutuphaneDB;Integrated Security=true");

       
        private void FormPdfRaporUyeninOkuduguKitaplar_Load(object sender, EventArgs e)
        {
            DataTable DataTableKitap = new DataTable();
            SqlDataAdapter AdapterKitap = new SqlDataAdapter("SELECT DISTINCT TbKitaplar.KitapAdi,TbKitaplar.YazarAdi,TbKitaplar.YayinEvi,TbKitaplar.KitapTuru From TbKitaplar INNER JOIN TbOkunanKitaplar ON TbKitaplar.KitapAdi=TbOkunanKitaplar.KitapAdi AND TbKitaplar.YazarAdi=TbOkunanKitaplar.YazarAdi  INNER JOIN TbUyeler ON TbOkunanKitaplar.TcKimlikNo=TbUyeler.TcKimlikNo where TbUyeler.TcKimlikNo='" + FormOkunanKitaplar.TcKimlikNo + "'", Baglanti);
            AdapterKitap.Fill(DataTableKitap);

            DataTable DataTableUye = new DataTable();
            SqlDataAdapter AdapterUye = new SqlDataAdapter("Select * From TbUyeler where TcKimlikNo='" + FormOkunanKitaplar.TcKimlikNo + "'", Baglanti);
            AdapterUye.Fill(DataTableUye);

            RaporUyeninOkuduguKitaplar RaporUyeninOkuduguKitaplar = new RaporUyeninOkuduguKitaplar();
            RaporUyeninOkuduguKitaplar.SetDataSource(DataTableKitap);
            RaporUyeninOkuduguKitaplar.Subreports["UyeBilgileri"].SetDataSource(DataTableUye);           
            string Yol = string.Concat(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Rapor.pdf");
            RaporUyeninOkuduguKitaplar.ExportToDisk(ExportFormatType.PortableDocFormat,Yol);
            PdfRapor.src = Yol;
            File.Delete(Yol);
        }

       
    }
}
