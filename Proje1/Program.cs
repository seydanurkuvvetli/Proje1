using System;

namespace Proje1
{
    class Program
    {
        static void Main(string[] args)
        {
            Musterii musteri1 = new Musterii();
            musteri1.AdSoyad = "Şeydanur Kuvvetli";
            musteri1.Cinsiyet = "Kız";
            musteri1.yas = 19;
            musteri1.DogumYili = 05082001;

            Musterii musteri2 = new Musterii();
            musteri2.AdSoyad = "SenaNur Kuvvetli";
            musteri2.Cinsiyet = "Kız";
            musteri2.yas = 25;
            musteri2.DogumYili = 21041995;

            Musterii musteri3 = new Musterii();
            musteri3.AdSoyad = "Ahmetcan Kuvvetli";
            musteri3.Cinsiyet = "Erkek";
            musteri3.yas = 24;
            musteri3.DogumYili = 12031996;


            MusteriiManager musteriManager = new MusteriiManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri3);
            musteriManager.Sil(musteri2);

            Musterii[] musteriler = new Musterii[] { musteri1, musteri2, musteri3 };
            musteriManager.Listele(musteriler);



        }
    }
}
    

