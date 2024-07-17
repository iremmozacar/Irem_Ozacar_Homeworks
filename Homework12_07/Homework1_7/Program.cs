namespace Homework1_7;

class Program
{
    static void Main(string[] args)
    {
        //7.Kullanıcıdan 10 adet sayı alıp, bu sayıların toplamını ekrana yazdıran bir program yazınız.

        int[] numbers = new int[10];
        int total = 0;

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Lütfen {i + 1}. sayıyı gir: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < 10; i++)
        {
            total += numbers[i];
        }
        Console.WriteLine($" Girdiğin sayıların toplamı : {total}");
    }
}
