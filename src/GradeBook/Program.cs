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

           book.ShowStatistics();
        }
    }
}
