using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kareAlmaMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir Sayı Giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
           int KareDeger = KareAl(sayi);
            Console.WriteLine(KareDeger+"e Eşittir Haliyle ...");
            if (KareDeger > 25)
            {
                Console.WriteLine("25ten Büyüktür");

        
            }
            else if (KareDeger == 25)
            {
                Console.WriteLine("25 ' e Eşittir ");
            }
            else
            {
                Console.WriteLine("25ten Küçüktür ");
            }


            Console.ReadLine();
        }


  

        static int KareAl(int sayi)
        {
            sayi = sayi * sayi;
            return sayi;

            
        }

   
    }

}
