namespace Homework1_18;

class Program
{
    static void Main(string[] args)
    {
        //19.Bir dizinin ortalamasını hesaplayan bir program yazınız.

        int[] array = new int[5];
        int average = 0;
        int total = 0;
        Console.WriteLine("Dizi elemanlarını giriniz:");

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
            total += array[i];

        }
        average = total / array.Length;
        Console.WriteLine($"Dizinin toplamı: {total}");
        Console.WriteLine($"Dizinin ortalaması: {average}");
    }
}
