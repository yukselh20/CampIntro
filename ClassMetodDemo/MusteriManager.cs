using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetodDemo
{
    class MusteriManager
    {
        public void MusteriEkleme(Musteri musteri) 
        {
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " Sisteme eklendi.");
            Console.WriteLine("\n--------------------İŞLEM BAŞARILI--------------------");
        }

        public void MusteriSilme(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " Sistemden silindi.");
            Console.WriteLine("\n--------------------İŞLEM BAŞARILI--------------------");
        }

        public void MusterileriListele(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Müterinin Adı: "+ musteri.Ad + "\nMüşterinin Soyadı: "+ musteri.Soyad + "\nMüşteri Numarası: "+ musteri.Id);
                Console.WriteLine("\n--------------------İŞLEM BAŞARILI--------------------");
            }
            
        }

    }
}
