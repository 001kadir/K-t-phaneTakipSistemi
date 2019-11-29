using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KutuphaneTakipProgrami
{
    public partial class FormYeniKitapKaydet : Form
    {
        public FormYeniKitapKaydet()
        {
            InitializeComponent();
        }

        Kitap Kitap = new Kitap();      

        private void buttonYeniKitapKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxStokSayisi.Text))//stok sayısı boş değer kontrol
            { MessageBox.Show("Stok Sayısını boş bırakmayınız"); }
           
            else
            {
                Kitap.YeniKitapKaydet(textBoxBarkodNo.Text.ToString(), textBoxKitapAdi.Text.ToString(), textBoxYazarAdi.Text.ToString(), comboBoxKitapTuru.Text.ToString(), textBoxYayinEvi.Text.ToString(), dateTimePickerTeminTarihi.Text.ToString(), comboBoxTeminBicimi.Text.ToString(), Convert.ToInt32(textBoxStokSayisi.Text.Trim()));
                //Ana ekranda datagrid güncelleniyor(açık olan formu kullanıyoruz).
                FormAnaEkran FormAnaEkran = (FormAnaEkran)Application.OpenForms["FormAnaEkran"];
                Kitap.KitapListele(FormAnaEkran.dataGridViewKitapListesi);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxKitapAdi_TextChanged(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo Dil;
            Dil = new System.Globalization.CultureInfo("tr-TR");
            textBoxKitapAdi.Text = textBoxKitapAdi.Text.ToUpper(Dil);
            textBoxKitapAdi.SelectionStart = textBoxKitapAdi.Text.Length; 
        }

        private void textBoxStokSayisi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))//rakam giriliyor metin girilemiyor
            {
                e.Handled = true;
            }
        }

        private void textBoxYazarAdi_TextChanged(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo Dil;
            Dil = new System.Globalization.CultureInfo("tr-TR");
            textBoxYazarAdi.Text = textBoxYazarAdi.Text.ToUpper(Dil);
            textBoxYazarAdi.SelectionStart = textBoxYazarAdi.Text.Length; 
        }

        private void textBoxYayinEvi_TextChanged(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo Dil;
            Dil = new System.Globalization.CultureInfo("tr-TR");
            textBoxYayinEvi.Text = textBoxYayinEvi.Text.ToUpper(Dil);
            textBoxYayinEvi.SelectionStart = textBoxYayinEvi.Text.Length; 
        }

        private void comboBoxKitapTuru_TextChanged(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo Dil;
            Dil = new System.Globalization.CultureInfo("tr-TR");
            comboBoxKitapTuru.Text = comboBoxKitapTuru.Text.ToUpper(Dil);
            comboBoxKitapTuru.SelectionStart = comboBoxKitapTuru.Text.Length; 
        }

        private void comboBoxTeminBicimi_TextChanged(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo Dil;
            Dil = new System.Globalization.CultureInfo("tr-TR");
            comboBoxTeminBicimi.Text = comboBoxTeminBicimi.Text.ToUpper(Dil);
            comboBoxTeminBicimi.SelectionStart = comboBoxTeminBicimi.Text.Length;
        }

        private void FormYeniKitapKaydet_Load(object sender, EventArgs e)
        {

        }

        

        

       

       
    }
}
