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
    public partial class FormAnaEkran : Form
    {
        public FormAnaEkran()
        {
            InitializeComponent();
        }

        FormYeniKitapKaydet FormYeniKitapKaydet = (FormYeniKitapKaydet)Application.OpenForms["FormYeniKitapKaydet"];
        SqlConnection Baglanti = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=KutuphaneDB;Integrated Security=true");
        int KitapSatirIndex;
        string SutunKitapAdi;
        string SutunYazarAdi;
        int UyeSatirIndex;
        string TcKimlikNo;
        Kitap Kitap = new Kitap();
        Uyeler Uyeler = new Uyeler();
        Emanet Emanet = new Emanet();
        int StokKontrol;        

        public void FormAnaEkran_Load(object sender, EventArgs e)
        {
            Kitap.KitapListele(dataGridViewKitapListesi);
            Uyeler.UyeListele(dataGridViewUyeListesi);
            KitapListesindeAra = "KitapAdi";
            UyelerListesindeAra = "AdiSoyadi";
        }

        private void buttonYeniKitapKaydet_Click(object sender, EventArgs e)
        {
            FormYeniKitapKaydet FormYeniKitapKaydet = new FormYeniKitapKaydet();
            FormYeniKitapKaydet.Show();
        }

        private void buttonYeniUyeKaydet_Click(object sender, EventArgs e)
        {
            FormYeniUyeKaydet FormYeniUyeKaydet = new FormYeniUyeKaydet();
            FormYeniUyeKaydet.Show();          
        }

        private void buttonKitapListele_Click(object sender, EventArgs e)
        {
            FormKitapListele FormKitapListele = new FormKitapListele();
            FormKitapListele.Show();
        }

        private void buttonUyeListele_Click(object sender, EventArgs e)
        {
            FormUyeListele FormUyeListele = new FormUyeListele();
            FormUyeListele.Show();
        }

        private void buttonEmanetKitaplar_Click(object sender, EventArgs e)
        {
            FormEmanetKitaplar FormEmanetKitaplar = new FormEmanetKitaplar();
            FormEmanetKitaplar.Show();
        }

      
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
        private void dataGridViewKitapListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewKitapListesi.CurrentRow != null)
            {
                KitapSatirIndex = dataGridViewKitapListesi.CurrentRow.Index;
                SutunKitapAdi = dataGridViewKitapListesi.Rows[KitapSatirIndex].Cells[0].Value.ToString();
                SutunYazarAdi = dataGridViewKitapListesi.Rows[KitapSatirIndex].Cells[1].Value.ToString();
            }

            if (SutunKitapAdi != "" & SutunYazarAdi != "")
            {
                SqlCommand Komut = new SqlCommand("SELECT * FROM TbKitaplar WHERE KitapAdi='" + SutunKitapAdi + "' AND YazarAdi='" + SutunYazarAdi + "' ", Baglanti);
                Baglanti.Open();
                SqlDataReader Oku = Komut.ExecuteReader();
                Oku.Read();

                textBoxKitapAdi.Text = Oku[0].ToString();
                textBoxYazarAdi.Text = Oku[1].ToString();
                textBoxKitapTuru.Text= Oku[2].ToString();
                textBoxYayinEvi.Text = Oku[3].ToString();
                StokKontrol = Convert.ToInt32(Oku[7]);
                Oku.Close();
                Baglanti.Close();
            }
           
        }

        private void dataGridViewUyeListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
                UyeSatirIndex = dataGridViewUyeListesi.CurrentRow.Index;
                TcKimlikNo = dataGridViewUyeListesi.Rows[UyeSatirIndex].Cells[0].Value.ToString();
           

           
          
            if (TcKimlikNo != "")
            {
                SqlCommand Komut = new SqlCommand("SELECT * FROM TbUyeler WHERE TcKimlikNo='" + TcKimlikNo + "'", Baglanti);
                Baglanti.Open();
                SqlDataReader Oku = Komut.ExecuteReader();
                Oku.Read();
                textBoxTcKimlikNo.Text = Oku[0].ToString();
                textBoxAdiSoyadi.Text = Oku[1].ToString();
                Oku.Close();
                Baglanti.Close();
            }
        }

        private void buttonTeslimEt_Click(object sender, EventArgs e)
        {         
            Emanet.EmanetVer(textBoxTcKimlikNo.Text.ToString(), textBoxKitapAdi.Text.ToString(),textBoxYazarAdi.Text.ToString(),dateTimePickerVerilisTarihi.Value.ToString("yyyy-MM-dd"), dateTimePickerBitisTarihi.Value.ToString("yyyy-MM-dd"),StokKontrol);
            Kitap.KitapListele(dataGridViewKitapListesi);
            Uyeler.UyeListele(dataGridViewUyeListesi);          
        }             

        private void buttonOkunanKitaplar_Click(object sender, EventArgs e)
        {
            FormOkunanKitaplar FormOkunanKitaplar = new FormOkunanKitaplar();
            FormOkunanKitaplar.Show();
        }

         

        private void textBoxKitapListesindeAra_TextChanged(object sender, EventArgs e)
        {
            Kitap.KitapAra(textBoxKitapListesindeAra.Text.ToString(), dataGridViewKitapListesi, KitapListesindeAra);
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
        string UyelerListesindeAra;
        private void comboBoxUyelerListesindeAra_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxUyelerListesindeAra.Text.ToString() == "Tc Kimlik No")
                UyelerListesindeAra = "TcKimlikNo";
            if (comboBoxUyelerListesindeAra.Text.ToString() == "Adı Soyadı")
                UyelerListesindeAra = "AdiSoyadi";
           
        }

        private void textBoxUyelerListesindeAra_TextChanged(object sender, EventArgs e)
        {
            Uyeler.UyeAra(textBoxUyelerListesindeAra.Text.ToString(), dataGridViewUyeListesi, UyelerListesindeAra);
        }

        private void ToolStripKullaniciSifreDegistir_Click(object sender, EventArgs e)
        {
            FormKullaniciSifreGuncelle FormKullaniciSifreGuncelle = new FormKullaniciSifreGuncelle();
            FormKullaniciSifreGuncelle.Show();
        }

        private void FormAnaEkran_Load_1(object sender, EventArgs e)
        {

        }

      
        
       

       
      

       

       


    
    }
}
