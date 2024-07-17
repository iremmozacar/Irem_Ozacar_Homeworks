using System.Security.Cryptography;

namespace Homework1_15;

class Program
{
    static int Carp(int sayi1, int sayi2)
    {
        int sonuc = sayi1 * sayi2;
        return sonuc;
    }
    static void Main(string[] args)
    {
        Console.Write("Bir sayı girin:");
        int sayi1 = int.Parse(Console.ReadLine());
        Console.Write("Bir sayı girin:");
        int sayi2 = int.Parse(Console.ReadLine());


        int carpim = Carp(sayi1, sayi2);
        System.Console.WriteLine($"Sayılarınn çarpımının sonucu: {carpim}");
    }
}
