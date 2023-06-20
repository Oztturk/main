using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(string.Format("{0,-7} | {1,-9} | {2,-9}","id","ad","bolum"));
            ogrenci[] ogrencis = new ogrenci[]
            {
                new ogrenci{Id = 1,isim= "ahmet",bölüm = "İşletme"}
            };

            foreach (var item in ogrencis)
            {
                Console.WriteLine(string.Format("{0,-7} | {1,-9} | {2,-9}", item.Id, item.isim, item.bölüm));
            }



            Console.WriteLine("\n\n\n\n");

            Console.WriteLine(string.Format("{0,-7} | {1,-9} | {2,-9}", "id", "ad", "Sehir"));

            Musteri[] musteris = new Musteri[]
            {
                new Musteri{Id = 2,isim= "arda", sehir = "Ankara"}
            };

            foreach (var item in musteris)
            {
                Console.WriteLine(string.Format("{0,-7} | {1,-9} | {2,-9}", item.Id, item.isim, item.sehir));
            }
            Console.ReadKey();
        }
    }

    class database
    {
        public virtual void ekle()
        {
            Console.WriteLine("Virtual otomatik ekleme yeri");
        }
    }

    class sqlserver: database
    {
        public override void ekle()
        {
            base.ekle();
            Console.WriteLine("bu alan sql db alanıdır");
        }
    }
    public class Vatandas
    {
        public int Id { get; set; }
        public string isim { get; set; }
    }

    public class ogrenci : Vatandas
    {
        public string bölüm { get; set; }
    }

    public class Musteri : Vatandas
    {
        public string sehir { get; set; }
    }

}
