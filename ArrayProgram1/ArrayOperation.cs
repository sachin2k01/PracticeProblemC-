using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProgram1
{
    internal class ArrayOperation
    {
        public void Insertion(int[] array,int size)
        {
            Console.WriteLine("Enter an element to insert");
            for (int i = 0; i < size; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
        }

        public void Display(int[] array)
        {
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
        }

        public void Reverse(int[] array)
        {
            int[] RevArray=new int[array.Length];
            int index=array.Length-1;
            foreach(int i in array)
            {
                RevArray[index--] = i;
            }
            foreach(int j in RevArray)
            {
                Console.WriteLine(j);
            }

        }
    }
}
