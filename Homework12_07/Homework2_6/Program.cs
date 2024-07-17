namespace Homework2_6;

class Program
{
    static void Main(string[] args)
    {
        //6. Bir class oluşturun ve bu class'ta bir dizideki en büyük sayıyı bulan bir metod yazın.

        FindMax findMax = new FindMax();
        Console.Write("Dizinin kaç elemanlı olacağını giriniz:");
        int n = int.Parse(Console.ReadLine());
        System.Console.WriteLine("*****************************************");

        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Lütfen {i + 1} elemanı giriniz: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }
        int maxNumber = FindMax.FindMaximum(numbers);
        Console.WriteLine($"En büyük dizi elemanı: {maxNumber}!");



    }
}
