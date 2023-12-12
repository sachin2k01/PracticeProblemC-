using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class LinqProblem
    {
        static void Main(string[] args)
        {
            //filtering list by even numbers
            List<int> numbers = new List<int>() {1,2,5,6,8,23,54,65,12 };
            var even=numbers.Where(x=> x % 2 == 0).ToList();
            Console.WriteLine("Even numbers in list");
            foreach (int x in even) Console.Write(x+" ");
            Console.WriteLine();
            Console.WriteLine();

            //Avrage of Students
            var students=new List<Student>
                {
                new Student{Name = "Lakshmi", Score = 64},
                new Student{Name = "Roopesh", Score = 76},
                new Student{ Name = "Bharath", Score= 66},
                new Student{ Name = "Rajath", Score=55}
            };

            var avgscore=students.Average(x => x.Score);
            Console.WriteLine($"Average Score: {avgscore}");
            Console.WriteLine();


            var empdetail = new List<Employee2>
            {
                new Employee2{ Name="Veera", Department="IT"},
                new Employee2{ Name="Sachin", Department="Manager"},
                new Employee2{ Name="manu", Department="IT"},
                new Employee2{ Name="Raju", Department="HR"}
            };

            var empgrp=empdetail.GroupBy(x => x.Department);
            foreach(var grp in empgrp)
            {
                Console.WriteLine($"Employee in {grp.Key} Department");
                foreach(var emp in grp) Console.WriteLine(emp.Name);
            }
            Console.WriteLine();

            Console.WriteLine("FInding Maximum and Minimum");
            int[] num = {1,5,2,6,12,76,23};
            var max=num.Max();
            var min=num.Min();
            Console.WriteLine($"Maximum number is: {max}");
            Console.WriteLine($"Minimum Number is:{min}");
        }
    }
    class Student
    {
        public int Score { get; set; }
        public string Name { get; set; }
    }

    class Employee2
    {
        public string Name { get; set; }
        public string Department {  get; set; }

    }
}
