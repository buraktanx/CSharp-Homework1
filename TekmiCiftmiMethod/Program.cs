using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TekmiCiftmiMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    Console.WriteLine("Bir Sayı Giriniz");
            //    int sayi = Convert.ToInt32(Console.ReadLine());

            //    TekCıft(sayi);

            //    Console.ReadLine();

            //}


            //static int TekCıft(int sayi)
            //{

            //    if (sayi % 2==0)
            //    {
            //        Console.WriteLine("Sayınız Pozitiftir ");
            //    }

            //    else
            //    {
            //        Console.WriteLine("Sayınız Negatiftir");
            //    }
            //    return sayi;



            // 0 girilene kadar girilen değerleri ArrayListe atan ve sonunda bu listeyi büyükten küçüğe sıralayan ve listedeki en büyük en küçük ve ortalama değerleri bulan program

            ArrayList sayilar = new ArrayList();
            int toplam = 0;
            while (true)
            {
                Console.WriteLine("Bir Sayı Giriniz");
                int sayi = Convert.ToInt32(Console.ReadLine());

                if (sayi == 0)
                {
                    break;
                }
                sayilar.Add(sayi);
                toplam += sayi;
            }
            sayilar.Sort();
            sayilar.Reverse();
            Console.WriteLine("Girdiğiniz En Büyük Sayı = " + sayilar[0]);
            Console.WriteLine("Girdiniz En Küçük Sayı Değeri = " + sayilar[sayilar.Count-1]);
            Console.WriteLine("Girdiğiniz Sayıların Ortalama Değeri = " + toplam/sayilar.Count);
            Console.ReadLine();


        }
    }
}
