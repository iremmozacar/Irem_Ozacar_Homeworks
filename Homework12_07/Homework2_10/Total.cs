using System.Reflection.Metadata.Ecma335;

namespace Homework2_10
{
    class Total
    {
        public int TotalNumbers()
        {
            int total=0;
             
             for (int i = 1; i <= 10; i++)
             {
                total+=i;
             }
            return total;
        }
         
         
    }
}