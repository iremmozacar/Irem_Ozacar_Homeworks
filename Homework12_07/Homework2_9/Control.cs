using System.Security.Cryptography.X509Certificates;

namespace Homework2_9
{
    class Control
    {
        //9.Bir class oluşturun ve bu class'ta bir sayının pozitif, negatif veya sıfır olup olmadığını kontrol eden bir metod yazın.

        public string ControlNumber (int number)
        {
           string result="";
           if (number > 0)
           {
               result = $"{number} : Pozitif sayıdır.";
           }
           else if (number < 0)
           {
                result = $"{number} : Negatif sayıdır.";

            }
            else
            {
                result = $"{number} : Sayı 0'dır. ";

            }
            return result;

        }
    }
}