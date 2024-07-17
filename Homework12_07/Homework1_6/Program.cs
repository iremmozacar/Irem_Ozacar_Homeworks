namespace Homework1_6;

class Program
{
    static void Main(string[] args)
    {
        //6.Kullanıcıdan bir sayı alıp, bu sayının faktöriyelini hesaplayan bir program yazınız.

        Console.WriteLine($"Faktoriyeli hesaplanacak sayıyı gir lütfen: ");
        int number = int.Parse(Console.ReadLine());
        int factorial = 1;

        for (int i = 1; i < number; i++)
        {
            factorial *= i;
        }
        Console.WriteLine($" {number} sayısının faktoriyeli {factorial} ");
    }
}
