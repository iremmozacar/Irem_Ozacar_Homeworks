namespace Homework1_5;

class Program
{
    static void Main(string[] args)
    {
        //5. 1'den 100'e kadar olan tek sayıları ekrana yazdıran bir program yazınız.

        for (int i = 1; i < 100; i++)
        {
            if (i % 2 != 0)
                Console.WriteLine(i);

        }


    }
}
