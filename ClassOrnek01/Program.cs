using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassOrnek01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            araba a1 = new araba();
            a1.ArabaModeli = "Opel";
            a1.ArabaRengi = "Siyah";
            a1.KapiSayisi = 4;
            a1.MotorCalıs();
            a1.KapıKitle();


            Console.WriteLine("Arabanın Modeli = " + a1.ArabaModeli);
            Console.WriteLine("Arabanın Rengi = " + a1.ArabaRengi);
            Console.WriteLine("Kapı Sayısı = " + a1.KapiSayisi);
            
            Console.ReadLine();






        }
    }
}
