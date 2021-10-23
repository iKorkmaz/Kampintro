using System;

namespace odev
{
    class Program
    {
        static void Main(string[] args)
        {
            urun urun1 = new urun();
            urun1.UrunAdi = "Mouse";
            urun1.UrunOzellik = " Kablosuz";

            urun urun2 = new urun();
            urun2.UrunAdi = "Laptop";
            urun2.UrunOzellik = "Taşınabilir.";

            urun urun3 = new urun();
            urun3.UrunAdi = "Telefon";
            urun3.UrunOzellik = "Konuşabilir";

            urun[] urunler = new urun[] { urun1, urun2, urun3 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.UrunAdi+" "+urun.UrunOzellik);
            }

        }
    }
    class urun
    {
        public string UrunAdi { get; set; }
        public int UrunFiyatı { get; set; }
        public string UrunOzellik { get; set; }
    }
}