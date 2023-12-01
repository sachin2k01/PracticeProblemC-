using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProgram5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array Size");
            int size=int.Parse(Console.ReadLine());
            int[] arr=new int[size];
            Console.WriteLine("Enter Some Consective Number to check");
            for(int i = 0; i < size; i++)
            {
                arr[i]=int.Parse(Console.ReadLine());
            }

            int miss=Program.MissingNumber(arr);
            Console.WriteLine($"Missing Number in the Consecutive Number is: {miss} ");


        }
        public static int MissingNumber(int[] arr)
        {
            int n=arr.Length+1;

            int expected = 0;
            for(int i = 1;i<=n;i++)
            {
                expected=expected+i;
            }

            int actual = 0;
            foreach(int i in arr)
            {
                actual += i;
            }
           

            return expected - actual;
        }
    }
}
