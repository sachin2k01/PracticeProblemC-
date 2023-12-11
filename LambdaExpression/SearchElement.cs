using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    class SearchElement
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an Array size");
            int size=int.Parse(Console.ReadLine());
            int[] ar=new int[size];
            Console.WriteLine("Enter an elment to insert");
            for(int i=0; i<size; i++)
            {
                ar[i]=int.Parse(Console.ReadLine());
            }

            Func<int[], int, bool> search = (int[] arr, int key) =>
            {
                foreach(int i in arr)
                {
                    if(i==key)
                        return true;
                }
                return false;

            };
            Console.WriteLine("Enter an element to search");
            int keys = int.Parse(Console.ReadLine());

            bool res = search(ar, keys);
            if(res)
            {
                Console.WriteLine("Key is Found");
            }
            else
            {
                Console.WriteLine("Not Found");
            }
        }
    }
}
