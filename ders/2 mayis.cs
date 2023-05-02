using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {

           
           customer c = new customer() // proplar ile class kullanımı
           {
               Name = "İsim",
               soyad = "Soyisim",
               sehir = "Şehir"
           };
           Console.WriteLine(c.Name);
           Console.WriteLine(c.soyad);
           Console.WriteLine(c.sehir);


            // Formatlama örneği

            /* <- Kaldır
           while (true)
           {
               Console.WriteLine("[T] Telefon formatı \n[P] para formatı\n[D] tarih formatı");
               Console.Write("Seçiminizi Yapın > ");
               string secim = Console.ReadLine();
               string lower = secim.ToLower(); // Seçim stringini küçük harf yapar
               switch (lower)
               {
                   case "t":
                       Console.Clear();
                       Console.Write("Telefon Numarası girin > ");
                       double t = Convert.ToDouble(Console.ReadLine());
                       Console.WriteLine(String.Format("{0:#### ### ####}", t));
                       Console.WriteLine("Bir tuşa basarak devam edebilirsiniz.");
                       Console.ReadKey();
                       Console.Clear();
                       break;
                   case "p":
                       Console.Clear();
                       Console.Write("Para girin > ");
                       double p = Convert.ToDouble(Console.ReadLine());
                       Console.WriteLine(String.Format("{0:#,###.##}TL", p));
                       Console.WriteLine("Bir tuşa basarak devam edebilirsiniz.");
                       Console.ReadKey();
                       Console.Clear();
                       break;
                   case "d":
                       Console.Clear();
                       Console.WriteLine(String.Format("{0:d}", DateTime.Now));
                       Console.WriteLine(String.Format("{0:t}", DateTime.Now));
                       Console.WriteLine("Bir tuşa basarak devam edebilirsiniz.");
                       Console.ReadKey();
                       Console.Clear();
                       break;
                   default:
                       Console.Clear();
                       Console.WriteLine("Geçerli bir değer girin");
                       Console.WriteLine("Bir tuşa basarak devam edebilirsiniz.");
                       Console.ReadKey();
                       Console.Clear();
                       break;
               }
           }
            Kaldır -> */  

            MyClass myClass = new MyClass();
            myClass.firstname = "İsim"; 
            Console.WriteLine(myClass.firstname); // Mr's + İsim



            // Kullanıcı tarafından girilen string'in boş olup olmadığını ternary ile kontrol etme 
            Console.Write("İsminiz > ");
            string a = Console.ReadLine();
            string res = string.IsNullOrEmpty(a) ? "Boş değer giremezsin" : "Kaydedildi"; // string.IsNullOrEmpty(a) String'in boş olup olmadığını kontrol eder boş ise true dolu ise false döndürür
            Console.WriteLine(res);

            // String Kopyalama
            string b = Console.ReadLine();
            string x = string.Copy(b);
            Console.WriteLine(x);


            // string.Concat örneği
            //Kullanıcıdan alınan ürünlere rasgele id verir
            Random random = new Random();   
            List<string> list = new List<string>();

            for (int i = 0; i < 5; i++)
            {
                string ü = Console.ReadLine();
                list.Add(ü);
            }
            Console.WriteLine(new string('-',50));
            foreach (string i in list)
            {
                Console.WriteLine(string.Concat($"{random.Next(0,99999)} | {i}"));
                // string.Concat girilen adet kadar string'i birleştirir
            }



            string[] vs = { "Ankara", "Adana", "Antalya" };
            string[] vs2 = { "bolu", "balıkesit", "bursa" };

            vs2 = vs; // vs2 dizisini vs'ye eşitler
            vs[0] = "istanbul"; // vs dizisindeki 0'ıncı elemanı istanbul olarak değiştirir
            Console.WriteLine(vs2[0]); // Çıkış istanbul

            /*
             * üstteki işlemin aynısı 
             * 
                string vs1 = "ankara";
                string vs2 = "bolu";
                vs2 = vs1;
                vs1 = "istanbul";
                Console.WriteLine(vs2); // çıkış ankara
            */
        }

        class customer
        {
            public string Name { get; set; }
            public string soyad { get; set; }
            public string sehir { get; set; }
        }
        class MyClass
        {
            private string _firstname;
            public string firstname { 
                
                get
                {
                    return "Mr's "+_firstname; // girilen ismin başına Mr's ekler
                }
                
                set
                {
                    _firstname = value;
                }
                
            }
        }
    }
}
