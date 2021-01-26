using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{

    //Kurulan sisteme sonradan eklendi ama sistem bozulmadı. SOLID
    class EsnafKredisiManager : IKrediManager
    {
        public void BiSeyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Esnaf Kredisi Hesaplandı.");
        }
    }
}
