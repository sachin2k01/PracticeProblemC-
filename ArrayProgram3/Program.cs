using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProgram3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an Array Size");
            int size = int.Parse(Console.ReadLine());
            MaxMin mm = new MaxMin();
            int[] array = new int[size];
            Boolean Cont = true;
            while(Cont)
            {
                Console.WriteLine("Enter 1 for Inserting");
                Console.WriteLine("Enter 2 for find minimum element");
                Console.WriteLine("Enter 3 for find Maximum element");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        mm.Insert(array,size);
                        break;
                    case 2:
                        mm.minimum(array);
                        break;
                        case 3:
                        mm.maximum(array);
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        Cont = false;
                        break;     
                }

            }

        }
    }
}
