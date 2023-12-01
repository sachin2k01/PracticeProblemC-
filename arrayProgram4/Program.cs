using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayProgram4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Array Size");
            int size=int.Parse(Console.ReadLine());
            int[] array= new int[size];
            Console.WriteLine("Enter Numbers to an array");
            for(int i=0; i<size; i++)
            {
                array[i]= int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Duplicate ELement in the Array");
            for(int i=0;i< array.Length-1;i++)
            {
                for(int j=i+1;j<array.Length;j++)
                {
                    if (array[i] == array[j])
                    {
                        Console.WriteLine(array[i]);
                        break;
                    }
                }
            }
        }
    }
}
