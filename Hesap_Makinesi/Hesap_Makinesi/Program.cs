using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hesap_Makinesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            bool kontrol = true;

            do
            {

                double sayi1;
                double sayi2;


                Console.WriteLine("*********************************");
                Console.WriteLine("hangi işlemi yapmak istiyorsun?");
                Console.WriteLine("1- toplama");
                Console.WriteLine("2- çıkarma");
                Console.WriteLine("3- çarpma");
                Console.WriteLine("4- bölme");
                Console.WriteLine("başka bir tuş çıkış demektir:)");
                Console.WriteLine("*********************************");

                string secim = Console.ReadLine();

                if (secim == "1")
                {
                    Console.WriteLine("1.sayıyı gir");
                    sayi1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("2.sayıyı gir");
                    sayi2 = double.Parse(Console.ReadLine());



                    Console.WriteLine(("sonucunuz: ") + (sayi1 + sayi2));


                }
                else if (secim == "2")
                {

                    Console.WriteLine("1.sayıyı gir");
                    sayi1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("2.sayıyı gir");
                    sayi2 = double.Parse(Console.ReadLine());

                    Console.WriteLine(("sonucunuz: ") + (sayi1 - sayi2));

                }
                else if (secim == "3")
                {
                    Console.WriteLine("1.sayıyı gir");
                    sayi1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("2.sayıyı gir");
                    sayi2 = double.Parse(Console.ReadLine());

                    Console.WriteLine(("sonucunuz: ") + (sayi1 * sayi2));

                }
                else if (secim == "4")
                {

                    Console.WriteLine("1.sayıyı gir");
                    sayi1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("2.sayıyı gir");
                    sayi2 = double.Parse(Console.ReadLine());

                    Console.WriteLine(("sonucunuz: ") + (sayi1 / sayi2));



                }
                else
                {

                    kontrol = false;
                    Console.WriteLine("çıkış yapılıyor");


                }




            } while (kontrol);

            Console.Read();

        }
    }
}
