using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08CL
{
    //only 1 base class, implement N number of interfaces
    public class Employee : Person
    {
        public double Salary { get; set; }

        public Employee(double salary, string name, int age) : base(name, age) //new Person(name, age)
        {
            Salary = salary;
        }
    }
}
