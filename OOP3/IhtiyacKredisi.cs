using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class IhtiyacKredisi : IKrediManager
    {
        public void BiSeyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("İhtiyaç kredisi ödeme planı hesaplandı.");
        }
    }
}
