using System;

namespace GenericsIntro
{
    class Program
    {
        
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();  // tip bağimli çalışır şu anda
            isimler.Add("Engin");
        }
    }
}
