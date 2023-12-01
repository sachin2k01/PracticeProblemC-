using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProgram1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the String Array Size");
            int size=int.Parse(Console.ReadLine());
            string[] name=new string[size];
            Console.WriteLine("Enter the Names To Store");
            for(int i=0; i<size; i++)
            {
                name[i] = Console.ReadLine();
            }
            Console.WriteLine("Print WOrds in the String");
            foreach(var words in name)
            {
                Console.WriteLine(words);
            }

        }
    }
}
