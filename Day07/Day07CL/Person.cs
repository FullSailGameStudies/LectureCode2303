using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public class Person
    {
        #region Fields
        private int _age = 0;
        #endregion

        #region Properties
        public int Age
        {
            get { return _age; }
            set { 
                if(value >= 0 && value <= 120)
                    _age = value; 
            }
        }
        public string Name { get; private set; } = string.Empty;

        public static int NumberOfPersons { get; set; } = 0;

        #endregion

        public Person(int age, string name)
        {
            Age = age;
            Name = name;
            NumberOfPersons++;
        }

        #region Methods
        //an INSTANCE method
        //there's a hidden parameter called 'this' of type Person
        public void Eat(string food)
        {
            Console.WriteLine($"I am {this.Name} ({Age} years old) and I'm eating {food}. NOM NOM NOM!");
            //Console.WriteLine($"There are {NumberOfPersons} humans on the planet! Release the Kracken!");

        }

        //there is NO 'this' parameter in static methods
        public static void PersonReport()
        {
            Console.WriteLine($"There are {NumberOfPersons} humans on the planet! Release the Kracken!");
            //Console.WriteLine($"I am {this.Name} ({Age} years old)");
        }

        public void ItsMybirthday()
        {
            Age++;
            Console.WriteLine($"It's my birthday! I'm turning {Age} years old. WOOT!");
        }
        #endregion
    }
}
