using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace Day04
{
    internal class Program
    {
        enum Weapon
        {
            Sword, Axe, Spear, Mace
        }

        static int LinearSearch(List<int> numbers, int searchNumber)
        {
            int foundIndex = -1;
            for (int i = 0; i < numbers.Count; i++)
            {
                if(searchNumber == numbers[i])
                {
                    foundIndex = i;
                    break;
                }
            }
            return foundIndex;
        }
        static void Main(string[] args)
        {
            /*
                ╔═════════╗ 
                ║Searching║
                ╚═════════╝ 
             
                There are 2 ways to search a list: linear search or binary search
             
                CHALLENGE 1:

                    Convert Linear Search algorithm into a method. 
                        The method should take 2 parameters: list of ints to search, int to search for.
                        The method should return -1 if NOT found or the index if found.
                     
                    The algorithm:
                        1) start at the beginning of the list
                        2) compare each item in the list to the search item
                        3) if found, return the index
                        4) if reach the end of the list, return -1 which means not found
                    
            */
            List<int> nums = new() { 1, 2, 3, 4, 5, 420 };
            int index = LinearSearch(nums, 13);
            if(index != -1)
            {

            }
            else
            {
                Console.WriteLine("Not found");
            }



            /*   
                ╔══════════════════════════╗ 
                ║ Dictionary<TKey, TValue> ║
                ╚══════════════════════════╝ 
                
                [  Creating a Dictionary  ]
                
                Dictionary<TKey, TValue>  - the TKey is a placeholder for the type of the keys. TValue is a placeholder for the type of the values.
                
                When you want to create a Dictionary variable, replace TKey with whatever type of data you want to use for the keys and
                replace TValue with the type you want to use for the values.
            */
           
            Dictionary<Weapon, int> backpack = new Dictionary<Weapon, int>();//will store the counts of each kind of weapon

            /*  
                ╔══════════════════════════╗ 
                ║ Dictionary<TKey, TValue> ║
                ╚══════════════════════════╝ 

                [  Adding items to a Dictionary  ]

                There are 3 ways to add items to a Dictionaruy:
                1) on the initializer. 
                2) using the Add method. 
                3) using [key] = value
            */

            //
            //  Keys MUST BE UNIQUE!
            //  Values do not have to be unique
            //
            nums = new() { 1, 2, 3, 4, 5, 420 };
            backpack = new Dictionary<Weapon, int>()
            {
                // { key, value }   key-value pair
                { Weapon.Sword, 5 } 
                //{ Weapon.Sword, 6 } //throw a key-already-exists exception
            };
            backpack.Add(Weapon.Axe, 2);
            //backpack.Add(Weapon.Axe, 24);//throw a key-already-exists exception
            backpack[Weapon.Spear] = 1;
            backpack[Weapon.Spear] = 3; //simply overwrite the value
            nums[2] = 13;

            /*
                CHALLENGE 2:

                    Create a Dictionary that stores names (string) and grades. Call the variable grades.
             
                CHALLENGE 3:

                    Add students and grades to your dictionary that you created in CHALLENGE 2.
             
            */
            List<string> students = new()
            {
                "Michael B.", "Aiden", "Isaiah", "Adam", "Nicholas", "Lascelles", "Tylique", "Ryan",
                "Iain", "John", "Erickson", "Dylan", "Najee", "Chali", "Tyler", "Robert P", "Sean",
                "Caedan", "Blake", "Michael W.", "Kari", "Christian", "Jesse", "Joshua", "Kristina",
                "Miguel", "Robert M", "Darien"
            };
            Dictionary<string, double> grades = new Dictionary<string, double>();
            Random rando = new Random();
            foreach (var student in students)
            {
                grades.Add(student, rando.NextDouble() * 100);
            }

            grades["Garrett"] = 100;





            /*   
                ╔══════════════════════════╗ 
                ║ Dictionary<TKey, TValue> ║
                ╚══════════════════════════╝ 

                [  Looping over a Dictionary  ]

                You should use a foreach loop when needing to loop over the entire dictionary.
               
            */
            foreach (KeyValuePair<Weapon, int> weaponCount in backpack)
            {
                Console.WriteLine($"You have {weaponCount.Value} {weaponCount.Key}");
            }



            /*
                CHALLENGE 4:

                    Loop over your grades dictionary and print each student name and grade.
             
            */

            Console.WriteLine("----------PG2------------");
            foreach (KeyValuePair<string, double> studentGrade in grades)
            {
                PrintGrade(studentGrade);
            }

            /*   
                ╔══════════════════════════╗ 
                ║ Dictionary<TKey, TValue> ║
                ╚══════════════════════════╝ 

                [  Checking for a key in a Dictionary  ]

                There are 2 ways to see if a key is in the dictionary:
                1) ContainsKey(key)
                2) TryGetValue(key, out value)
               
            */
            //int maceCount = backpack[Weapon.Mace];//throw an exception
            if (backpack.ContainsKey(Weapon.Axe))
                Console.WriteLine($"{Weapon.Axe} count: {backpack[Weapon.Axe]}");
            else
                Console.WriteLine("Key wasn't found.");

            if (backpack.TryGetValue(Weapon.Spear, out int spearCount))
                Console.WriteLine($"{Weapon.Spear} count: {spearCount}");


            /*
                CHALLENGE 5:

                    Using either of the 2 ways to check for a key, 
                        look for a specific student in the dictionary. 
                    If the student is found, print out the student's grade
                    else print out a message that the student was not found
             
            */
            do
            {
                Console.Write("Please enter the student's name: ");
                string studentName = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(studentName))
                    break;

                if (grades.TryGetValue(studentName, out double studentGrade))
                    PrintGrade(new KeyValuePair<string, double>(studentName, studentGrade)); 
                else
                    Console.WriteLine($"{studentName} is not in PG2.");
            } while (true);







            /*   
                ╔══════════════════════════╗ 
                ║ Dictionary<TKey, TValue> ║
                ╚══════════════════════════╝ 

                [  Updating a value for a key in a Dictionary  ]

                To update an exisiting value in the dictionary, use the [ ]
                
               
            */
            backpack[Weapon.Mace] = 0; //sell all maces



            /*
                CHALLENGE 6:

                    Pick any student and curve the grade (add 5) that is stored in the grades dictionary
             
            */
        }

        private static void PrintGrade(KeyValuePair<string, double> studentGrade)
        {
            Console.Write($"{studentGrade.Key,-15}");
            double grade = studentGrade.Value;
            if (grade < 59.5) Console.ForegroundColor = ConsoleColor.Red;
            else if (grade < 69.5) Console.ForegroundColor = ConsoleColor.DarkYellow;
            else if (grade < 79.5) Console.ForegroundColor = ConsoleColor.Yellow;
            else if (grade < 89.5) Console.ForegroundColor = ConsoleColor.Blue;
            else Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{grade:N2}");
            Console.ResetColor();
        }
    }
}
