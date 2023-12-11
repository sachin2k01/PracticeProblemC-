using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    class EvenNumbers
    {
        static void Main(string[] args)
        {
            int[] num = { 2, 3, 5, 4, 7, 9, 11, 45, 23, 87 };

            Func<int[], int> even = (int[] arr) =>
            {
                foreach (int i in arr)
                {
                    if (i % 2 == 0)
                        return i;
                }
            }

        even(even);

            foreach (int j in even)
            {
                Console.WriteLine(j);
            }
        }
    }
}
