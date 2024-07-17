using System.Globalization;

namespace Homework2_6
{
  class FindMax
  {

    public static int FindMaximum(int[] numbers)
    {
      int max = numbers[0];

      for (int i = 0; i < numbers.Length; i++)
      {
        if (numbers[i] > max)
        {
          max = numbers[i];
        }
      }
      return max;
    }

  }
}