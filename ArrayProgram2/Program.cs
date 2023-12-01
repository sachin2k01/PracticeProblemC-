using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProgram2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an Array Size");
            int size=int.Parse(Console.ReadLine());
            int[] array=new int[size];
            Console.WriteLine("Enter a Array ELement to Insert");
            for(int i=0; i<size; i++)
            {
                array[i]=int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter a Number to Search");
            int key=int.Parse(Console.ReadLine()) ;
            Boolean flag = false;

            foreach(int i in array)
            {
                if(i==key) flag = true;
            }

            if(flag==true)
            {
                Console.WriteLine("Key is Found");
            }
            else
            {
                Console.WriteLine("Key is Not Found");
            }
        }
    }
}
