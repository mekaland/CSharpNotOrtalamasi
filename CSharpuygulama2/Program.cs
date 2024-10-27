using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpuygulama2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ogrenciAd = string.Empty;
            string ogrenciSoyadi = string.Empty;
            decimal ders1 = 0;
            decimal ders2 = 0;
            int ortalama = 0;

            Console.WriteLine("Merhaba  Ortalamasını  hesaplamak istediğiniz öğrencinin  bilgilerini giriniz");

            Console.WriteLine("Ad : ");
            ogrenciAd = Console.ReadLine();


            Console.WriteLine("Soyad : ");
            ogrenciSoyadi = Console.ReadLine();

            Console.WriteLine("Not 1 : ");
            ders1 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Not 2 : ");
            ders2 = decimal.Parse(Console.ReadLine());

            Ogrenci ogr = new Ogrenci();
            ogr.OgrenciPuanHesapla(ogrenciAd,ogrenciSoyadi, ders1, ders2);


            Console.ReadLine();



        }
    }
}
