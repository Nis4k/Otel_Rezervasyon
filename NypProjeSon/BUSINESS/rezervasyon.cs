using System;
using NypProjeSon.DAL;

namespace NypProjeSon.BUSINESS
{
    public class Rezervasyon
    {
        internal void KaydetRezervasyon(string Isim, string Soyisim, string Kimlik, int SecilenOda, string Giris, string Cikis, string Ucret)
        {
            try
            {                
                new RezervasyonDAO().AdminRezervasyon(Isim, Soyisim, Kimlik, SecilenOda, Giris, Cikis, Ucret);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata: {ex.Message}");
            }
        }
    }
}
