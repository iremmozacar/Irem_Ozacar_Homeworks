namespace Homework2_8;

class Program
{
    static void Main(string[] args)
    {
        //8.Bir class oluşturun ve bu class'ta bir dizideki çift sayıların adedini bulan bir metod yazın.
        

        Console.Write("Dizi eleman sayısını girin:");
        int n=int.Parse(Console.ReadLine());

        int[] numbers=new int[n];
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"{i+1}. elemanı giriniz: ");
            numbers[i]=int.Parse(Console.ReadLine());
        }
        Find find=new Find();
        int total=find.FindTotal(numbers);
        Console.WriteLine("*********************");

        Console.WriteLine($" Çift sayıların adeti: {total}");

    }
}
