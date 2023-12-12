using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class Employees
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Department { get;  set; }

        public static List<Employees> GetALLEmployees()
        {

            List<Employees> Emplist = new List<Employees>()
            {                
                new Employees { ID = 2, Name="Akash", Department="Sales", Salary=20000},
                new Employees { ID = 1, Name="Sahana", Department="IT",Salary=35000},
                new Employees { ID = 7, Name="Rakesh", Department="Marketing", Salary=28000},
                new Employees { ID = 8, Name="Sachin", Department="IT", Salary=55500},
                new Employees { ID = 4, Name="Jayanth", Department="Security", Salary=23000},
                new Employees { ID = 12, Name="Lakshmi", Department="IT", Salary=50000},
                new Employees {ID= 106, Name = "Sandhya", Department = "IT", Salary = 25000},
                new Employees {ID= 107, Name = "Mahesh", Department = "IT",Salary = 35000},
                new Employees {ID= 108, Name = "Manoj", Salary = 11000, Department = "Sales"},
                new Employees {ID= 109, Name = "Pradeep", Salary = 20000, Department = "Sales"},
                new Employees {ID= 110, Name = "Saurav", Salary = 25000, Department = "Sales"}
            };
            return Emplist;
        }
    }
    internal class LinqWhere2
    {
        static void Main(string[] args)
        {
            var methodsyntax = Employees.GetALLEmployees().Where(val => val.Department == "Sales").ToList();

            var querysyntax = (from emp in Employees.GetALLEmployees() where emp.Department == "IT" select emp).ToList();

            Console.WriteLine("Using Method syntax to print Sales Department employee");
            foreach(var emps in methodsyntax)
            {
                Console.WriteLine($"ID: {emps.ID} Name: {emps.Name} Salary:{emps.Salary}");
            }
            Console.WriteLine();

            Console.WriteLine("Using linq query list the IT department employee");
            foreach(var emp in querysyntax)
            {
                Console.WriteLine($"ID: {emp.ID} Name: {emp.Name} Salary: {emp.Salary}");
            }
            Console.WriteLine();


            //var dist=(from dis in Employees.GetALLEmployees() select dis.Department).Distinct().ToList();
            //Console.WriteLine("Distinct department people");
            //foreach(var emp in dist)
            //{
            //    Console.WriteLine(emp);
            //}
        }
    }
}
