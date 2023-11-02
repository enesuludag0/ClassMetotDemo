namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri()
            {
                Id = 1,
                Adi = "Enes",
                Soyadi = "Uludağ",
                Memleketi = "Kırıkkale"
            };

            Musteri musteri2 = new Musteri()
            {
                Id = 2,
                Adi = "Melih",
                Soyadi = "Özdemir",
                Memleketi = "Malatya"
            };

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            Console.WriteLine("----------Musteriler----------");

            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Adi + " " + musteri.Soyadi);
            }

            Console.WriteLine("------------------------------");

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Sil(musteri1);
            musteriManager.Sil(musteri2);

            musteri1.Adi = "Emre";
            musteri2.Soyadi = "Özdamar";
            musteriManager.Güncelle(musteri1);
            musteriManager.Güncelle(musteri2);
        }
    }
}