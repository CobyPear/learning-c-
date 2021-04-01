using System;
using System.Collections.Generic;

namespace GradeBook
{
        // internal is the default access modifier, but that won't let us use it in other projects. If we want to use it in our test project we need to make it a public class
        public class Book
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

        public void AddGrades(List<double> multipleGrades)
        {
            foreach (var grade in multipleGrades) {
                if (grade > 0 && grade < 100) {
                    grades.Add(grade);
                    Console.WriteLine($"{grade} added to gradebook {name}");
                } else {
                    Console.WriteLine($"{grade} is out of bounds and was not added");
                }
            }
        }

        public List<double> ShowGrades()
        {
            Console.WriteLine(string.Format($"The current grades in gradebook {0} are ({1})", name, string.Join(", ", grades)));
            
            return grades;
        }

        public Statistics GetStatistics() 
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.Low = double.MaxValue;
            result.High = double.MinValue;

            foreach (var grade in grades) {
                result.Low = Math.Min(grade, result.Low);
                result.High = Math.Max(grade, result.High);
                result.Average += grade;

            }
            result.Average /= grades.Count;

            return result;
        }
        // to add state we will use a field.
        // a field can be added in the class
        // implicit typing (var) does not work with fields.
    
        private List<double> grades;
        private string name;
    }
}