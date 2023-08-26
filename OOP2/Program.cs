using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri gercekMusteri = new GercekMusteri();
            gercekMusteri.Id = 1;
            gercekMusteri.MusteriNo = "1245";
            gercekMusteri.Adi = "ali";
            gercekMusteri.Soyadi = "veli";

            TuzelMusteri tuzelMusteri = new TuzelMusteri();
            tuzelMusteri.Id = 2;
            tuzelMusteri.MusteriNo = "454";
            tuzelMusteri.SirketAdi = "Deta";
            tuzelMusteri.VergiNo = "4154";


            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();
            musteri4.
        }
    }
}
