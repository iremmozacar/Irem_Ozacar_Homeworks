namespace Homework2_9;

class Program
{
    static void Main(string[] args)
    {
        //9.Bir class oluşturun ve bu class'ta bir sayının pozitif, negatif veya sıfır olup olmadığını kontrol eden bir metod yazın.


        Console.Write("Lütfen bir sayı giriniz:");
        int number = int.Parse(Console.ReadLine());

        Control control = new Control();
        string result = control.ControlNumber(number);
        Console.WriteLine(result);
    }
}
