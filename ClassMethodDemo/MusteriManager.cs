using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi : "+musteri.Adi);
        }

        public void Delete(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi : "+musteri.Adi);
        }
        public void Update(Musteri musteri)
        {
            Console.WriteLine("Müşteri Güncellendi : "+musteri.Adi);
        }
        public void GetAllMusteri(Musteri[] musteriler)
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine("Müşteri Adı : "+musteri.Adi+"\nMüşteri Soyadı : "+musteri.Soyadi+"\nMüşteri Telefon : "+musteri.Telefon);
                Console.WriteLine("-----  -----  -----  -----  -----");
            }
        }
    }
}
