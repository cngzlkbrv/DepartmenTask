using DepartmentTask.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentTask.Models
{
    internal class Employee:IPerson
    {
        public double Salary { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        private static int _id;
        public int Id { get; set; }

        public Employee(string name,int age,double salary)
        {
            _id++;
            Id = _id;
            Name = name;
            Age = age;
            Salary = salary;
        }



        public string ShowInfo()
        {
            return $"Id:{Id} Ad:{Name} Yas:{Age} Gelir:{Salary}";
        }
        public override string ToString()
        {
            return ShowInfo();
        }
    }
}
