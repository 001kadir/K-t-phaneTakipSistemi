using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KutuphaneTakipProgrami
{
    public partial class FormOkunanKitaplar : Form
    {
        public FormOkunanKitaplar()
        {
            InitializeComponent();
        }
       
        Kitap Kitap = new Kitap();
  
        private void FormOkunanKitaplar_Load(object sender, EventArgs e)
        {
            
            Kitap.OkunanKitaplar(dataGridViewOkunanKitaplar);
            OkunanKitaplardaAra = "TbUyeler.AdiSoyadi";
            
        }
                
        public static string TcKimlikNo;
        public static string KitapAdi;
        public static string YazarAdi;
        string AdiSoyadi;
        private void dataGridViewOkunanKitaplar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int UyeSatirIndex;           
            UyeSatirIndex = dataGridViewOkunanKitaplar.CurrentRow.Index;
            TcKimlikNo = dataGridViewOkunanKitaplar.Rows[UyeSatirIndex].Cells[0].Value.ToString();
            AdiSoyadi = dataGridViewOkunanKitaplar.Rows[UyeSatirIndex].Cells[1].Value.ToString();
            KitapAdi = dataGridViewOkunanKitaplar.Rows[UyeSatirIndex].Cells[2].Value.ToString();
            YazarAdi = dataGridViewOkunanKitaplar.Rows[UyeSatirIndex].Cells[3].Value.ToString();           
            

            labelTcKimlikNo2.Text = TcKimlikNo;
            labelAdiSoyadi2.Text = AdiSoyadi;
            labelKitapAdi2.Text = KitapAdi;
            labelYazarAdi2.Text = YazarAdi;
            
        }

        private void buttonKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonHasarlıGetirenler_Click(object sender, EventArgs e)
        {
            FormPdfRaporHasarliGetirenler FormPdfRaporHasarliGetirenler = new FormPdfRaporHasarliGetirenler();
            FormPdfRaporHasarliGetirenler.Show();
            
        }


        private void buttonEnCokOkunanlar_Click(object sender, EventArgs e)
        {
            FormPdfRaporEnCokOkunanlar FormPdfRaporEnCokOkunanlar = new FormPdfRaporEnCokOkunanlar();
            FormPdfRaporEnCokOkunanlar.Show();
        }

        private void buttonEnokOkuyanlar_Click(object sender, EventArgs e)
        {
            FormPdfRaporEnCokOkuyanlar FormPdfRaporEnCokOkuyanlar = new FormPdfRaporEnCokOkuyanlar();
            FormPdfRaporEnCokOkuyanlar.Show();            
        }
        string OkunanKitaplardaAra;
        private void comboBoxOkunanKitaplardaAra_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxOkunanKitaplardaAra.Text.ToString() == "Tc Kimlik No")
                OkunanKitaplardaAra = "TbUyeler.TcKimlikNo";
            if (comboBoxOkunanKitaplardaAra.Text.ToString() == "Adı Soyadı")
                OkunanKitaplardaAra = "TbUyeler.AdiSoyadi";
            if (comboBoxOkunanKitaplardaAra.Text.ToString() == "Kitap Adı")
                OkunanKitaplardaAra = "TbKitaplar.KitapAdi";
            if (comboBoxOkunanKitaplardaAra.Text.ToString() == "Yazar Adı")
                OkunanKitaplardaAra = "TbKitaplar.YazarAdi";
            if (comboBoxOkunanKitaplardaAra.Text.ToString() == "Kitap Türü")
                OkunanKitaplardaAra = "TbKitaplar.KitapTuru";            
        }

        private void textBoxOkunanKitaplardaAra_TextChanged(object sender, EventArgs e)
        {
            Kitap.OkunanKitaplardaAra(textBoxOkunanKitaplardaAra.Text.ToString(), dataGridViewOkunanKitaplar, OkunanKitaplardaAra);
        }

        private void buttonUyeninOkuduguKitaplar_Click(object sender, EventArgs e)
        {
            FormPdfRaporUyeninOkuduguKitaplar FormPdfRaporUyeninOkuduguKitaplar = new FormPdfRaporUyeninOkuduguKitaplar();
            FormPdfRaporUyeninOkuduguKitaplar.Show();
        }

        private void buttonKitabiOkuyanUyeler_Click(object sender, EventArgs e)
        {
            FormPdfRaporKitabiOkuyanUyeler FormPdfRaporKitabiOkuyanUyeler = new FormPdfRaporKitabiOkuyanUyeler();
            FormPdfRaporKitabiOkuyanUyeler.Show();
        }
        public static string BaslangicTarihi;
        public static string BitisTarihi;

        private void buttonBuAyOkunanlar_Click(object sender, EventArgs e)
        {
            
            BaslangicTarihi = dateTimePickerBaslangicTarihi.Value.ToString("yyyy-MM-dd");
            BitisTarihi = dateTimePickerBitisTarihi.Value.ToString("yyyy-MM-dd");
         
            FormPdfRaporTarihleriArasindaOkunanlar FormPdfRaporBuAyOkunanlar = new FormPdfRaporTarihleriArasindaOkunanlar();
            FormPdfRaporBuAyOkunanlar.Show();
        }

        private void FormOkunanKitaplar_Load_1(object sender, EventArgs e)
        {

        }

        
       

       
    }
}
