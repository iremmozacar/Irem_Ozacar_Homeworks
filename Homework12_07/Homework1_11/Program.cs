namespace Homework1_11;

class Program
{
    static void Main(string[] args)
    {
        //11.Bir dizi içindeki en küçük sayıyı bulan bir program yazınız.

        int[] array = { 1, 2, 3, 4, 5, 6 };
        int smallNumber = array[0];


        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < smallNumber)
            {
                smallNumber = array[i];
            }
        }


        Console.WriteLine($"En küçük dizi sayısı: {smallNumber}");
    }
}
