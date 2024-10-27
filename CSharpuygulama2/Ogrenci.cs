using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpuygulama2
{
    internal class Ogrenci
    {
        public void OgrenciPuanHesapla(string ogrenciAd, string ogrenciSoyadi, decimal ders1, decimal ders2 )
        {
            Console.WriteLine("Öğrenci bilgileri aşağıdaki gibidir.");
            Console.WriteLine("ad soyad:  {0} {1}",ogrenciAd, ogrenciSoyadi);
            decimal ortalama = (ders1+ ders2 ) / 2;
            if (ortalama < 50)
            {
                Console.WriteLine("Ortalama değeriniz : {0} - Kaldınız", ortalama);

            }
            else 
            {
                Console.WriteLine("Ortalama değeriniz : {0} -  Geçtiniz", ortalama);
            }

        }
    }
}
