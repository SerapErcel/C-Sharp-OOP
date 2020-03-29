using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kitaplistesi
{
    class Kitap{
        public int kitapId { get; set; }
        public string kitapAdi { get; set; }
        public string yazar { get; set; }
        public int sayfasayisi { get; set; }
        public bool okundumu { get; set; }
    }
    static class Kitaplik{
        static List<Kitap> kitaplar;
        static Kitaplik()
        {
            kitaplar = new List<Kitap>{
                new Kitap(){kitapId=1, kitapAdi="İçimizdeki Şeytan", yazar="Sabahattin Ali", sayfasayisi=267, okundumu=false},
                new Kitap(){kitapId=2, kitapAdi="Suç ve Ceza", yazar="Dostoyevski", sayfasayisi=687, okundumu=true},
                new Kitap(){kitapId=3, kitapAdi="Puslu Kıtalar Atlası", yazar="İhsan Oktay Anar", sayfasayisi=238, okundumu=true},
                new Kitap(){kitapId=4, kitapAdi="Fareler ve İnsanlar", yazar="John Steinbeck", sayfasayisi=90, okundumu=true},
                new Kitap(){kitapId=5, kitapAdi="Simyacı", yazar="Poulo Coelho", sayfasayisi=184, okundumu=false},
                new Kitap(){kitapId=6, kitapAdi="İstanbul Hatırası", yazar="Ahmet Ümit", sayfasayisi=632, okundumu=true},
            };
        }
        public static List<Kitap> KitaplariGetir()
        {
            return kitaplar;
        }
        public static void KitapEkle(Kitap kitap)
        {
            kitaplar.Add(kitap);
        }
    }
    class liste_ile_Kitaplık
    {
        static void Main(string[] args)
        {
            Kitap k1 = new Kitap() { kitapId = 7, kitapAdi = "Olasılıksız", yazar = "Adam Fawer", sayfasayisi = 475, okundumu = true };
            Kitaplik.KitapEkle(k1);
            List<Kitap> kitaplar = Kitaplik.KitaplariGetir();
            foreach (var kitap in kitaplar)
            {
                Console.WriteLine("Kitap Id:{0} Adı:{1} Yazarı:{2} Sayfası:{3} Okunma:{4}",
                    kitap.kitapId, kitap.kitapAdi, kitap.yazar, kitap.sayfasayisi, kitap.okundumu);
            }
            Console.Read();
        }
    }
}
