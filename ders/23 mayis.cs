using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            float num1 = 1.4f;
            float num2 = 3.8f;

            Console.WriteLine(Math.Ceiling(num1)); //Ceiling sayı >= 1.1  ise 2'ye yuvarlar sayı tam sayı ise hiç bir şey yapmaz
            Console.WriteLine(Math.Round(num1)); // Round klasik matematik yuvarlaması 1.5 >= 2 | 1 
            Console.WriteLine("***********");
            Console.WriteLine(Math.Ceiling(num2));
            Console.WriteLine(Math.Round(num2));

            /*
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write($"{i} * {j} = {Math.BigMul(i, j)} "); //Math.BigMul(1,2) iki sayiyi çarpar long türünde değer döndürür
                }
                Console.WriteLine();
            }
           // Console.WriteLine($"2*3={Math.BigMul(2,3)}"); //6
           // Console.WriteLine($"2*4={Math.BigMul(2,4)}"); //8
            //Console.WriteLine($"2*5={Math.BigMul(2,5)}"); //10
            /*



            int num = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            float num3 = Convert.ToSingle(Console.ReadLine());
            double num4 = Convert.ToDouble(Console.ReadLine());
            decimal num5 = Convert.ToDecimal(Console.ReadLine()); ;
            long num6 = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine(Math.Abs(num)); // Math.Abs() negatif değeri pozitif yapar eğer pozitif'i de negatif yapar
            Console.WriteLine(Math.Abs(num2));
            Console.WriteLine(Math.Abs(num3));
            Console.WriteLine(Math.Abs(num4));
            Console.WriteLine(Math.Abs(num5));
            Console.WriteLine(Math.Abs(num6));

            int toplam = 0;
            for (int i = 0; i <= 5; i++)
            {
                toplam += i;
                int a = Math.Abs(i - 2) + 2 + Math.Abs(3 - i); 
                Console.WriteLine($"x = {i} sounç = {a}");
            }

            Console.WriteLine(toplam);


            /*
            StringDictionary x = new StringDictionary(); // using System.Collections.Specialized;
            x.Add("python", "programlama");
            x.Add("c#", "programlama");
            if (x.ContainsKey("c#")) // ContainsKey Dictionary'de aranan key varsa bool döndürür true | false
            {
                x.Remove("c#");
                Console.WriteLine("Silindi");
                return;
            }
            Console.WriteLine("yok");
            Console.Read();
            /*
            Dictionary<string, int> kelime = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
            kelime.Add("apple", 1);
            kelime.Add("banana", 2);
            kelime.Add("orange", 3);

            if (kelime.ContainsKey("orange"))
            {
                Console.WriteLine("Anahtar içeriyor");
                return;
            }
            Console.WriteLine("İçermiyor");
            */
        }
    }
}
