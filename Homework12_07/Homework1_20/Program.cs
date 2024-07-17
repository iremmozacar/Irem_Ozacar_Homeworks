using System.Security.Principal;

namespace Homework1_20;

class Program
{
    static void Main(string[] args)
    {
        //20. 1'den 10'a kadar olan sayıların karelerini ekrana yazdıran bir program yazınız.



        for (int i = 1; i <= 10; i++)
        {

            int result = i * i;
            Console.WriteLine($"{i} sayısının karesi: {result}");
        }


    }
}
