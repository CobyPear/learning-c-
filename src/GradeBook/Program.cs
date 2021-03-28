using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            // if (args.Length > 0) {
            //     System.Console.WriteLine($"Hello {args[0]}!");
            // } else {
            //     System.Console.WriteLine("Hello World!");
            // }

            var average = 0.0;

            List<double> grades = new List<double>{ 12.5, 20, 15.6, 8.5 };
            
            foreach (var number in grades) {
                average += number;
            }

            average = average / grades.Count;

            System.Console.WriteLine($"The average grade is {average}");
        }
    }
}
