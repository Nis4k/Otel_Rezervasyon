using MySql.Data.MySqlClient;
using System;

namespace NypProjeSon.DAL
{
    public class RezervasyonDAO
    {     
        public void AdminRezervasyon(string Isim, string Soyisim, string Kimlik, int Secilenoda, string Giris, string Cikis, string Ucret)
        {
            string sorgu = @"INSERT INTO adminRezervasyon (isim, soyisim, kimlik, secilenoda, giris, cıkıs, ucret) 
                             VALUES (@isim, @soyisim, @kimlik, @secilenoda, @giris, @cikis, @ucret)";
            try
            {
                using (MySqlCommand komut = new MySqlCommand(sorgu, new dbBaglanti().baglantiGetir()))
                {
                    // Parametreleri ekle
                    komut.Parameters.AddWithValue("@isim", Isim);
                    komut.Parameters.AddWithValue("@soyisim", Soyisim);
                    komut.Parameters.AddWithValue("@kimlik", Kimlik);
                    komut.Parameters.AddWithValue("@secilenoda", Secilenoda);
                    komut.Parameters.AddWithValue("@giris", Giris);
                    komut.Parameters.AddWithValue("@cikis", Cikis);
                    komut.Parameters.AddWithValue("@ucret", Ucret);
                    komut.ExecuteNonQuery();
                }               
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata: {ex.Message}");
            }
        }

     
    }
}
