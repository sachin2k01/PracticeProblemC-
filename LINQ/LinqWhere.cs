using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class LinqWhere
    {
        static void Main(string[] args)
        {
            int[] array = { 10, 20, 30, 40, 50, 60 };
            
            var grt30=array.Where(x => x > 30);
            Console.WriteLine("Using Method Syntax");

            foreach(var x in grt30)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine();

            Console.WriteLine("Using LINQ Syntax");
            var linqgrt30=(from num in array where num > 30 select num);

            foreach(var x in linqgrt30)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine();
        }

    }
}
