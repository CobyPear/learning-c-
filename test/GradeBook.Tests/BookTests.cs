using System;
using Xunit;
using System.Collections.Generic;

namespace GradeBook.Tests
{
    public class BookTests
    {
        // this is an attribute
        // it's a piece of data attached to the method that follows it
        // it's like a decoration that we hang onto a method. for instance all the tests in the class may have the [Fact] attribute, but the other methods aren't tests so they don't get the attribute
        // [Fact]
        // public void Test1()
        // {
        //     // arrange
        //     int x = 2;
        //     int y = 4;
        //     int expected = 8;

        //     // act
        //     int actual = x * y;

        //     // assert
        //     Assert.Equal(expected, actual);
        // }

        [Fact]
        public void Test1()
        {
            // arrange
            var book = new Book("Test Book");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);

            // act
            var result = book.GetStatistics();

            // assert
            // the first argument is actual, second is expected, third is how many decimal places to read out to, in this case we want 1
            Assert.Equal(85.6, result.Average, 1);
            Assert.Equal(90.5, result.High);
            Assert.Equal(77.3, result.Low);
            
        }
        // public void Test1()
        // {
        //     // arrange
        //     var book = new Book("Test Book");
        //     List<double> grades = new List<double>() { 50.7, 90.2, -3.4, 100.1, 99, 14, 85 };

        //     List<double> expected = new List<double>() { 50.7, 90.2, 99, 14, 85 };

        //     // act
        //     book.AddGrades(grades);

        //     // assert
        //     Assert.Equal(book.ShowGrades(), expected);
            
        // }
    }
}
