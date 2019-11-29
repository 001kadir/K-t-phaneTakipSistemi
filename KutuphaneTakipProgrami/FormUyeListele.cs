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
    public partial class FormUyeListele : Form
    {
        public FormUyeListele()
        {
            InitializeComponent();
        }
        SqlConnection Baglanti = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=KutuphaneDB;Integrated Security=true");
        int SatirIndex;
        string TcKimlikNo;
         Uyeler Uyeler = new Uyeler();
        private void FormUyeListele_Load(object sender, EventArgs e)
        {
                        Uyeler.UyeListele(dataGridViewUyeListesi);
                        UyelerListesindeAra = "AdiSoyadi";
        }

       

        private void buttonUyeGuncelle_Click(object sender, EventArgs e)
        {

            Uyeler.UyeGuncelle(textBoxTcKimlikNo.Text.ToString(), textBoxAdiSoyadi.Text.ToString(), dateTimePickerDogumTarihi.Text.ToString(), comboBoxDogumYeri.Text.ToString(), comboBoxCinsiyet.Text.ToString(), dateTimePickerUyelikTarihi.Text.ToString(), textBoxTelefon.Text.ToString(), textBoxEposta.Text.ToString(), textBoxAdres.Text.ToString(), TcKimlikNo);
            Uyeler.UyeListele(dataGridViewUyeListesi);
            FormAnaEkran FormanaEkran = (FormAnaEkran)Application.OpenForms["FormAnaEkran"];
            Uyeler.UyeListele(FormanaEkran.dataGridViewUyeListesi);
        }

        private void dataGridViewUyeListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SatirIndex = dataGridViewUyeListesi.CurrentRow.Index;
            TcKimlikNo = dataGridViewUyeListesi.Rows[SatirIndex].Cells[0].Value.ToString();
         
            SqlCommand Komut = new SqlCommand("SELECT * FROM TbUyeler WHERE TcKimlikNo='" + TcKimlikNo + "'", Baglanti);
            Baglanti.Open();
            SqlDataReader Oku = Komut.ExecuteReader();
            Oku.Read();

            textBoxTcKimlikNo.Text = Oku[0].ToString();
            textBoxAdiSoyadi.Text = Oku[1].ToString();
            dateTimePickerDogumTarihi.Text = Oku[2].ToString();
            comboBoxDogumYeri.Text= Oku[3].ToString();
            comboBoxCinsiyet.Text = Oku[4].ToString();
            dateTimePickerUyelikTarihi.Text = Oku[5].ToString();
            textBoxTelefon.Text = Oku[6].ToString();
            textBoxEposta.Text = Oku[7].ToString();
            textBoxAdres.Text = Oku[8].ToString();
            Oku.Close();
            Baglanti.Close();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonUyeSil_Click(object sender, EventArgs e)
        {
            Uyeler.UyeSil(textBoxTcKimlikNo.Text);
            Uyeler.UyeListele(dataGridViewUyeListesi);
        }
        string UyelerListesindeAra;
        private void textBoxUyelerListesindeAra_TextChanged(object sender, EventArgs e)
        {
            Uyeler.UyeAra(textBoxUyelerListesindeAra.Text.ToString(), dataGridViewUyeListesi, UyelerListesindeAra);
           
        }

        private void comboBoxUyelerListesindeAra_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxUyelerListesindeAra.Text.ToString() == "Tc Kimlik No")
                UyelerListesindeAra = "TcKimlikNo";
            if (comboBoxUyelerListesindeAra.Text.ToString() == "Adı Soyadı")
                UyelerListesindeAra = "AdiSoyadi";
            if (comboBoxUyelerListesindeAra.Text.ToString() == "Duğum Yeri")
                UyelerListesindeAra = "DogumYeri";
        }

        private void textBoxAdres_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
