using System;

namespace ClassMetodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();
            musteri.Id = 1;
            musteri.Ad = "Hamza";
            musteri.Soyad = "Yüksel";
            musteri.TelefonNo = "01122334455";
            musteri.Adres = "İstanbul";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Didem";
            musteri2.Soyad = "Yüksel";
            musteri2.TelefonNo = "01178334455";
            musteri2.Adres = "New York";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Ad = "Furkan";
            musteri3.Soyad = "Yüksel";
            musteri3.TelefonNo = "01122339955";
            musteri3.Adres = "Ankara";

            Musteri[] musteriler = new Musteri[] {musteri ,musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkleme(musteri3);
            musteriManager.MusteriSilme(musteri2);
            musteriManager.MusterileriListele(musteriler);

        }
    }
}
