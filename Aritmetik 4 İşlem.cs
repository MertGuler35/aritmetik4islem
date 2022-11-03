using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2, toplam,carpım,bolum,fark;

            Console.WriteLine("****Aritmetik 4 İşlem***");

            Console.Write("1.sayıyı giriniz= ");
            sayi1= Convert.ToInt32(Console.ReadLine());

            Console.Write("2.sayıyı giriniz= ");
            sayi2 = Convert.ToInt32(Console.ReadLine());

            toplam = sayi1 + sayi2;
            carpım = sayi1 * sayi2;
            bolum = sayi1 / sayi2;
            fark = sayi1 - sayi2;


            Console.WriteLine("Toplam= " + toplam);
            Console.WriteLine("Çarpım= " + carpım);
            Console.WriteLine("Bölüm= " + bolum);
            Console.WriteLine("Fark= " + fark);
            Console.ReadLine();
        }
    }
}
