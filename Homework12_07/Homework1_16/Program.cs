using System.Threading.Channels;

namespace Homework1_16;

class Program
{

    static int Bol(int sayi1, int sayi2)
    {
        int sonuc = sayi1 / sayi2;
        return sonuc;
    }
    static void Main(string[] args)
    {
        Console.Write("Bir sayı gir lütfen: ");
        int sayi1 = int.Parse(Console.ReadLine());
        Console.Write("Bir sayı gir lütfen: ");
        int sayi2 = int.Parse(Console.ReadLine());

        int bolum = Bol(sayi1, sayi2);
        Console.WriteLine($"İki sayının bölümünün sonucu : {bolum}");


    }
}
