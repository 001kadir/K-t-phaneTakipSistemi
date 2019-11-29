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
    class Emanet
    {

        SqlConnection Baglanti = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=KutuphaneDB;MultipleActiveResultSets=True;Integrated Security=true");   

        public void EmanetListele(DataGridView DataGridView)
       {
            SqlDataAdapter DataAdapter = new SqlDataAdapter();
            DataTable DataTable = new DataTable();
            if (Convert.ToBoolean(Baglanti.State) == false) { Baglanti.Open(); }

            DataAdapter.SelectCommand = new SqlCommand("SELECT TbUyeler.TcKimlikNo AS 'TC Kimlik No',TbUyeler.AdiSoyadi AS 'Adı Soyadı',TbKitaplar.KitapAdi AS 'Kitap Adı',TbKitaplar.YazarAdi AS 'Yazar Adı',TbKitaplar.Kitapturu AS 'Kitap Türü',TbEmanet.VerilisTarihi AS 'Veriliş Tarihi',TbEmanet.BitisTarihi AS 'Bitiş Tarihi',TbEmanet.TeslimTarihi AS 'Teslim Tarihi' From TbKitaplar INNER JOIN TbEmanet ON TbKitaplar.KitapAdi=TbEmanet.KitapAdi AND TbKitaplar.YazarAdi=TbEmanet.YazarAdi  INNER JOIN TbUyeler ON TbEmanet.TcKimlikNo=TbUyeler.TcKimlikNo ", Baglanti);
            DataAdapter.Fill(DataTable);
            DataGridView.DataSource = DataTable;        
        }
        
        public void EmanetVer(string TcKimlikNo, string KitapAdi, string YazarAdi, string VerilisTarihi, string BitisTarihi, int StokKontrol)
        {
            if (StokKontrol <= 0)
            {

                MessageBox.Show("Seçtiğiniz kitap kütüphanede bulunmamaktadır");
            }
               
            else

                {
                
                try
                {
                    if (Convert.ToBoolean(Baglanti.State) == false) { Baglanti.Open(); }
                    SqlCommand Komut = new SqlCommand();
                    Komut.Connection = Baglanti;
                    Komut.CommandText = ("INSERT INTO TbEmanet (TcKimlikNo,KitapAdi,YazarAdi,VerilisTarihi,BitisTarihi) values ('" + TcKimlikNo + "','" + KitapAdi + "','" + YazarAdi + "','" + VerilisTarihi + "','" + BitisTarihi + "')");
                    Komut.ExecuteNonQuery();
                   
                    SqlCommand Command = new SqlCommand("UPDATE TbKitaplar SET StokSayisi= StokSayisi-1 WHERE KitapAdi='" + KitapAdi + "' AND YazarAdi='" + YazarAdi + "'", Baglanti);
                    Command.ExecuteNonQuery();
                    Baglanti.Close();
                    MessageBox.Show("Emanet verme işlemi tamamlandı");
                }

                catch (SqlException Hata)
                {
                        if (Hata.ErrorCode == -2146232060)
                        MessageBox.Show("Kitap zaten bu üyede var");
                }
              }
            }

        public void EmanetAra(string TextBoxAra, DataGridView DataGridView, string Ara)

        {
            SqlDataAdapter DataAdapter = new SqlDataAdapter();
            DataTable DataTable = new DataTable();
            SqlCommand Komut = new SqlCommand();  
            
            if (TextBoxAra == "")
            {
                Komut.Connection = Baglanti;
                Komut.CommandText = "SELECT TbUyeler.TcKimlikNo AS 'TC Kimlik No',TbUyeler.AdiSoyadi AS 'Adı Soyadı',TbKitaplar.KitapAdi AS 'Kitap Adı',TbKitaplar.YazarAdi AS 'Yazar Adı',TbKitaplar.Kitapturu AS 'Kitap Türü',TbEmanet.VerilisTarihi AS 'Veriliş Tarihi',TbEmanet.BitisTarihi AS 'Bitiş Tarihi',TbEmanet.TeslimTarihi AS 'Teslim Tarihi' From TbKitaplar INNER JOIN TbEmanet ON TbKitaplar.KitapAdi=TbEmanet.KitapAdi AND TbKitaplar.YazarAdi=TbEmanet.YazarAdi  INNER JOIN TbUyeler ON TbEmanet.TcKimlikNo=TbUyeler.TcKimlikNo ";
                DataAdapter.SelectCommand = Komut;
                DataAdapter.Fill(DataTable);
                DataTable.Clear();
            }

            if (Convert.ToBoolean(Baglanti.State) == false) { Baglanti.Open(); }
            Komut.Connection = Baglanti;
            Komut.CommandText = " SELECT TbUyeler.TcKimlikNo AS 'TC Kimlik No',TbUyeler.AdiSoyadi AS 'Adı Soyadı',TbKitaplar.KitapAdi AS 'Kitap Adı',TbKitaplar.YazarAdi AS 'Yazar Adı',TbKitaplar.Kitapturu AS 'Kitap Türü',TbEmanet.VerilisTarihi AS 'Veriliş Tarihi',TbEmanet.BitisTarihi AS 'Bitiş Tarihi',TbEmanet.TeslimTarihi AS 'Teslim Tarihi' From TbKitaplar INNER JOIN TbEmanet ON TbKitaplar.KitapAdi=TbEmanet.KitapAdi AND TbKitaplar.YazarAdi=TbEmanet.YazarAdi  INNER JOIN TbUyeler ON TbEmanet.TcKimlikNo=TbUyeler.TcKimlikNo  WHERE (" + Ara + " LIKE '%" + TextBoxAra + "%' )";
            DataAdapter.SelectCommand = Komut;
            DataAdapter.Fill(DataTable);
            DataGridView.DataSource = DataTable;
            Baglanti.Close();        
        }

        public void EmanetAl(DataGridView DataGridView, string TcKimlikNo, string KitapAdi, string YazarAdi, string VerilisTarihi, string TeslimTarihi,string HasarDurumu)

        {
            if (Convert.ToBoolean(Baglanti.State) == false) { Baglanti.Open(); }
            SqlCommand UpdateCommandTbEmanet = new SqlCommand("UPDATE TbEmanet SET TeslimTarihi='" + TeslimTarihi + "',HasarDurumu='" + HasarDurumu + "'where TcKimlikNo='" + TcKimlikNo + "' AND YazarAdi='" + YazarAdi + "' AND VerilisTarihi='" + VerilisTarihi + "' AND KitapAdi='" + KitapAdi + "'", Baglanti);
            UpdateCommandTbEmanet.ExecuteNonQuery();

            SqlCommand InsertCommand = new SqlCommand("INSERT INTO TbOkunanKitaplar SELECT * FROM TbEmanet WHERE TcKimlikNo='"+TcKimlikNo+"' AND KitapAdi='"+KitapAdi+"' AND YazarAdi='"+YazarAdi+"' ANd VerilisTarihi='"+VerilisTarihi+"'",Baglanti);
            InsertCommand.ExecuteNonQuery();

            SqlCommand DeleteCommand = new SqlCommand("DELETE FROM TBEmanet WHERE TcKimlikNo='" + TcKimlikNo + "' AND KitapAdi='" + KitapAdi + "' AND YazarAdi='" + YazarAdi + "' ANd VerilisTarihi='" + VerilisTarihi + "'",Baglanti);
            DeleteCommand.ExecuteNonQuery();

            SqlCommand UpdateCommandTbKitaplar = new SqlCommand("UPDATE TbKitaplar SET StokSayisi= StokSayisi+1 where KitapAdi='" + KitapAdi + "' AND YazarAdi='" + YazarAdi + "'", Baglanti);
            UpdateCommandTbKitaplar.ExecuteNonQuery();
            Baglanti.Close();
            EmanetListele(DataGridView);
            MessageBox.Show("İşlem tamamlandı");   
        }

        public void SuresiBitenler(DataGridView DataGridView)
        {
            SqlDataAdapter DataAdapter = new SqlDataAdapter();
            DataTable DataTable = new DataTable();
            SqlCommand Komut = new SqlCommand();

            if (Convert.ToBoolean(Baglanti.State) == false) { Baglanti.Open(); }

            Komut.Connection = Baglanti;
            Komut.CommandText = " SELECT TbUyeler.TcKimlikNo AS 'TC Kimlik No',TbUyeler.AdiSoyadi AS 'Adı Soyadı',TbKitaplar.KitapAdi AS 'Kitap Adı',TbKitaplar.YazarAdi AS 'Yazar Adı',TbKitaplar.Kitapturu AS 'Kitap Türü',TbEmanet.VerilisTarihi AS 'Veriliş Tarihi',TbEmanet.BitisTarihi AS 'Bitiş Tarihi',TbEmanet.TeslimTarihi AS 'Teslim Tarihi' From TbKitaplar INNER JOIN TbEmanet ON TbKitaplar.KitapAdi=TbEmanet.KitapAdi AND TbKitaplar.YazarAdi=TbEmanet.YazarAdi  INNER JOIN TbUyeler ON TbEmanet.TcKimlikNo=TbUyeler.TcKimlikNo WHERE TbEmanet.BitisTarihi < DATEADD(day,-1,GETDATE()) ";//bugünün tarihinden bir çıkartıyoruz
            DataAdapter.SelectCommand = Komut;
            DataAdapter.Fill(DataTable);
            DataGridView.DataSource = DataTable;
            Baglanti.Close();               
        }

    }

}
