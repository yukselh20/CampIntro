using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService) //Başvuru için istenen krediyi al
        {
            //Başvuran bilgilerini değerlendirme


            /*KonutKrediManager konutKrediManager = new KonutKrediManager();
            konutKrediManager.Hesapla();
            Hesaplama yapılır ama tümm başvurular konut kredisi üzerinden yapılmış olur */


            krediManager.Hesapla(); //krediManager girilen değer. Artık tüm kredi türleri için çalışmış olacak
            loggerService.Log(); //Hangi şekilde loglanmak isteniyorsa o şekilde interface sayesinde kolayca loglanacak.
                                 //Referansı tekrar atadık ve interfacin nimetini tekrar kullanmış olduk
        }


        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla(); //her kredi hesaplanacak
            }

        }
    }
}
