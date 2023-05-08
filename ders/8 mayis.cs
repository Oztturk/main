using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {






            string marşımız = "Korkma sönmez bu şafaklarda yüzen al sancak";

            Console.Write("Aranan > ");
            string aranan = Console.ReadLine();

            if (marşımız.Contains(aranan)) // --> Contains bir stringin içerisinde aranan harf kelime varmı konrol eder True / False döner
            {
                Console.WriteLine("Var");
                return;
            }
            Console.WriteLine("Yok");


            /* 
            Console.Write("Adınız > ");
            string ad = Console.ReadLine();

            Console.Write("bul > ");
            string ak = Console.ReadLine();


            

            //Console.WriteLine(ad.Contains(ak)); // --> true / false
            //Console.WriteLine("Ne".Contains("N")); // --> True / false

            if (ad.Contains(ak))
            {
                Console.WriteLine("Bulundu");
            }


            /* giriş örneği
            Console.WriteLine("Kayit Ol");
            Console.Write("Kullanıcı adı >");
            string kAdi = Console.ReadLine();
            SifrePrompt:
            Console.Write("sifre >");
            string Sifre1 = Console.ReadLine();
            Console.Write("sifre Tekrar >");
            string Sifre2 = Console.ReadLine();

            if (Sifre1.CompareTo(Sifre2) != 0) // --> compare to iki string'i karşılaştırır stringler aynı ise 0 değilse 1 | -1 döndürür
            {
                Console.Clear();

                Console.WriteLine("Sifre Yanlıs lütfen tekerar deneyin \n(E) Tekrar Dene \n(H) Çıkış");
                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
                if (consoleKeyInfo.Key == ConsoleKey.H)
                {
                    Environment.Exit(0);
                }
                
                Console.Clear();

                goto SifrePrompt;
            }

            Console.WriteLine("Kayit Basarili");
            Thread.Sleep(1200);
            Console.Clear();

            Login:
            Console.WriteLine("Giriş Yap");
            Console.Write("Kullanıcı adı >");
            string ad = Console.ReadLine();
        
            Console.Write("sifre >");
            string sif = Console.ReadLine();

            if (ad.CompareTo(kAdi) != 0 || sif.CompareTo(Sifre1) != 0)
            {
                Console.Clear();

                Console.WriteLine("Kullanıcı adı yada şifre yanlış lütfen tekerar deneyin \n(E) Tekrar Dene \n(H) Çıkış");
                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
                if (consoleKeyInfo.Key == ConsoleKey.H)
                {
                    Environment.Exit(0);
                }

                Console.Clear();

                goto Login;
            }
            else
            {

                Thread.Sleep(1200);
                Console.Clear();
                Console.WriteLine($"Merhaba {ad}");
            }


















            /*
            string a = "a";
            string b = "A";

            Console.WriteLine(string.Compare(a,b,true)); // --> true büyük küçük harf duyarlılığını kaldırır

            if (string.Compare(a,b,true) != 0)
            {
                Console.WriteLine("Esit Degil");
                return;
            }
            Console.WriteLine("Esit");
            /*
             * Şifre örneği

            Console.Write("Şifrenizi girin > ");
            string x = Console.ReadLine();
            Console.Write("Şifre tekrar > ");
            string y = Console.ReadLine();

            if (x.CompareTo(y) == 0)
            {
                Console.WriteLine("Şifre Doğru");
                return;
            }
            Console.WriteLine("Şifre yanlış.");
            /*
             *Compare to örneği
            string a = "sa";
            string b = "sa";

            Console.WriteLine((sbyte)a.CompareTo(b));

            if (a == b)
            {
                Console.WriteLine("Same");
                return;
            }
            Console.WriteLine("Not same");
            Console.ReadKey();
        */
        }
    }
}
