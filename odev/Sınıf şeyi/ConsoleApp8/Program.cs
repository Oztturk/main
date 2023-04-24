using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {

        struct MyStruct
        {
            public List<int> numara;
            public List<string> ad;
            public List<string> soyad;
            public List<double> not;
        }

        static MyStruct ogrenciler = new MyStruct();
        static void Main(string[] args)
        {
            
            ogrenciler.numara = new List<int>();
            ogrenciler.ad = new List<string>();
            ogrenciler.soyad = new List<string>();
            ogrenciler.not = new List<double>();

            Main:
            Console.WriteLine("[1] Öğrenci Ekle\n[2] Öğrenci sil\n[3] Tüm öğrencileri listele\n[4] Kayıtlı Öğrenci Sayısını göster\n[5] Genel not ortalamasını hesapla");
            Console.Write("İşleminizi Seçin > ");
            string islem = Console.ReadLine();
            if (islem == "1")
            {
                ekle();
                goto Main;
            }else if (islem == "2")
            {
                sil();
                goto Main;
            }
            else if(islem == "3")
            {
                listele();
                goto Main;
            }else if (islem == "4")
            {
                kayıtlıkullanıcısayısı();
                goto Main;
            }else if (islem == "5")
            {
                ortalama();
                goto Main;
            }
        }

        static void ekle()
        {
            ekleMain:
            Console.Clear();
            Console.WriteLine("Öğrenci bilgilerini giriniz:");
            Console.Write("Numara: ");

            int numara;
            int not;
            string numara2 = Console.ReadLine();
            if (string.IsNullOrEmpty(numara2) || !int.TryParse(numara2, out numara))
            {
                Console.WriteLine("Lütfen Sayısal değer girin");
                Thread.Sleep(1200);
                Console.Clear();
                goto ekleMain;
            }
            ogrenciler.numara.Add(numara);

            Console.Write("Ad: ");
            ogrenciler.ad.Add(Console.ReadLine());

            Console.Write("Soyad: ");
            ogrenciler.soyad.Add(Console.ReadLine());


            notMain:
            Console.Write("Not: ");
            string not2 = Console.ReadLine();

            if (string.IsNullOrEmpty(not2) || !int.TryParse(not2, out not))
            {
                Console.WriteLine("Lütfen Sayısal değer girin");
                Thread.Sleep(1200);
                Console.Clear();
                goto notMain;
            }
            else if(not > 100 || not < 0)
            {
                Console.WriteLine("Girdiğiniz Not 100'den büyük 0'dan küçük olamaz");
                Thread.Sleep(1200);
                Console.Clear();
                goto notMain;
            }

            ogrenciler.not.Add(not);

            Thread.Sleep(1200);
            Console.Clear();

        }
         
        static void listele()
        {
            Console.Clear();
            Console.WriteLine("Öğrenci bilgileri:");
            for (int i = 0; i < ogrenciler.numara.Count; i++)
            {
                Console.WriteLine("{0}. Öğrenci - Numara: {1}, Ad: {2}, Soyad: {3}, Not: {4}", i + 1, ogrenciler.numara[i], ogrenciler.ad[i], ogrenciler.soyad[i], ogrenciler.not[i]);
            }
            Console.WriteLine("Hehangi bir tuşa basarak geri döne bilirsiniz.");
            Console.ReadKey();
            Console.Clear();
        }

        static void sil()
        {
            silMain:
            Console.Clear();
            Console.WriteLine("Silmek istediğiniz öğrencinin numarasi > ");

            int n;
            string önum = Console.ReadLine();

            if (string.IsNullOrEmpty(önum) || !int.TryParse(önum, out n))
            {
                Console.WriteLine("Lütfen Sayısal değer girin");
                Thread.Sleep(1200);
                Console.Clear();
                goto silMain;
            }

            
            int i = ogrenciler.numara.IndexOf(n);
            if (i < 0)
            {
                Console.WriteLine("öğrenci bulunamadı");
                Thread.Sleep(1200);
                Console.Clear();
            }
            else
            {

                ogrenciler.ad.RemoveAt(i);
                ogrenciler.not.RemoveAt(i);
                ogrenciler.numara.RemoveAt(i);
                ogrenciler.soyad.RemoveAt(i);

                Console.WriteLine($"{n} numaralı öğrenci silindi");
                Thread.Sleep(1200);
                Console.Clear();
            }
        }
        static void kayıtlıkullanıcısayısı()
        {
            Console.Clear();
            if (ogrenciler.ad.Count == 0)
            {
                Console.WriteLine("Kayıtlı öğrenci yok");
                Console.WriteLine("Hehangi bir tuşa basarak geri döne bilirsiniz.");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine($"{ogrenciler.ad.Count} Öğrenci kayıtlı\n");
                Console.WriteLine("Hehangi bir tuşa basarak geri döne bilirsiniz.");
                Console.ReadKey();
                Console.Clear();
            }            
        }


        static void ortalama()
        {
            Console.Clear();
            double ort = 0;
            for (int i = 0; i < ogrenciler.not.Count; i++)
            {
                ort += ogrenciler.not[i];
            }
            ort /= ogrenciler.not.Count;
            Console.WriteLine("Sınıf'ın not ortalaması: {0}", ort);
            Console.WriteLine("Hehangi bir tuşa basarak geri döne bilirsiniz.");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
