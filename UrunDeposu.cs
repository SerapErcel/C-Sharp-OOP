using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_ile_ürünDeposu
{
    class Urun
    {
        public int urunId { get; set; }
        public string urunAdi{ get; set; }
        public double  fiyat{ get; set; }
        public bool satistami { get; set; }
    }
    static class Depo
    {
        static Urun[] urunler;
        static Depo()
        {
            urunler = new Urun[5];
            urunler[0] = new Urun() { urunId = 1, urunAdi = "Oppo A9", fiyat = 1400, satistami = false };
            urunler[1] = new Urun() { urunId = 2, urunAdi = "Samsung A20", fiyat = 1500, satistami = true };
            urunler[2] = new Urun() { urunId = 3, urunAdi = "Huawei P30", fiyat = 1100, satistami = true };
            urunler[3] = new Urun() { urunId = 4, urunAdi = "iPhone 6", fiyat = 1800, satistami = false };
            urunler[4] = new Urun() { urunId = 5, urunAdi = "LG Q60", fiyat = 1200, satistami = true };
        }
        public static Urun[] UrunleriGetir()
        {
            return urunler;
        }
    }
    class UrunDeposu
    {
        static void Main(string[] args)
        {
            Urun[] urunler = Depo.UrunleriGetir();
            foreach (var urun in urunler)
            {
                Console.WriteLine("Urun Id: {0} adi: {1} fiyati: {2} satista mi? {3}", urun.urunId, urun.urunAdi, urun.fiyat, urun.satistami);
            }
            Console.Read();
        }
    }
}
