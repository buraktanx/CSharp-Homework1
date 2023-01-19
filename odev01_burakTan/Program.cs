using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace odev01_burakTan
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] dizi = new int[10];
            while (true)
            {
                try
                {
                    Console.WriteLine("1.Sayıyı Giriniz");
                    int baslangic = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("2. Sayıyı Giriniz");
                    int bitis = Convert.ToInt32(Console.ReadLine());
                    if (baslangic > bitis)
                    {
                        bitis = bitis + baslangic;
                        baslangic = bitis - baslangic;
                        bitis = bitis - baslangic;
                    }    
                    Sayilar.SayiUret(dizi, baslangic, bitis);
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Sayı Rakamlardan Oluşur !");
                    continue;
                }
               

            }
            Sayilar.DiziYazdir(dizi);
            Sayilar.EnBuyukDeger(dizi);
            Sayilar.EnKucukDeger(dizi);

            Console.ReadLine();
        }

        public class Sayilar
        {
            public static void SayiUret(int[] dizi, int baslangic, int bitis)
            {
                Random r = new Random();

                for (int i = 0; i < dizi.Length; i++)
                {
                    dizi[i] = r.Next(baslangic, bitis);
                }

            }
            public static void DiziYazdir(int[] dizi)
            {
                Console.WriteLine("Dizinin Elemanları :");
                for (int i = 0; i < dizi.Length; i++)
                {
                    Console.WriteLine($"{i + 1} . Eleman = " + dizi[i]);
                }

            }
            public static void EnBuyukDeger(int[] dizi)
            {
                int buyuk = 0;
                for(int i=0;i<dizi.Length;i++)
                {
                    Array.Sort(dizi);
                    Array.Reverse(dizi);
                    buyuk = dizi[0];

                }
                Console.WriteLine("Dizinin en büyük elemanı = " + buyuk);


            }
            public static void EnKucukDeger(int[]dizi)
            {
                int kucuk = 0;
                for(int i=0;i<dizi.Length;i++)
                {
                    Array.Sort(dizi);
                    kucuk = dizi[0];
                }
                Console.WriteLine("Dizinin en küçük elemanı = " + kucuk);
            }
           
        }


    }

}
