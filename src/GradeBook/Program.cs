using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
           var book = new Book();
           book.AddGrade(10.2);
           book.AddGrade(15.8);
           book.AddGrade(5.0);

           var stats = book.GetStatistics();

            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The average grade is {stats.Average:N1}");
        }
    }
}
