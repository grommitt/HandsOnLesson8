using System;

namespace HandsOn
{
    class Program
    {
        static void Main(string[] args)
             //"Main method demonstrates the use of variables, operators, expressions, and statements"
        {
            var x = 3;
            var y = 4;
            int sum = x + y;
            Console.WriteLine("The sum of 3 and 4 is " + sum);
            Console.WriteLine("Are the values of sum and 7 equal? " + (sum == 7));
            var text1 = "Hello ";
            var text2 = "world!";
            var message = text1 + text2;
            Console.WriteLine("Message: " + message);
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }
}