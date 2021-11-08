﻿using System;
using System.Collections.Generic;
namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {

            var numbers = new [] {12.7, 10.3, 6.11 };
            var grades = new List<double>() {12.7, 10.3, 6.11 };
            grades.Add(56.1);

            var result = 0.0; 
            foreach (double number in grades)
            {
                 result += number;
            }
            result /= grades.Count;
            Console.WriteLine($"The averge grade is, {result:N1}");
            
           
        }
    }
}
