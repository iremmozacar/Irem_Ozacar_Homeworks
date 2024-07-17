namespace Homework__;

class Program
{
    static void Main(string[] args)
    {
        // 9.Kullanıcıdan bir sayı alıp, bu sayının asal olup olmadığını kontrol eden bir program yazınız.
        Console.Write("Lütfen bir sayı gir: ");
        int number = int.Parse(Console.ReadLine());

        if (number <= 1)
        {
            Console.WriteLine($" {number} bir asal sayı değildir. ");
        }




        else
        {
            bool isPrime = true;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;

                }

                // else
                // {
                //     Console.WriteLine($"{number} bir asal sayıdır!!!");
                // }

            }
            Console.WriteLine(".........................");
            Console.WriteLine(isPrime ? $"{number} bir asal sayıdır." : $"{number} bir asal sayı değildir.");

        }
    }
}
