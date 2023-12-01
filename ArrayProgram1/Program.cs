using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProgram1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Array Size");
            int size=int.Parse(Console.ReadLine());
            int[] array=new int[size];
            ArrayOperation ap=new ArrayOperation();
            Boolean option = true;
            while(option)
            {
                Console.WriteLine("Enter 1 For Insertion");
                Console.WriteLine("Enter 2 For Display");
                Console.WriteLine("Enter 3 For Reverse an Array And Display");
                Console.WriteLine("Enter 0 for Exit");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        ap.Insertion(array, size);
                        break;
                    case 2:
                        Console.WriteLine("Array Elements Are");
                        ap.Display(array);
                        break;
                    case 3:
                        Console.WriteLine("Reversed Array");
                        ap.Reverse(array);
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        option = false;
                        break;
                }

            }

        }
    }
}
