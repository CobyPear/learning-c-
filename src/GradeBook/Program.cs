using System;
using System.Collections.Generic;

// putting classes inside of a namespace will protect us from writing classes that overlap with classes in the global namespace
// namespaces can have dots like GradeBook.Math
namespace GradeBook
{
    class Program
    {
        // what does static mean?
        // the opposite of static is an instance method or an instance field.
        // Static members are not associated with an object instance, instead they are associated with the type in which they are created
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            // if (args.Length > 0) {
            //     Console.WriteLine($"Hello {args[0]}!");
            // } else {
            //     Console.WriteLine("Hello World!");
            // }
            // var uses implicit typing based on what is assigned
            var average = 0.0;
            // or double average;

            // initialize a list

            // var grades = new List<double> works too.

            List<double> grades = new List<double>() { 12.5, 20, 15.6, 8.5 };
            grades.Add(14.9);

            // foreach loop
            foreach (var number in grades)
            {
                average += number;
            }

            average /= grades.Count;

            // the :N1 is a formatting syntax. There are many available for all types of data including dates
            System.Console.WriteLine($"The average grade is {average:N1}");




            // =========================================================
            // classes
            // one class per file in C#
            // make Book.cs file
            // when making a class, think about the state or data it holds, and the methods or behavior, how it acts on that state.

            Book book = new Book("My Gradebook");

            // try to picture the method before writing it. how will it be used?
            book.AddGrade(89.1);
            book.AddGrade(90.1);
            book.AddGrade(63.8);
            book.AddGrade(75.2);
            book.AddGrade(86.8);
            book.AddGrade(58.1);

            var stats = book.GetStatistics();
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The average grade is {stats.Average:N1}");
            Console.WriteLine($"The lowest grade is {stats.Low}");

            book.ShowGrades();
        }
    }


}
