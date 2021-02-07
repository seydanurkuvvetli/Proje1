using System;
using System.Collections.Generic;
using System.Text;

namespace Proje1
{
    class MusteriiManager
    {
        public void Ekle(Musterii musteri)
        {
            Console.WriteLine("müşterinin Adı Soyadı:" + musteri.AdSoyad + " " + "müşterinin cinsiyeti:" + musteri.Cinsiyet + " " + "müşterinin yaşı:" + musteri.yas + " " + "müşterinin doğum yılı:" + musteri.DogumYili + " " + "müşteri eklendi"); ;
        }
        public void Sil(Musterii musteri)
        {
            Console.WriteLine(musteri.AdSoyad + " " + musteri.Cinsiyet + " " + musteri.yas + " " + musteri.DogumYili + " " + "müşteri silindi");
        }
        public void Listele(Musterii[] musteriler)
        {
            foreach (Musterii musteri in musteriler)
            {


                Console.WriteLine(musteri.AdSoyad + musteri.Cinsiyet + musteri.yas + musteri.DogumYili);
            }
        }

    }
}

