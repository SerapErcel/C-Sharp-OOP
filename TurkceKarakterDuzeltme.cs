using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karakterdüzeltme
{
    static class Yardimci
    {
        public static string karakterduzelt(string str)
        {
            return str
                .Replace("Ç", "C")
                .Replace("Ğ", "G")
                .Replace("İ", "I")
                .Replace("Ö", "O")
                .Replace("Ş", "S")
                .Replace("Ü", "U")
                .Replace("Ç", "C")
                .Replace("ç", "c")
                .Replace("ğ", "g")
                .Replace("ı", "i")
                .Replace("ö", "o")
                .Replace("ş", "s")
                .Replace("ü", "u");
        }
    }
    class TurkceKarakterDuzeltme
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Turkce karakterlerden arindirmak istediginiz metni giriniz.");
            string str = Console.ReadLine();
            str = Yardimci.karakterduzelt(str);
            Console.WriteLine("Duzenlenmis metniniz: {0}", str);
            Console.Read();
        }
    }
}
