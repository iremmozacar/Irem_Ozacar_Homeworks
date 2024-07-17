namespace Homework1_9;

class Program
{
    static void Main(string[] args)
    {
        // 8.Bir dizinin elemanlarını ters çeviren bir program yazınız.

        int[] numbers = new int[5];

        for (int i = 0; i < 5; i++)
        {

            Console.Write($"Lütfen {i + 1}. elemanı girin: ");
            numbers[i] = int.Parse(Console.ReadLine());

        }

        Console.WriteLine($"{numbers[4]},{numbers[3]},{numbers[2]},{numbers[1]},{numbers[0]}");

    }
}
