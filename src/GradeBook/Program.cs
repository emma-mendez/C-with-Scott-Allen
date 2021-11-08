using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {

            var numbers = new double [3];
            numbers[0] = 12.7;
            numbers[1] = 10.3;
            

           if (args.Length > 0)
           {
            Console.WriteLine($"Hello, {args[0]}!");
           }
           else {
               Console.WriteLine("Hello Emma Your ON Baby");
           }
        }
    }
}
