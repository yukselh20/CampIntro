using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        //Hesaplama işlemi her kredi türü için geçerlidir.
        //Ancak içerikleri faiz oranları vd farklıdır.
        //Interface yardımıyla bir şablon oluştururuz.
        //Bu interface classlar üzerinde kullanılıyorsa içerisindeki metodlar classlarda da kullanılmak zorundadır.
        //Interfaceler de iplemente edildiği classın referans numarasını tutabilir // Örnek1,2

        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKredisi(); //örnek1
            IKrediManager konutKrediManager = new KonutKrediManager();//örnek2
            IKrediManager tasitKrediManager = new TasitKrediManager();//örnek3 

            //her örnekler birer sayfa olarak düşün. Müşteri herhangi birini seçtiğinde otomatik olarak
            //BasvuruManager deki BasvuruYap metoduna gider Ve seçimine göre işlem yapılır.
            //Çünkğ biz BasvuruManager in içerisine IKrediManagerin referansını atadık.
            ILoggerService databaseLogger = new DatabaseLoggerService();
            ILoggerService fileLogger = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(tasitKrediManager, databaseLogger);
            basvuruManager.BasvuruYap(konutKrediManager,databaseLogger);
            basvuruManager.BasvuruYap(ihtiyacKrediManager,fileLogger);

            // sonradan esnaf eklendi
            basvuruManager.BasvuruYap(new EsnafKredisiManager(), fileLogger);

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,tasitKrediManager }; // Görevli müşteriye ugun krediyi seçti

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler); // Seçilen krediler müşteriye bilgi olarak iletildi




        }
    }
}
