using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git1
{
    class Program
    {
        /*static void Main(string[] args)
        {
            Console.WriteLine("iveskite pirma skaiciu");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("iveskite antra skaiciu");
            int b = Convert.ToInt32(Console.ReadLine());
            
            suma(a, b);
            skirtumas(a, b);
            Sandauga(a, b);
            Dalmuo(a, b);
            Console.ReadKey();


        }
        static void suma(int num1, int num2)
        {
            Console.WriteLine("Skaiciu suma:");
            Console.WriteLine(num1 + num2);
        }
        static void skirtumas(int num1, int num2)
        {
            Console.WriteLine("Skaiciu skirtumas:");
            Console.WriteLine(num1 - num2);
        }
        static void Sandauga(int num1, int num2)
        {
            Console.WriteLine("Skaiciu sandauga:");
            Console.WriteLine(num1 * num2);
        }
        static void Dalmuo(int num1, int num2)
        {
            Console.WriteLine("Skaiciu dalmuo:");
            Console.WriteLine(num1 / num2);
        }*/
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite svori");
            float a = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("iveskite ugi metrais" +
                "");
            float b = Convert.ToSingle(Console.ReadLine());
            float c = KMI(a, b);
            string d = mase(c);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.ReadLine();


        }
        static float KMI(float svoris, float ugis)
        {
            
            return (svoris/ (ugis*ugis));
        }
        static string mase(float kmi)
        {
            if(kmi<15)
            {
                Console.WriteLine("bado dieta");
            }
            else if (15 <= kmi && kmi < 18.5)
            {
                Console.WriteLine("liesas zmogus");
            }
            return "";
        }
    }
}
