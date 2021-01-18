using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {

        public void MusteriEkeleme(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAd+musteri.MusteriSoyAd+" : Adlı Müşteri Eklendi");
        }

        public void MusteriSilme(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAd+musteri.MusteriSoyAd+" : Adlı Müşteri Silindi");
        }

        public void MusteriIdSifreleme(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriId+"  : Numaralı ID Tekrar Şifrelendi");
        }

        public void MusteriAdresSorgulama(Musteri musteri)
        {
            Console.WriteLine("Müşterinin Adresi : "+musteri.MusteriAdress);
        }
        public void MusteriYasSorgulama(Musteri musteri)
        {
            Console.WriteLine("Müşterinin Yaşı : "+musteri.MusteriYas);
        }
    }

}
