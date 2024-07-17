using System.Globalization;

namespace Homework2_7
{

  //7. Bir class oluşturun ve bu class'ta bir dizideki sayıların ortalamasını bulan bir metod yazın.
  class Average
  {
    public double CalculateAverage(int[] numbers)
    {
      int sum = 0;
      foreach (int number in numbers)
      {
        sum += number;
      }
      return (double)sum / numbers.Length;

    }



  }
}
