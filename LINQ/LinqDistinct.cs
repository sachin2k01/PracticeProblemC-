using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class LinqDistinct
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 1, 6, 4, 8, 1 };

            var methodsyn=arr.Distinct();

            var querysyn=(from dis in arr select dis).Distinct();

            Console.WriteLine("Array ELements are: ");
            foreach(var i in arr)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();


            Console.WriteLine("Using Query syntax to find disctinct value");
            foreach ( var disq in querysyn )
            {
                Console.Write(disq+" ");
            }
            Console.WriteLine();

            Console.WriteLine("Using Method Syntax to find Distinct values");
            foreach( var dism in methodsyn )
            {
                Console.Write(dism+" ");
            }
            Console.WriteLine();    

        }
    }
}
