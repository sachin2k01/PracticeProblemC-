using System;

namespace LambdaExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Func<int, int> Square = x => x * x;
            int num = 2;
            int res = Square(num);
            Console.WriteLine("Result of square of number is "+res);
            Console.WriteLine("Enter a Number to check even or not");
            int num1 = int.Parse(Console.ReadLine());

            Func<int, bool> Even = e => e % 2 == 0;

            if (Even(num))
            {
                Console.WriteLine("Even number");
            }
            else
            {
                Console.WriteLine("Not a Even");
            }

            Func<int, int> sq = s => s * s;

            Console.WriteLine($"Squeare of a Enterd Number is {sq(num)}");


            Console.WriteLine("Enter 2 numbers to find sum");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Func<int, int, int> sum = (c, d) => a + b;
            int res1 = sum(a, b);
            Console.WriteLine("Sum of Numbers is" + res);

            //Func<int,int,int> square = (int c, int d) =>
            //{
                
            //    int a1;
            //    a = c + d;
            //    Console.WriteLine("Square of number is "+a);
            //    return a;
               
            //};

            //Console.WriteLine("Sum of Number " + square(5, 6));


        }
    }
}
