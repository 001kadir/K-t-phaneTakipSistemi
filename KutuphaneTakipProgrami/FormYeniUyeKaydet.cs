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
    public partial class FormYeniUyeKaydet : Form
    {
        public FormYeniUyeKaydet()
        {
            InitializeComponent();
        }




        private void YeniUyeKaydet_Load(object sender, EventArgs e)
        {

        }

        private void buttonYeniUyeKaydet_Click(object sender, EventArgs e)
        {
                       
                Uyeler Uyeler = new Uyeler();
                Uyeler.YeniUyeKaydet(textBoxTcKimlikNo.Text.ToString(), textBoxAdiSoyadi.Text.ToString(), dateTimePickerDogumTarihi.Text.ToString(), comboBoxDogumYeri.Text.ToString(), comboBoxCinsiyet.Text.ToString(), dateTimePickerUyelikTarihi.Text.ToString(), textBoxTelefon.Text.ToString(), textBoxEposta.Text.ToString(), textBoxAdres.Text.ToString());
                FormAnaEkran FormanaEkran = (FormAnaEkran)Application.OpenForms["FormAnaEkran"];
                Uyeler.UyeListele(FormanaEkran.dataGridViewUyeListesi);            
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxTcKimlikNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))//rakam giriliyor metin girilemiyor
            {
                e.Handled = true;
            }
        }

        private void textBoxAdiSoyadi_TextChanged(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo Dil;
            Dil = new System.Globalization.CultureInfo("tr-TR");
            textBoxAdiSoyadi.Text = textBoxAdiSoyadi.Text.ToUpper(Dil);
            textBoxAdiSoyadi.SelectionStart = textBoxAdiSoyadi.Text.Length;//imleci en sağa al
        }

      

      

        private void comboBoxDogumYeri_TextChanged(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo Dil;
            Dil = new System.Globalization.CultureInfo("tr-TR");
            comboBoxDogumYeri.Text = comboBoxDogumYeri.Text.ToUpper(Dil);
            comboBoxDogumYeri.SelectionStart = comboBoxDogumYeri.Text.Length;
        }

        private void comboBoxCinsiyet_TextChanged(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo Dil;
            Dil = new System.Globalization.CultureInfo("tr-TR");
            comboBoxCinsiyet.Text = comboBoxCinsiyet.Text.ToUpper(Dil);
            comboBoxCinsiyet.SelectionStart = comboBoxCinsiyet.Text.Length;
        }

        
    }
}
