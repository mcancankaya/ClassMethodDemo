using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id =1;
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.Telefon = "01234567890";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "Mert";
            musteri2.Soyadi = "YMG";
            musteri2.Telefon = "01234567890";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Adi = "Can";
            musteri3.Soyadi = "YMG";
            musteri3.Telefon = "01234567890";

            Musteri[] musteriler = {musteri1,musteri2,musteri3 };

            MusteriManager manager = new MusteriManager();
            manager.Add(musteri1);
            manager.Delete(musteri2);
            manager.Update(musteri3);
            Console.WriteLine("----- Müşteri Listesi -----");
            manager.GetAllMusteri(musteriler);
        }
    }
}
