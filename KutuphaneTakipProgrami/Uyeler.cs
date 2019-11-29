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
    public class Uyeler
    {

       SqlConnection Baglanti = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=KutuphaneDB;MultipleActiveResultSets=True;Integrated Security=true");



       public void YeniUyeKaydet(string TCKimlikNo, string AdiSoyadi, string DogumTarihi, string DogumYeri,
           string Cinsiyet, string UyelikTarihi, string Telefon, string Eposta, string Adres)
           /*
            * sqlconnection ile bağlanti aç ve yolunu belirt 
            * tıklandığında çalışacak metodu yaz 
            * her bir textboxdan alıcak veri için değişken tanımla 
            * ve koda başla 
            * burada tc kmlik no ya göre veritabanına gireceğin için gerekli kontrolü yaz 
            * bağlantıyı kontrol et ve bağlantıyı aç 
            * sqlcommand'ın içinden bir nesne oluştur ve bunun içinde gerekli kodu yaz 
            * sqldatareader ile yazdığın komutu execute et 
            * koşulları gerçekleştir 
            * 1-aynı kimlik numarasına ikinci bir kimse yerlleştirilmemeli
            * 
            * 
            * 
            */
           {
           if (TCKimlikNo.Length == 11)
           {
               if (TCKimlikNo == "" | AdiSoyadi == "")
               {
                   MessageBox.Show("Tc Kimlik No ve Adı Soyadı alanları boş geçilemez");
               }
               else
               {
                   if (Convert.ToBoolean(Baglanti.State) == false) { Baglanti.Open(); }

                   SqlCommand Command = new SqlCommand("SELECT TcKimlikno FROM TbUyeler WHERE TcKimlikNo='" + TCKimlikNo + "' ", Baglanti);
                   SqlDataReader Reader = Command.ExecuteReader();
                   if (Reader.Read())
                   {
                       if (TCKimlikNo == Reader[0].ToString())
                       {
                           MessageBox.Show("Girilen Tc Kimlik Numarası sistemde kayıtlıdır!!!");
                           Reader.Close();
                       }
                       /*sqlconnection baglanti = new sqlconnection("");
                        * public void yeniüyekaydet(String tckimlikno,String adisoyadi,String dogumtarihi,String dogumyeri)
                        * if (tckimlikno.length ==11){
                        * if (tckimlikno==""|| adisoyadi="")
                        * messagebox.show(tc kimlik no ve ad soyad alanları boş geçilemez);
                        * */

                   }
                   else
                   {
                       Reader.Close();//Readerı kapatmamız gerekiyor
                       if (Convert.ToBoolean(Baglanti.State) == false) { Baglanti.Open(); }
                       SqlCommand Komut = new SqlCommand();
                       Komut.Connection = Baglanti;
                       Komut.CommandText = ("INSERT INTO TbUyeler (TcKimlikNo,AdiSoyadi,DogumTarihi,DogumYeri,Cinsiyet,UyelikTarihi,Telefon,Eposta,Adres) values ('" + TCKimlikNo + "','" + AdiSoyadi + "','" + DogumTarihi + "','" + DogumYeri + "','" + Cinsiyet + "','" + UyelikTarihi + "','" + Telefon + "','" + Eposta + "','" + Adres + "')");
                       Komut.ExecuteNonQuery();
                       MessageBox.Show("Üye kayıt işlemi tamamlandı");
                       Baglanti.Close();
                       Reader.Close();
                   }
               }
           }
           else { MessageBox.Show("Tc Kimlik Numarası 11 haneli girilmelidir!!!"); }
       }
      
      public void UyeListele(DataGridView DataGridview)
      {
          if (Convert.ToBoolean(Baglanti.State) == false) { Baglanti.Open(); }
          SqlDataAdapter DataAdapter = new SqlDataAdapter();
          DataTable DataTable = new DataTable();          
          DataAdapter.SelectCommand = new SqlCommand("SELECT TcKimlikNo as 'Tc Kimlik No', AdiSoyadi as 'Adı Soyadı', DogumTarihi as 'Doğum Tarihi', DogumYeri as 'Doğum Yeri',Cinsiyet as 'Cinsiyet',UyelikTarihi as 'ÜyelikTarihi', Telefon as 'Telefon', Eposta as 'Eposta', Adres as 'Adres'FROM TbUyeler", Baglanti);
          DataAdapter.Fill(DataTable);
          DataGridview.DataSource = DataTable;
          Baglanti.Close();
      }

      public void UyeAra(string TextBoxAra, DataGridView DataGridView,string Ara)
      {
          SqlDataAdapter DataAdapter = new SqlDataAdapter();   
          DataTable DataTable = new DataTable();
          SqlCommand Komut = new SqlCommand();

          if (TextBoxAra == "")
          {         
              Komut.Connection = Baglanti;
              Komut.CommandText = "Select * FROM TbUyeler";
              DataAdapter.SelectCommand = Komut;                         
              DataAdapter.Fill(DataTable);
              DataTable.Clear(); 
          }

          if (Convert.ToBoolean(Baglanti.State) == false) {Baglanti.Open();}
          
                Komut.Connection = Baglanti;
                Komut.CommandText = " Select * From TbUyeler WHERE (" + Ara + " LIKE '%" + TextBoxAra + "%' )";
                DataAdapter.SelectCommand = Komut;        
                DataAdapter.Fill(DataTable);
                DataGridView.DataSource = DataTable;
                Baglanti.Close();  
       }


      public void UyeGuncelle(string TCKimlikNo, string AdiSoyadi, string DogumTarihi, string DogumYeri, string Cinsiyet, string UyelikTarihi, string Telefon, string Eposta, string Adres, string TcKimlikNo)
      {
          if (Convert.ToBoolean(Baglanti.State) == false) { Baglanti.Open(); }

          SqlCommand Command = new SqlCommand("UPDATE TbUyeler SET TcKimlikNo='" + TCKimlikNo + "',AdiSoyadi='" + AdiSoyadi + "',DogumTarihi='" + DogumTarihi + "',DogumYeri='" + DogumYeri + "',Cinsiyet='" + Cinsiyet + "',UyelikTarihi='" + UyelikTarihi + "',Telefon='" + Telefon + "',Eposta='" + Eposta + "' where TcKimlikNo ='" + TCKimlikNo + "'", Baglanti);
          Command.ExecuteNonQuery();
          Baglanti.Close();
          MessageBox.Show("Üye bilgileri güncellendi!!!");

      }


      public void UyeSil(string TcKimlikNo)
      {
          try
          {
              if (Convert.ToBoolean(Baglanti.State) == false) { Baglanti.Open(); }
              SqlCommand Command = new SqlCommand("DELETE FROM TbUyeler WHERE TcKimlikNo='" + TcKimlikNo + "'", Baglanti);
              Command.ExecuteNonQuery();
              Baglanti.Close();
              MessageBox.Show("Üye bilgileri silindi");
          }


          catch(SqlException Hata)

          {
              if (Hata.ErrorCode == -2146232060)//Primary Key hatası
             {
                 MessageBox.Show("Üye emanet kitapları getirmedi, önce emanet kaydını kapatınız!!!","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Information); 
              }


          }


      }


    }
}
