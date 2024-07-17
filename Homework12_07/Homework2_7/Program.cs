using System.Globalization;

namespace Homework2_7;

class Program
{
    static void Main(string[] args)
    {
        //7.Bir class oluşturun ve bu class'ta bir dizideki sayıların ortalamasını bulan bir metod yazın.

        Console.Write("Dizi eleman sayısını giriniz: ");
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($" {i + 1}. elemanı giriniz:");
            numbers[i] = int.Parse(Console.ReadLine());



        }
        Average avarage = new Average();
        double averageNumber = avarage.CalculateAverage(numbers);
        System.Console.WriteLine("**********************************");
        Console.WriteLine($" Dizideki sayıların ortalaması: {averageNumber}");
    }
}
