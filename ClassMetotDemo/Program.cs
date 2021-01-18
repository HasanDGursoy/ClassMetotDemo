using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriAd = "Hakan";
            musteri1.MusteriSoyAd = "Balta";
            musteri1.MusteriId = 123654;
            musteri1.MusteriAdress = "KemalPaşa Caddesi,Beşiktaş";
            musteri1.MusteriYas = 37;

            Musteri musteri2 = new Musteri();
            musteri2.MusteriAd = "Vlademir";
            musteri2.MusteriSoyAd = "Putin";
            musteri2.MusteriId = 4567654;
            musteri2.MusteriAdress = "Rusya,Budenowsk";
            musteri2.MusteriYas = 57;

            Musteri musteri3 = new Musteri();
            musteri3.MusteriAd = "Joe";
            musteri3.MusteriSoyAd = "Biden";
            musteri3.MusteriId = 74466554;
            musteri3.MusteriAdress = "Amerika,W.D";
            musteri3.MusteriYas = 78;

            MusteriManager musterilerinBilgileri = new MusteriManager();
            musterilerinBilgileri.MusteriAdresSorgulama(musteri1);
            musterilerinBilgileri.MusteriAdresSorgulama(musteri2);
            musterilerinBilgileri.MusteriAdresSorgulama(musteri3);

            Console.WriteLine("//////////////////////////////////////");

            musterilerinBilgileri.MusteriEkeleme(musteri1);
            musterilerinBilgileri.MusteriEkeleme(musteri2);
            musterilerinBilgileri.MusteriEkeleme(musteri3);

            Console.WriteLine("//////////////////////////////////////");

            musterilerinBilgileri.MusteriYasSorgulama(musteri1);
            musterilerinBilgileri.MusteriYasSorgulama(musteri2);
            musterilerinBilgileri.MusteriYasSorgulama(musteri3);

            Console.WriteLine("//////////////////////////////////////");

            musterilerinBilgileri.MusteriIdSifreleme(musteri1);
            musterilerinBilgileri.MusteriIdSifreleme(musteri2);
            musterilerinBilgileri.MusteriIdSifreleme(musteri3);

            Console.WriteLine("//////////////////////////////////////");

            musterilerinBilgileri.MusteriSilme(musteri1);
            Console.WriteLine("Putin İle Joe Biden'ı silmek Doğru olmaz.Üşendiğimden değil 2 code'a bakar.");






            Console.WriteLine("Hello World!");
        }
    }
}
