namespace Homework2_8
{
    class Find
    {
        public int FindTotal(int[] numbers)
        {
            int total = 0;
            Console.WriteLine("*********************");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {

                    Console.WriteLine($"Çift sayılar: {numbers[i]}");
                }

                total = +numbers[i];
            }
            return total;
        }
    }
}