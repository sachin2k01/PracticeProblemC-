using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    public class ListLambdaExpression
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 15, 3, 4, 7, 21, 12, 1, 6, 5};

            Console.WriteLine("List values: ");
            foreach (int i in list)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
            Console.WriteLine();

            var sq=list.Select(x=>x*x);
            Console.WriteLine("Square of each number in the list");
            foreach(int i in sq)
            {
                Console.Write(" " + i);
            }
             Console.WriteLine();



            //div by 3
            List<int> divby3 = list.FindAll(x => (x % 3 == 0));

            Console.WriteLine("Number which are divisible by 3 in the list");
            foreach(int i in divby3)
            {
                Console.Write(" " + i);
            }
            Console.WriteLine();



            //div byn 5
            Func<int,bool> divby5=x=> x%5==0;

            var div5=list.Where(divby5).ToList();
            Console.WriteLine("Divisible by 5 numbers");
            div5.ForEach(x=> Console.WriteLine(x));
        }
    }
}
