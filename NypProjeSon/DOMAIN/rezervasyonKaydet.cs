using System;

namespace otel_rezarvasyon_sistemi.DOMAIN
{
    public class Rezervasyon
    {
        public Rezervasyon(string kimlik,  string isim,string soyisim, int secilenoda, string giris, string cikis,string ucret)
        {
            this.kimlik = kimlik;
            this.isim = isim;
            this.soyisim = soyisim;
            this.secilenoda = secilenoda;
            this.giris = giris;
            this.cikis = cikis;
            this.ucret = ucret;
        }
        int ıd;
        string kimlik;
        string isim;
        string soyisim;
        int secilenoda;
        string cikis;
        string giris;
        string ucret;

        public string Kimlik { get { return kimlik; } set { kimlik = value; } }

        public string Isim { get { return isim; } set { isim = value; } }
        public string Soyisim { get { return soyisim; } set { soyisim = value; } }

        public string Ucret { get { return ucret; } set { ucret = value; } }
        public int Secilenoda { get { return secilenoda; } set { secilenoda = value; } }

        public int Id { get { return ıd; } set { ıd = value; } }
        public string Giris { get { return giris; } set { giris = value; } }
        public string Cıkıs { get { return cikis; } set { cikis = value; } }


    }
}
