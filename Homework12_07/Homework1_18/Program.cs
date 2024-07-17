namespace Homework1_17;

class Program
{
    static void Main(string[] args)
    {
        //18.Bir sayının pozitif mi negatif mi olduğunu kontrol eden bir program yazınız.

        Console.Write("Bir sayı girmen gereken yerdesin: ");
        int number = Convert.ToInt32(Console.ReadLine());


        if (number > 0)
        {
            Console.WriteLine($"{number} bir pozitif sayıdır!");
        }
        else if (number < 0)
        {
            Console.WriteLine($"{number} bir negatif sayıdır!!!");
        }
        else
        {
            Console.WriteLine("Sayı 0'dır.");
        }
    }
}
