namespace Homework1_14;

class Program
{
    static int Topla(int sayi1, int sayi2)
    {
        int sonuc = sayi1 + sayi2;
        return sonuc;
    }
    static void Main(string[] args)
    {
        //14.Kullanıcıdan alınan iki sayıyı toplayan bir metot yazınız.
        Console.WriteLine("Bir sayı giriniz: ");
        int sayi1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Bir sayı giriniz: ");
        int sayi2 = int.Parse(Console.ReadLine());


        int toplam = Topla(sayi1, sayi2);
        Console.WriteLine($"Toplam: {toplam}");



    }
}
