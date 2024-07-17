namespace Homework2_4;

class Program
{
    static void Main(string[] args)
    {
        //4. Bir class oluşturun ve bu class'ta bir diziyi parametre olarak alan ve dizinin elemanlarını ekrana yazdıran bir metod tanımlayın

        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        Array arrayPrint = new Array();
        arrayPrint.ArrayNumbers(array);
    }
}
