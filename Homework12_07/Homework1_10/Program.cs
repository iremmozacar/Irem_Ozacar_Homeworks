namespace Homework1_10;

class Program
{
    static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 5, 6 };
        int bigNumber = array[0];

        for (int i = 0; i <= array.Length; i++)
        {
            if (array[i] > bigNumber)
            {
                bigNumber = array[i];
            }
        }
        Console.WriteLine($"En büyük dizi sayım {bigNumber}");

    }
}
