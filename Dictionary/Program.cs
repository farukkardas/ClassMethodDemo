using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            DicClass<int, string> sozluk = new DicClass<int, string>();
            sozluk.Add(1,"Faruk");
            sozluk.Add(2,"Kardaş");
            sozluk.Add(3,"Wiwy");

            
        }
    }

    


}
