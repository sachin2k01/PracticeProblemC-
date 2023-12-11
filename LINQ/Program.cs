using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Deparetment { get; set; }

        public static List<Employee> GetALLEmployee()
        {

            List<Employee> Emplist = new List<Employee>()
            {
                new Employee { ID = 1, Name="Sahana", Deparetment="IT",Salary=35000},
                new Employee { ID = 2, Name="Akash", Deparetment="Sales", Salary=20000},
                new Employee { ID = 7, Name="Rakesh", Deparetment="Marketing", Salary=28000},
                new Employee { ID = 8, Name="Sachin", Deparetment="IT", Salary=55500},
                new Employee { ID = 4, Name="Jayanth", Deparetment="Security", Salary=23000},
                new Employee { ID = 12, Name="Lakshmi", Deparetment="IT", Salary=50000}
            };
            return Emplist;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {

            var empname = Employee.GetALLEmployee().ToList();           //Using Method Syntax
            Console.WriteLine("Employee Names using Method syntax");
            foreach (Employee emp in empname)
            {
                Console.WriteLine(emp.Name);
            }

            Console.WriteLine();
            Console.WriteLine("Employee Details using Query synatx");
            var empdetails = (from Emp in Employee.GetALLEmployee() select Emp).ToList();    //Using Query Syntax
            foreach (var emp in empdetails)
            {
                Console.WriteLine(emp.Name+" Details:  Department: "+emp.Deparetment+" Salary: "+emp.Salary);
            }

        }
    }
}
