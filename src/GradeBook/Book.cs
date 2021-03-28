using System;
using System.Collections.Generic;

namespace GradeBook
{
        class Book
    {
        // constructor method must have same name as class and no return type. It is optional
        public Book(string name)
        {
            grades = new List<double>();
            // assign the name from the constructor to the field
            // name = name doesn't work, but we can use the this keyword
            this.name = name;
        }
        // public is an access modifier. It means code outside of this class has access to this method.
        // Fields can also have access modifiers
        public void AddGrade(double grade) 
        {
            // validation
            if (grade > 0 && grade < 100) {
                grades.Add(grade);
                Console.WriteLine("Grade added successfully");
            }
        }

        public void ShowStats() 
        {
            var average = 0.0;
            var lowGrade = double.MaxValue;
            var highGrade = double.MinValue;

            foreach (var grade in grades) {
                lowGrade = Math.Min(grade, lowGrade);
                highGrade = Math.Max(grade, highGrade);
                average += grade;

            }
            average /= grades.Count;


            Console.WriteLine($"The highest grade is {highGrade}");
            Console.WriteLine($"The average grade is {average:N1}");
            Console.WriteLine($"The lowest grade is {lowGrade}");
        }
        // to add state we will use a field.
        // a field can be added in the class
        // implicit typing (var) does not work with fields.
        private List<double> grades;
        private string name;
    }
}