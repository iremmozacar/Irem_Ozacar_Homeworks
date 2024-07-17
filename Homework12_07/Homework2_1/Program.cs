namespace Homework2_1;

class Program
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Note { get; set; }
    }
    static void Main(string[] args)
    {
        /* 1. Bir class oluşturun ve bu class'ın içinde bir öğrencinin adını, yaşını ve notlarını tutan
        propertyler tanımlayın. Bu class'ı kullanarak bir öğrenci nesnesi oluşturun ve öğrenci bilgilerini ekrana yazdırın. */

        Student student = new Student();
        student.Name = "İrem Özacar";
        student.Age = 27;
        student.Note = "Işıkla kal!";

        Console.WriteLine($"{student.Name} '{student.Age}' : {student.Note}");
    }
}
