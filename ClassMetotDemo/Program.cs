using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();

            musteri1.adi = "Esra";
            musteri1.soyadi = "Ünal";
            musteri1.bakiyesi = 256;

            Musteri musteri2 = new Musteri();

            musteri2.adi = "Ege";
            musteri2.soyadi = "Kara";
            musteri2.bakiyesi = 456;

            Musteri[] bilgiler = new Musteri[] { musteri1, musteri2 };
            foreach (Musteri musteri in bilgiler)
            {

                Console.WriteLine(musteri.adi);
                Console.WriteLine(musteri.soyadi);
                Console.WriteLine(musteri.bakiyesi);
                Console.WriteLine("------------------");
            }
            Console.WriteLine("-----------metot----------");
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriListele(musteri1);
            musteriManager.MusteriListele(musteri2);

        }
    }
}
