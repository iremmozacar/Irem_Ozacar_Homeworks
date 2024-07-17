namespace Homework1_1;

class Program
{
    static void Main(string[] args)
    {
        // 1.Kullanıcıdan bir sayı alıp, bu sayının çift mi tek mi olduğunu kontrol eden bir program yazınız.


        Console.Write("Gir bakalım bi sayı: ");
        int number = int.Parse(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine($"{number} çift bi sayı :) ");
        }
        else
        {
            Console.WriteLine($"{number} tek sayı :) ");
        }

    }
}
