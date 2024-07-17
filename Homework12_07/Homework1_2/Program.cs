namespace Homework1_2;

class Program
{
    static void Main(string[] args)
    {
        //2.Kullanıcıdan iki sayı alıp, büyük olanı ekrana yazdıran bir program yazınız.


        Console.Write("Şimdi bir sayı girmen gereken yerdesin: ");
        int number1 = int.Parse(Console.ReadLine());
        Console.Write("Bir sayı daha girmelisin: ");
        int number2 = int.Parse(Console.ReadLine());

        if (number1 < number2)
        {
            Console.WriteLine($" {number1} büyük sayımız. ");
        }
        else if (number2 < number1)
        {
            Console.WriteLine($" {number1} büyük sayımız. ");
        }
        else
        {
            Console.WriteLine($"E sen bunları eşit girmişsin :) ");
        }

    }
}
