namespace Homework1_4;

class Program
{
    static void Main(string[] args)
    {
        //3. 1'den 100'e kadar olan sayıları ekrana yazdıran bir program yazınız.


        for (int i = 2; i <= 100; i++)
        {
            if (i % 2 == 0)
                Console.WriteLine(i);
        }
    }
}
