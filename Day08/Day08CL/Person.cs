using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08CL
{
    public class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public Person()
        {
            Name = "Bruce Wayne";
            Age = 35;
        }

        public virtual void Eat(string food)
        {
            Console.WriteLine($"I'm hungry. let's eat some {food}.");
        }
    }
}
