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
    public partial class FormKitapListele : Form
    {
        public FormKitapListele()
        {
            InitializeComponent();
        }
        SqlConnection Baglanti = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=KutuphaneDB;Integrated Security=true");
        int KitapSatirIndex;
        string SutunKitapAdi;
        string SutunYazarAdi;
        Kitap Kitap = new Kitap();
        private void FormKitapListele_Load(object sender, EventArgs e)
        {
                       
            Kitap.KitapListele(dataGridViewKitapListesi);
            KitapListesindeAra = "KitapAdi";
          
        }

       
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonKitapGuncelle_Click(object sender, EventArgs e)
        {
            
            
            Kitap.KitapGuncelle(textBoxBarkodNo.Text.ToString(), textBoxKitapAdi.Text.ToString(), textBoxYazarAdi.Text.ToString(), comboBoxKitapTuru.Text.ToString(), textBoxYayinEvi.Text.ToString(), dateTimePickerTeminTarihi.Text.ToString(), comboBoxTeminBicimi.Text.ToString(), Convert.ToInt32(textBoxStokSayisi.Text),SutunKitapAdi,SutunYazarAdi);
            Kitap.KitapListele(dataGridViewKitapListesi);
             FormAnaEkran FormAnaEkran = (FormAnaEkran)Application.OpenForms["FormAnaEkran"];            
            Kitap.KitapListele(FormAnaEkran.dataGridViewKitapListesi);
         
        }

        private void dataGridViewKitapListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            KitapSatirIndex = dataGridViewKitapListesi.CurrentRow.Index;
            SutunKitapAdi = dataGridViewKitapListesi.Rows[KitapSatirIndex].Cells[0].Value.ToString();
            SutunYazarAdi = dataGridViewKitapListesi.Rows[KitapSatirIndex].Cells[1].Value.ToString();          

            SqlCommand Komut = new SqlCommand("SELECT * FROM TbKitaplar WHERE KitapAdi='" + SutunKitapAdi + "' AND YazarAdi='" + SutunYazarAdi + "'", Baglanti);
                Baglanti.Open();
                SqlDataReader Oku = Komut.ExecuteReader();
                Oku.Read();

                textBoxKitapAdi.Text = Oku[0].ToString();
                textBoxYazarAdi.Text = Oku[1].ToString();
                comboBoxKitapTuru.Text = Oku[2].ToString();
                textBoxYayinEvi.Text = Oku[3].ToString();
                textBoxBarkodNo.Text = Oku[4].ToString();
                dateTimePickerTeminTarihi.Text = Oku[5].ToString();
                comboBoxTeminBicimi.Text = Oku[6].ToString();
                textBoxStokSayisi.Text = Oku[7].ToString();
                Oku.Close();
                Baglanti.Close();
           
        }

        private void buttonKitapsil_Click(object sender, EventArgs e)
        {
            Kitap.KitapSil(textBoxKitapAdi.Text,textBoxYazarAdi.Text);
            Kitap.KitapListele(dataGridViewKitapListesi);
            
        }
        string KitapListesindeAra;
        private void comboBoxKitapListesindeAra_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxKitapListesindeAra.Text.ToString() == "Kitap Adı")
                KitapListesindeAra = "KitapAdi";
            if (comboBoxKitapListesindeAra.Text.ToString() == "Yazar Adı")
                KitapListesindeAra = "YazarAdi";
            if (comboBoxKitapListesindeAra.Text.ToString() == "Kitap Türü")
                KitapListesindeAra = "KitapTuru";
            if (comboBoxKitapListesindeAra.Text.ToString() == "Yayın Evi")
                KitapListesindeAra = "YayinEvi";
        }

        private void textBoxKitapListesindeAra_TextChanged(object sender, EventArgs e)
        {
            Kitap.KitapAra(textBoxKitapListesindeAra.Text.ToString(), dataGridViewKitapListesi, KitapListesindeAra);
        }

        private void FormKitapListele_Load_1(object sender, EventArgs e)
        {

        }
    }
}
