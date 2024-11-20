using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Ödev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi, kalan, toplam = 0;
            sayi = int.Parse(Console.ReadLine());
            for (int i = sayi; i > 0; i = i / 10)
            {
                kalan = i % 10;
                toplam = toplam + kalan * kalan * kalan;
            }
            if (toplam == sayi)
            {
                Console.WriteLine(" Girilen sayı armstrong sayısıdır ");
            }
            else
            {
                Console.WriteLine(" Girilen sayı armstrong sayısı değildir ");
            }
            Console.Read();





            
        }
    }
}
