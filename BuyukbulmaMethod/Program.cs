using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyukbulmaMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Birinci Sayıyı Giriniz");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkinci Sayıyı Giriniz");
            int sayi2=Convert.ToInt32(Console.ReadLine());
            BuyuKucuk(sayi1, sayi2);
            Console.ReadLine();
        }

        static int BuyuKucuk(int sayi1,int sayi2)
        {
            if (sayi1 > sayi2)
            {
                Console.WriteLine(sayi1 + " Değeri Daha Büyüktür ");
            }
            else if (sayi1 < sayi2)
            {
                Console.WriteLine(sayi2+" Değeri Daha Büyüktür");
            }
            else
            {
                Console.WriteLine("Eşittir");
            }
            return sayi1;
           
        }
    }
}
