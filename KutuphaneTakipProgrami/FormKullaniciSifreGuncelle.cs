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

namespace KutuphaneTakipProgrami
{
    public partial class FormKullaniciSifreGuncelle : Form
    {
        public FormKullaniciSifreGuncelle()
        {
            InitializeComponent();
        }
        SqlConnection Baglanti = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=KutuphaneDB;MultipleActiveResultSets=True;Integrated Security=true");

        private void buttonKullaniciKaydet_Click(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(Baglanti.State) == false) { Baglanti.Open(); }
            SqlCommand Command = new SqlCommand();
            Command.Connection = Baglanti;
            Command.CommandText = ("Select * From TbKullanici");
            SqlDataReader Oku = Command.ExecuteReader();
            Oku.Read();
            if (textBoxKullaniciAdi.Text.Trim().ToLower() == Oku[0].ToString() & textBoxKullaniciSifre.Text.Trim().ToLower() == Oku[1].ToString())
            {
                if (textBoxYeniSifre.Text == textBoxYeniSifreTekrar.Text)
                
                    {
                        if (Convert.ToBoolean(Baglanti.State) == false) { Baglanti.Open(); }
                        SqlCommand Komut = new SqlCommand();
                        Komut.Connection = Baglanti;
                        Komut.CommandText = ("Update TbKullanici  SET Sifre='" + textBoxYeniSifre.Text.ToLower().Trim() + "'");
                        Komut.ExecuteNonQuery();
                        Baglanti.Close();
                        MessageBox.Show("Kullanıcı şifre değiştirildi!!!");                        
                    }
                    else{MessageBox.Show("Yeni şifrenizi tekrar giriniz!!!");}                   
                
            }

            else { MessageBox.Show("Kullanıcı adı veya şifrenizi yanlış girdiniz!!!"); }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormKullaniciSifreGuncelle_Load(object sender, EventArgs e)
        {
            textBoxKullaniciSifre.PasswordChar = (char)42;
            textBoxYeniSifre.PasswordChar = (char)42;
           textBoxYeniSifreTekrar.PasswordChar = (char)42;
        }
    }
}
