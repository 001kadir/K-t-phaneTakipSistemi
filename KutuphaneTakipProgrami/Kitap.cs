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
   public class Kitap
    {
       SqlConnection Baglanti = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=KutuphaneDB;MultipleActiveResultSets=True;Integrated Security=true");
      
     
      public void YeniKitapKaydet(string BarkodNo,string KitapAdi,string YazarAdi,string KitapTuru,string YayinEvi,string TeminTarihi,string TeminBicimi,int StokSayisi)
       {
          
           if (string.IsNullOrEmpty(KitapAdi) | string.IsNullOrEmpty(YazarAdi))
               MessageBox.Show("Kitap Adı ve Yazar Adı alanlarını boş bırakmayınız");
           else
           {
               if (Convert.ToBoolean(Baglanti.State) == false) { Baglanti.Open(); }
               SqlCommand Command = new SqlCommand("SELECT KitapAdi,YazarAdi FROM TbKitaplar WHERE KitapAdi='"+KitapAdi+"' AND YazarAdi='"+YazarAdi+"'",Baglanti);
               SqlDataReader Reader = Command.ExecuteReader();
               if (Reader.Read())
               {

                   if (KitapAdi == Reader[0].ToString() & YazarAdi == Reader[1].ToString())
                       MessageBox.Show("Kitap kütüphanede kayıtlı");
                   Reader.Close();
               }

               else 
               {
                 Reader.Close();// Readeri kapatmamız gerekiyor
               SqlCommand Komut = new SqlCommand();
               if (Convert.ToBoolean(Baglanti.State) == false) { Baglanti.Open(); }

               Komut.Connection = Baglanti;
               Komut.CommandText = ("INSERT INTO TbKitaplar (BarkodNo,KitapAdi,YazarAdi,KitapTuru,YayinEvi,TeminTarihi,TeminBicimi,StokSayisi) values ('" + BarkodNo + "','" + KitapAdi + "','" + YazarAdi + "','" + KitapTuru + "','" + YayinEvi + "','" + TeminTarihi + "','" + TeminBicimi + "','" + StokSayisi + "')");
               Komut.ExecuteNonQuery();
               Baglanti.Close();
               MessageBox.Show("Kitap kayıt işlemi tamamlandı");
                   }
           }
       }



      public void KitapSil(string KitapAdi,string YazarAdi)


      {



          try
          {
              if (Convert.ToBoolean(Baglanti.State) == false) { Baglanti.Open(); }
              SqlCommand Command = new SqlCommand("DELETE FROM TbKitaplar WHERE KitapAdi='" + KitapAdi + "'AND YazarAdi='"+YazarAdi+"'", Baglanti);
              Command.ExecuteNonQuery();
              Baglanti.Close();
              MessageBox.Show("Kitap kütüphaneden silindi!!!");
          }


          catch (SqlException Hata)
          {
              if (Hata.ErrorCode == -2146232060)//Primary Key hatası
              {
                  MessageBox.Show("Bu  kitap emanet listesinde,önce emanet kaydını kapatınız!!!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information); 
              }
          }
      }


      public void KitapListele(DataGridView DataGridView)

      {

          SqlDataAdapter DataAdapter = new SqlDataAdapter();
          DataTable DataTable = new DataTable();
          if (Convert.ToBoolean(Baglanti.State) == false) { Baglanti.Open(); }
       
          DataAdapter.SelectCommand=new SqlCommand("SELECT  KitapAdi as 'Kitap Adı',YazarAdi as 'Yazar Adı',KitapTuru as 'Kitap Türü', YayinEvi as 'Yayın Evi',BarkodNo as 'Barkod No', TeminTarihi  as 'Temin Tarihi',TeminBicimi as 'Temin Biçimi',StokSayisi as 'Stok Sayısı' FROM TbKitaplar",Baglanti);      
          DataAdapter.Fill(DataTable);
          DataGridView.DataSource = DataTable;
                    
      }

      public void KitapAra(string TextBoxAra, DataGridView DataGridView, string Ara)
      {

          SqlDataAdapter DataAdapter = new SqlDataAdapter();
          DataTable DataTable = new DataTable();
          SqlCommand Komut = new SqlCommand();

          if (TextBoxAra == "")
          {

              Komut.Connection = Baglanti;
              Komut.CommandText = "Select * FROM TbKitaplar";
              DataAdapter.SelectCommand = Komut;
              DataAdapter.Fill(DataTable);
              DataTable.Clear();
          }

          if (Convert.ToBoolean(Baglanti.State) == false) { Baglanti.Open(); }

          Komut.Connection = Baglanti;
          Komut.CommandText = " Select * From TbKitaplar WHERE (" + Ara + " LIKE '%" + TextBoxAra + "%' )";
          DataAdapter.SelectCommand = Komut;
          DataAdapter.Fill(DataTable);
          DataGridView.DataSource = DataTable;
          Baglanti.Close();

      }


      public void KitapGuncelle(string BarkodNo, string KitapAdi, string YazarAdi, string KitapTuru, string YayinEvi, string TeminTarihi, string TeminBicimi, int StokSayisi,string SutunKitapAdi,string SutunYazarAdi)


      {
          if (Convert.ToBoolean(Baglanti.State) == false) { Baglanti.Open(); }

          try
          {

              SqlCommand Command = new SqlCommand("UPDATE TbKitaplar SET BarkodNo='" + BarkodNo + "',KitapAdi='" + KitapAdi + "',YazarAdi='" + YazarAdi + "',KitapTuru='" + KitapTuru + "',YayinEvi='" + YayinEvi + "',TeminTarihi='" + TeminTarihi + "',TeminBicimi='" + TeminBicimi + "',StokSayisi='" + StokSayisi + "' where KitapAdi='" + SutunKitapAdi + "' AND YazarAdi='" + SutunYazarAdi + "'", Baglanti);
              Command.ExecuteNonQuery();
              Baglanti.Close();
              MessageBox.Show("Kitap bilgileri güncellendi!!!");
          }
          catch(SqlException Hata)
          {
              if (Hata.ErrorCode == -2146232060)
              { MessageBox.Show("Emanet listesinde kayıtlı bir kitabın Kitap Adı ve Yazar Adı bilgileri güncellenemez!!!"); }
          
          }
      
      }

      public void OkunanKitaplar(DataGridView DataGridView)


      {
          SqlDataAdapter DataAdapter = new SqlDataAdapter();
          DataTable DataTable = new DataTable();
          if (Convert.ToBoolean(Baglanti.State) == false) { Baglanti.Open(); }

          DataAdapter.SelectCommand = new SqlCommand("SELECT TbUyeler.TcKimlikNo AS 'TC Kimlik No',TbUyeler.AdiSoyadi AS 'Adı Soyadı',TbKitaplar.KitapAdi AS 'Kitap Adı',TbKitaplar.YazarAdi AS 'Yazar Adı',TbKitaplar.Kitapturu AS 'Kitap Türü',TbOkunanKitaplar.VerilisTarihi AS 'Veriliş Tarihi',TbOkunanKitaplar.BitisTarihi AS 'Bitiş Tarihi',TbOkunanKitaplar.TeslimTarihi AS 'Teslim Tarihi',TbOkunanKitaplar.HasarDurumu as 'Hasar Durumu' From TbKitaplar INNER JOIN TbOkunanKitaplar ON TbKitaplar.KitapAdi=TbOkunanKitaplar.KitapAdi AND TbKitaplar.YazarAdi=TbOkunanKitaplar.YazarAdi  INNER JOIN TbUyeler ON TbOkunanKitaplar.TcKimlikNo=TbUyeler.TcKimlikNo ", Baglanti);
          DataAdapter.Fill(DataTable);
          DataGridView.DataSource = DataTable;
          DataGridView.Columns[1].Width = 120;
          DataGridView.Columns[2].Width = 140;
          DataGridView.Columns[3].Width = 140;
            
      }


      public void OkunanKitaplardaAra(string TextBoxAra, DataGridView DataGridView, string Ara)

      {

          SqlDataAdapter DataAdapter = new SqlDataAdapter();
          DataTable DataTable = new DataTable();
          SqlCommand Komut = new SqlCommand();

          if (TextBoxAra == "")
          {

              Komut.Connection = Baglanti;
              Komut.CommandText = "SELECT TbUyeler.TcKimlikNo AS 'TC Kimlik No',TbUyeler.AdiSoyadi AS 'Adı Soyadı',TbKitaplar.KitapAdi AS 'Kitap Adı',TbKitaplar.YazarAdi AS 'Yazar Adı',TbKitaplar.Kitapturu AS 'Kitap Türü',TbOkunanKitaplar.VerilisTarihi AS 'Veriliş Tarihi',TbOkunanKitaplar.BitisTarihi AS 'Bitiş Tarihi',TbOkunanKitaplar.TeslimTarihi AS 'Teslim Tarihi',TbOkunanKitaplar.HasarDurumu as 'Hasar Durumu' From TbKitaplar INNER JOIN TbOkunanKitaplar ON TbKitaplar.KitapAdi=TbOkunanKitaplar.KitapAdi AND TbKitaplar.YazarAdi=TbOkunanKitaplar.YazarAdi  INNER JOIN TbUyeler ON TbOkunanKitaplar.TcKimlikNo=TbUyeler.TcKimlikNo ";
              DataAdapter.SelectCommand = Komut;
              DataAdapter.Fill(DataTable);
              DataTable.Clear();
          }

          if (Convert.ToBoolean(Baglanti.State) == false) { Baglanti.Open(); }

          Komut.Connection = Baglanti;
          Komut.CommandText = " SELECT TbUyeler.TcKimlikNo AS 'TC Kimlik No',TbUyeler.AdiSoyadi AS 'Adı Soyadı',TbKitaplar.KitapAdi AS 'Kitap Adı',TbKitaplar.YazarAdi AS 'Yazar Adı',TbKitaplar.Kitapturu AS 'Kitap Türü',TbOkunanKitaplar.VerilisTarihi AS 'Veriliş Tarihi',TbOkunanKitaplar.BitisTarihi AS 'Bitiş Tarihi',TbOkunanKitaplar.TeslimTarihi AS 'Teslim Tarihi',TbOkunanKitaplar.HasarDurumu as 'Hasar Durumu' From TbKitaplar INNER JOIN TbOkunanKitaplar ON TbKitaplar.KitapAdi=TbOkunanKitaplar.KitapAdi AND TbKitaplar.YazarAdi=TbOkunanKitaplar.YazarAdi  INNER JOIN TbUyeler ON TbOkunanKitaplar.TcKimlikNo=TbUyeler.TcKimlikNo  WHERE (" + Ara + " LIKE '%" + TextBoxAra + "%' )";
          DataAdapter.SelectCommand = Komut;
          DataAdapter.Fill(DataTable);          
          DataGridView.DataSource = DataTable;
          Baglanti.Close();      
      }

    
      
      }


    }

