using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    class FIndMax
    {
        static void Main(string[] args)
        {
            int[] numbers = { 17, 25, 12, 38, 19, 42,17,12,19 };

            Func<int[], int> findmax = (int[] arr) =>
            {
                int max = arr[0];
                foreach (int i in numbers)
                {
                    if (i > max)
                    {
                        max = i;
                    }
                }
                //Console.WriteLine("Maximum element in array: "+max);
                return max;

            };

            int res=findmax(numbers);
            Console.WriteLine("Maximum value :" + res);
        }
    }
}
