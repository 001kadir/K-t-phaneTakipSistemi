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
    public partial class FormEmanetKitaplar : Form
    {
        public FormEmanetKitaplar()
        {
            InitializeComponent();
        }
        SqlConnection Baglanti = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=KutuphaneDB;Integrated Security=true");
        Emanet Emanet = new Emanet();
        int EmanetSatirIndex;
        string TcKimlikNo;
        string KitapAdi;
        string YazarAdi;
        string VerilisTarihi;       
        string HasarDurumu;
        string ParametreVerilisTarihi;

        
        private void FormEmanetKitaplar_Load(object sender, EventArgs e)
        {
            Emanet.EmanetListele(dataGridViewEmanetKitaplar);
            Emanet.EmanetListele(dataGridViewEmanetKitaplar);
            EmanetListesindeAra = "TbUyeler.AdiSoyadi";
             
        }

        private void labelKitapTuru_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxHasarliTeslimAl_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    
        

        private void buttonTeslimAl_Click(object sender, EventArgs e)
        {
            if (checkBoxHasarliTeslimAl.Checked == true) { HasarDurumu = "Hasarlı Getirdi"; MessageBox.Show("Kitap hasarlı teslim alınacak"); }                

            Emanet.EmanetAl(dataGridViewEmanetKitaplar, TcKimlikNo, KitapAdi, YazarAdi, ParametreVerilisTarihi, dateTimePickerTeslimTarihi.Value.ToString("yyyy-MM-dd"), HasarDurumu);
            Emanet.EmanetListele(dataGridViewEmanetKitaplar);
            FormAnaEkran FormanaEkran = (FormAnaEkran)Application.OpenForms["FormAnaEkran"];
            Kitap Kitap = new Kitap();
            Kitap.KitapListele(FormanaEkran.dataGridViewKitapListesi);

        }




        private void dataGridViewEmanetKitaplar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            EmanetSatirIndex = dataGridViewEmanetKitaplar.CurrentRow.Index;
            TcKimlikNo = dataGridViewEmanetKitaplar.Rows[EmanetSatirIndex].Cells[0].Value.ToString();
            KitapAdi = dataGridViewEmanetKitaplar.Rows[EmanetSatirIndex].Cells[2].Value.ToString();
            YazarAdi = dataGridViewEmanetKitaplar.Rows[EmanetSatirIndex].Cells[3].Value.ToString();
            VerilisTarihi = dataGridViewEmanetKitaplar.Rows[EmanetSatirIndex].Cells[5].Value.ToString();
            DateTime dt = DateTime.Parse(VerilisTarihi);

            ParametreVerilisTarihi = dt.ToString("yyyy-MM-dd");
 
        }

        private void checkBoxSuresiBitenler_CheckedChanged(object sender, EventArgs e)
        {


            if (checkBoxSuresiBitenler.Checked == true)
            {
                Emanet.SuresiBitenler(dataGridViewEmanetKitaplar);
            }

            else
            {
                Emanet.EmanetListele(dataGridViewEmanetKitaplar);
            }

        }
        string EmanetListesindeAra;
        private void comboBoxEmanetListesindeAra_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxEmanetListesindeAra.Text.ToString() == "Tc Kimlik No")
                EmanetListesindeAra = "TbUyeler.TcKimlikNo";
            if (comboBoxEmanetListesindeAra.Text.ToString() == "Adı Soyadı")
                EmanetListesindeAra = "TbUyeler.AdiSoyadi";
            if (comboBoxEmanetListesindeAra.Text.ToString() == "Kitap Adı")
                EmanetListesindeAra = "TbKitaplar.KitapAdi";
            if (comboBoxEmanetListesindeAra.Text.ToString() == "Yazar Adı")
                EmanetListesindeAra = "TbKitaplar.YazarAdi";
            if (comboBoxEmanetListesindeAra.Text.ToString() == "Kitap Türü")
                EmanetListesindeAra = "TbKitaplar.KitapTuru";
            
        }

        private void textBoxEmanetListesindeAra_TextChanged(object sender, EventArgs e)
        {
            Emanet.EmanetAra(textBoxEmanetListesindeAra.Text.ToString(), dataGridViewEmanetKitaplar, EmanetListesindeAra);
        }

       

        
        
    }
}
