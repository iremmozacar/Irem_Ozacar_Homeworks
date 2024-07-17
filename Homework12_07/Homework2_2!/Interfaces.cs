namespace Homework2_2
{
    public interface Irem
    {
        int CalculateArea();

        public class Interfaces : Irem
        {
            public int CalculateArea()
            {
                throw new NotImplementedException();
            }
        }

    }
}