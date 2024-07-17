using System.Reflection;

namespace Homework2_5;

class Program
{
    static void Main(string[] args)
    {
        //5.Bir class oluşturun ve bu class'ta bir sayının tek mi çift mi olduğunu kontrol eden bir metod yazın
        Control control = new Control();
        Console.Write("Bir sayı giriniz: ");
        int number = int.Parse(Console.ReadLine());


        Console.WriteLine($" Girdiğiniz sayı : {control.ControlNumber(number)}");


    }
}
