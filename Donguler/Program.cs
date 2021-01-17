using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] kurslar = new string[]
            {
                "yazılım geliştirme kampı",
                "java eğitimi",
                "fuck yeah",
                "ameriga is bringing some demoracy to himself"

            };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (string kurs in kurslar) // dizi temelli yapıları dödürmek için birebir.
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa sonu-footer");
        }
    }
}
