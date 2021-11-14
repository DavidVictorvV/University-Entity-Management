using System;

namespace University_Entity_Management
{
    class Program
    {
        static void Main(string[] args)
        {
            var student1 = new Student(new BaseEntity())
                .SetName("David")
                .SetYear("2");

            var professor1 = new Professor(new BaseEntity())
              .SetName("Jhon")
              .SetSpec("Romana");

            var janitor = new AdditionalPersonnel(new BaseEntity())
              .SetName("Doe")
              .SetRole("Janitor");

            student1.Print();
            Console.WriteLine();
            professor1.Print();
            Console.WriteLine();
            janitor.Print();
            Console.WriteLine();
        }
    }
}
