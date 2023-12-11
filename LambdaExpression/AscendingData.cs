using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class AscendingData
    {
        static void Main(string[] args)
        {
            List<Student> list = new List<Student>()
            {
                new Student{ Id = 101, Name="Sachin"},
                new Student{ Id = 202, Name="Aditya"},
                new Student{ Id = 107, Name="Manoj"},
                new Student{ Id = 105, Name="Rajesh"},
                new Student{ Id = 005, Name="Adarsh"}
            };

            var ordered=list.OrderBy(x => x.Name);
            Console.WriteLine("Ordering the list by name");
            foreach(var x in ordered)
            {
                Console.WriteLine("Reg.No: "+x.Id+" Name: "+x.Name);
            }
            Console.WriteLine();

            var orderedbyId = list.OrderBy(x => x.Id);
            Console.WriteLine("Ordering the list by ID");
            foreach (var x in orderedbyId)
            {
                Console.WriteLine("Reg.No: " + x.Id + " Name: " + x.Name);
            }
            Console.WriteLine();
        }
    }
}
