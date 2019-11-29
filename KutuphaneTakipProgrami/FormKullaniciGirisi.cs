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

using System.IO;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;

namespace KutuphaneTakipProgrami
{
    public partial class FormKullaniciGirisi : Form
    {
        public FormKullaniciGirisi()
        {
            InitializeComponent();
        }
        public SqlConnection Baglanti = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=KutuphaneDB;Integrated Security=true");

        string Kullanici_Adi;
        String Kullanici_Sifre;
        private void btn_Giris_Click(object sender, EventArgs e)
        {
            
            Kullanici_Adi = textBox_Kullanici_Adi.Text.ToLower().Trim();
            Kullanici_Sifre = textBox_Sifre.Text.ToLower().Trim();
            SqlCommand Komut = new SqlCommand("Select * From TbKullanici", Baglanti);
            Baglanti.Open();
            Komut.ExecuteNonQuery();
            SqlDataReader Oku = Komut.ExecuteReader();
            while (Oku.Read())
            {
                if (Kullanici_Adi == Oku[0].ToString() && Kullanici_Sifre == (Oku[1].ToString()))
                {

                    this.Hide();
                    FormAnaEkran FormAnaEkran = new FormAnaEkran();
                    FormAnaEkran.ShowDialog();
                    this.Hide();
                    
                }

                lbl_Hatali_Giris.Visible = true;

            }
            Baglanti.Close();

        }

        private void veriTabanıOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                string sqlConnectionString = "Data Source=localhost\\SQLEXPRESS;Integrated Security=true";

                FileInfo file = new FileInfo("C:\\Program Files\\KutuphaneDBScript\\KutuphaneDBScript.sql");

                string script = file.OpenText().ReadToEnd();

                SqlConnection conn = new SqlConnection(sqlConnectionString);

                Server server = new Server(new ServerConnection(conn));

                server.ConnectionContext.ExecuteNonQuery(script);
                MessageBox.Show("Veri Tabanı oluşturuldu!!!");

            }

            catch 
            {
        
                MessageBox.Show("Veri Tabanı daha önce oluşturulmuş!!!");
            }

        }

        private void FormKullaniciGirisi_Load(object sender, EventArgs e)
        {
            textBox_Sifre.PasswordChar = (char)42;
        }

        

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
