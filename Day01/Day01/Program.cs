﻿using System;
using System.Collections.Generic;

namespace Day01
{
    /*                    METHODS          
                                                               
                ╔══════╗ ╔═══╗ ╔══════════╗ ╔════════════════╗ 
                ║public║ ║int║ ║SomeMethod║ ║(int someParam) ║ 
                ╚══════╝ ╚═══╝ ╚══════════╝ ╚════════════════╝ 
                    │      │         │               │         
              ┌─────┘      │         └──┐            └───┐     
         ┌────▼────┐   ┌───▼───┐   ┌────▼───┐       ┌────▼────┐
         │ Access  │   │ Return│   │ Method │       │Parameter│
         │ modifier│   │ type  │   │  Name  │       │  list   │
         └─────────┘   └───────┘   └────────┘       └─────────┘
    
            Vocabulary:
        
                  method (or function): https://www.w3schools.com/cs/cs_methods.php
                      a block of code that can be referenced by name to run the code it contains.

                  parameter: https://www.w3schools.com/cs/cs_method_parameters.php
                      a variable in the method definition.The list of parameters appear between the ( ) in a method header.

                  arguments:
                      when a method is called, arguments are the data you pass into the method's parameters
        
                  return type: https://www.w3schools.com/cs/cs_method_parameters_return.php
                      the value returned when a method finishes.
                      A return type must be specified on a method.
                      If no data is returned, use void.
    
        
                  List<T>: https://www.tutorialsteacher.com/csharp/csharp-list#:~:text=C%23%20-%20List%3CT%3E%201%20List%3CT%3E%20Characteristics%20List%3CT%3E%20equivalent,8%20Check%20Elements%20in%20List%20...%20More%20items
                    a collection of strongly typed objects that can be accessed by index. Indexes start at 0.



             Lecture videos:
                  METHODS LECTURE:
                  https://fullsailedu-my.sharepoint.com/:v:/g/personal/ggirod_fullsail_com/EW0hLKhQiBdFjOGq1WG6oRoB9TTQWJd1L9ic6VRiEYwgdg?e=J7uZXt
                  Chapters: Method Basics through Method Examples

                  LIST LECTURE:
                  https://fullsailedu-my.sharepoint.com/:v:/g/personal/ggirod_fullsail_com/ERG1iZHKJgFIoj6W8dhxPPgBIIY-Ot1b6Ueh-50Ggfcikg?e=goT9d6
                  Chapters: Array Basics through Looping Examples.

     */
    internal class Program
    {
        static string DoIt(string msg)//pass by value param
        {
            msg += "!";
            //$ - C# interpolated string
            return $"Hello {msg}!";
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            string location = "Gotham";
            string hello = DoIt(location);
            PrintIt(hello);

            /*
              Calling a method
                use the methods name.
                1) if the method needs data (i.e. has parameters), you must pass data to the method that matches the parameter types
                2) if the method returns data, it is usually best to store that data in a variable on the line where you call the method.
             
            */

            /*
                ╔══════════════════════════╗ 
                ║Parameters: Pass by Value.║
                ╚══════════════════════════╝ 
             
                Copies the value to a new variable in the method.
                
                For example, the AddOne method has a parameter called localNumber. localNumber is a variable that is local ONLY to the method.
                The value of the variable in main, number, is COPIED to the variable in AddOne, localNumber.
              
            */
            int number = 5;
            int plusOne = AddOne(number);

            /*
                CHALLENGE 1:

                    call the Sum method on the t1000 calculator. 
                    Print the sum that is returned.
             
            */
            Calculator t1000 = new Calculator();//t1000 is an INSTANCE of calculator
            //use the dot operator '.' on t1000
            Console.WriteLine(t1000.ModelNumber);

            int score1 = 1000, score2 = 50;
            int scoreTotal = t1000.Sum(score1, score2);
            Console.WriteLine($"Total Score: {scoreTotal}");

            Console.WriteLine($"Terminators: {Calculator.NumberOfTerminatorsMade}");


            /*   
                ╔═════════╗ 
                ║ List<T> ║
                ╚═════════╝ 
                
                [  Creating a List  ]
                
                List<T>  - the T is a placeholder for a type. It is a "Generic Type Parameter" to the class.
                
                When you want to create a List variable, replace T with whatever type of data you want to store in the List.
            */
            List<string> names = new List<string>(); //this list stores strings and only strings.
            PrintInfo(names);//Count: 0   Capacity: 0
            names.Add("Batman");
            PrintInfo(names);//Count: 1   Capacity: 4
            names.Add("Bruce");
            names.Add("The Bat");
            names.Add("The Greatest Detective");
            PrintInfo(names);//Count: 4   Capacity: 4
            names.Add("The Dark Knight");
            PrintInfo(names);//Count: 5   Capacity: 10? 9? 420?
            names.Add("Banner");
            names.Add("Bane");
            names.Add("Joker");
            names.Add("Not Clark Kent");
            PrintInfo(names);//Count: 9   Capacity: 16

            try
            {
                Console.WriteLine(names[12]);
            }
            catch (Exception)
            {
            }

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }





            Random rando = new Random();
            int[] scores = new int[3] { 
                rando.Next(10000) ,
                rando.Next(10000) ,
                rando.Next(10000)
            };
            for (int i = 0; i < scores.Length; i++)
            {
                Console.WriteLine(scores[i]);
            }
            foreach (var score in scores)
            {
                Console.WriteLine(score);
            }
            int[] temp = new int[4];
            for (int i = 0; i < scores.Length; i++)
            {
                temp[i] = scores[i];
            }
            scores = temp;
            //C# anonymous types





            /*   
                ╔═════════╗ 
                ║ List<T> ║
                ╚═════════╝ 

                [  Adding items to a List  ]

                There are 2 ways to add items to a list:
                1) on the initializer. 
                2) using the Add method. 
            */
            List<char> letters = new List<char>() { 'B', 'a', 't', 'm', 'a', 'n' };
            letters.Add('!');//adds to the end of the list

            /*
                CHALLENGE 2:

                    Create a list that stores floats. Call the variable grades.
             
            */
            List<float> grades = new List<float>();

            /*
                CHALLENGE 3:

                    Add a few grades to the grades list you created in CHALLENGE 2.
             
            */
            grades.Add((float)rando.NextDouble() * 100);
            grades.Add((float)rando.NextDouble() * 100);
            grades.Add((float)rando.NextDouble() * 100);
            grades.Add((float)rando.NextDouble() * 100);
            grades.Add((float)rando.NextDouble() * 100);
            grades.Add((float)rando.NextDouble() * 100);






            /*   
                ╔═════════╗ 
                ║ List<T> ║
                ╚═════════╝ 

                [  Looping over a List  ]

                You can loop over a list with a for loop or a foreach loop.
                1) for loop. use the Count property in the for condition.
                2) foreach loop
            */
            for (int i = 0; i < letters.Count; i++)
                Console.Write($" {letters[i]}");

            foreach (var letter in letters)
                Console.Write($" {letter}");

            /*
                CHALLENGE 4:

                    1) Fix the Average method of the calculator class to calculate the average of the list parameter.
                    2) Call the Average method on the t1000 variable and pass your grades list to the method.
                    3) print the average that is returned.
             
            */
            float average = t1000.Average(grades);
            Console.WriteLine($"\n\nAverage grade: {average}");


            Console.ReadKey(true);
        }

        private static void PrintInfo(List<string> names)
        {
            //Count: # of items that have been ADDED
            //Capacity: Length of the internal array
            Console.WriteLine($"Count: {names.Count} \tCapacity: {names.Capacity}");
        }

        private static void PrintIt(string hello)
        {
            Console.WriteLine(hello);
        }

        private static int AddOne(int localNumber)
        {
            return localNumber + 1;
        }


    }

    class Calculator
    {
        public static int NumberOfTerminatorsMade = 10000000;

        public string ModelNumber = "T1000";
        public int Sum(int num1, int num2)
        {
            return num1 + num2;
        }


        public float Average(List<float> numbers)
        {
            float avg = 0F;

            //loop over the numbers and calculate the average
            for (int i = 0; i < numbers.Count; i++)
            {
                avg += numbers[i];
            }

            return avg / numbers.Count;
        }
    }
}
