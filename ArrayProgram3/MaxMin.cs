using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProgram3
{
    internal class MaxMin
    {
        public void Insert(int[] array,int size)
        {
            Console.WriteLine("Enter a Array ELement to Insert");
            for (int i = 0; i < size; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
        }

        public void minimum(int[] array)
        {
            int min = array[0];
            foreach (int i in array)
            {
                if(i < min)
                {
                    min = i;
                }
            }
            Console.WriteLine($"Minimum Number in a Array is: {min}");
        }

        public void maximum(int[] array)
        {
            int max = array[0];
            foreach (int i in array)
            {
                if (i > max)
                {
                    max = i;
                }
            }
            Console.WriteLine($"Minimum Number in a Array is: {max}");
        }
    }
}
