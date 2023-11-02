using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri eklendi : " + musteri.Adi + " " + musteri.Soyadi);
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri silindi : " + musteri.Adi + " " + musteri.Soyadi);
        }

        public void Güncelle(Musteri musteri)
        {
            Console.WriteLine("Müşteri güncellendi : " + musteri.Adi + " " + musteri.Soyadi);
        }
    }
}
