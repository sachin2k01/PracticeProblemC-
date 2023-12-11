using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    public class EvenNum
    {
        static void Main(string[] args)
        {
            int[] nums = { 3, 2, 5, 7, 98, 23, 87, 23,4 };

            Func<int[], int> even = (int[] arr) =>
            {
                int count = 0;
                foreach (int i in arr)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine($"Even number is: {i}");
                        count++;
                    }
                    
                }
                return count;
            };
            Console.WriteLine("Total Number of even Numbers in array: "+ even(nums));            
        }
    }
}
