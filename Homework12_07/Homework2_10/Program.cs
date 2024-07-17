namespace Homework2_10;

class Program
{
    static void Main(string[] args)
    {
        //Bir class oluşturun ve bu class'ta 1'den 10'a kadar olan sayıların toplamını bulan bir metod
        //yazın.

        Total total = new Total();
        int result = total.TotalNumbers();
        Console.WriteLine($"1'den 10'a kadar sayıların toplamı: {result}");


    }
}
