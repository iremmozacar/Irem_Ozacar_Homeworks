
namespace Homework2_3
{


  /* 3. Bir taban class oluşturun ve bu class'tan miras alan iki alt class yazın. Taban class'ta bir Greet metodu tanımlayın ve alt class'larda bu metodu geçersiz kılın. */

  public class baseClass
  {
    public string  Name { get; set; }
    public virtual void Greeting()
    {
      Console.WriteLine("Merhabalar efendim!");
    }
    

    public class Product : baseClass
    {

      public DateTime dateTime  { get; set; }
      public override void Greeting()
      {
        Console.WriteLine("Ürünlerimiz!");
      }
    }

    public class Category : baseClass
    {
      public DateTime DateTime { get; set; }

            public override void Greeting()
            {
                System.Console.WriteLine("Bilgisayar!");
            }
        }
  }


}