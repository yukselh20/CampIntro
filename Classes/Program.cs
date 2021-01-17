using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Kurs kurs1 = new Kurs();
            kurs1.KursunEgitmeni = "Engin Demiroğ";
            kurs1.KursAdi = "C";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursunEgitmeni = "Kerem Demiroğ";
            kurs2.KursAdi = "Java";
            kurs2.IzlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursunEgitmeni = "Hamza Yüksel";
            kurs3.KursAdi = "Pyhton";
            kurs3.IzlenmeOrani = 80;

            Kurs[] kurslar = new Kurs[] // içinde kurs nesnesini kullanan kurs arrayi tanımladık.
            {
            kurs1,kurs2,kurs3
            
            };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.IzlenmeOrani);
                Console.WriteLine(kurs1.KursunEgitmeni + " : " + kurs1.KursAdi);
            }
            string[] kurslar1 = new string[] // string arrayinde sadece string tutarsın
            {
            
            
            };

            
        }
    }

    class Kurs // Yazılım geliştirme kursunun tamamını bu yapı tutar.
    {
        public string KursAdi { get; set; }
        public string KursunEgitmeni { get; set; }
        public int IzlenmeOrani { get; set; }

    }
}
