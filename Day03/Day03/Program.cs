﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Day03
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


    
    ╔═══════════╗ 
    ║Return type║ Return type defines the type of the data being returned.
    ╚═══════════╝
    │
    │
    └── If NO data is returned, then use "void" for the return type.
    │    public void PrintSomething()
    │    {
    │        Console.WriteLine("Something");
    │    }
    │
    │
    └── If a method returns data, then the return type must match the type of the data being returned.
        public float GetMyGrade()
        {
            return 99.9F; //returning a float so set return type to float
        }

    ╔══════════╗ 
    ║Parameters║ Parameters define the data passed to the method.
    ╚══════════╝
    │
    │
    └── If NO data is passed to the method, leave the parenthesis empty. EX: ( )
    │    public void PrintSomething()
    │   {  }
    │
    │
    └── If passing data to the method, then define the variable the method will use to store the data.
        Parameters are just variables therefore parameters need 2 things: <type> <name>
        Example:
        public void PrintMyGrade(float myGrade)
        {
            Console.WriteLine($"My grade is {myGrade}");
        }

        

     */
    internal class Program
    {
        static void Main(string[] args)
        {


            /*   
                ╔═══════════════════════════════╗ 
                ║Parameters: optional parameters║
                ╚═══════════════════════════════╝ 
                
                Unless specified, parameters to a method are required.
                However, you can make parameters optional, meaning when calling the method, you aren't required to pass values for the optional parameters.

                REQUIREMENT:
                    - all optional parameters have to be at the end of the list of parameters
                    - in the list of parameters, assign a value to any parameter you want to be optional
            */
            string file = "highScores";
            string postfile = PostFix(file); //if you don't pass a value, the default value will be used for the optional parameter
            postfile = PostFix(file, 5); //if a value is passed, it will be used for the optional parameter



            /*
                CHALLENGE 1:

                    Write a ColorWriteLine method to print a message with a foreground color in the console.
                    1) add a string message parameter AND an optional color parameter. 
                       Choose whatever default color you want.
                    2) in the method, set the foreground color to the optional parameter
                    3) print the message
             
            */
            ColorWriteLine("Hello Gotham!");
            ColorWriteLine("Batman > Aquaman. True!", ConsoleColor.DarkRed);


            string[] names = new string[] { "Batman", "The Bat", "NOT Aquaman", "Bruce" };
            List<string> theBest = new List<string>();
            for (int i = 0; i < names.Length; i++)
            {
                theBest.Add(names[i]);
            }

            List<string> best = new List<string>(names);

            //OR

            List<string> notAquamen = names.ToList();

            List<string> upper = MakeUpper(theBest);
            foreach (var item in upper)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

            Random rando = new Random();
            while (true)
            {
                Console.SetCursorPosition(rando.Next(Console.WindowWidth), rando.Next(Console.WindowHeight));
                ColorWriteLine("BATMAN", (ConsoleColor)rando.Next(16));
            }


        }

        private static List<string> MakeUpper(List<string> otherList)//pass by value (COPY). how is the parameter being passed?
        {
            List<string> cloned = new List<string>(otherList);// otherList.ToList();
            for (int i = 0; i < cloned.Count; i++)
            {
                cloned[i] = cloned[i].ToUpper();
            }
            return cloned;
        }

        private static void ColorWriteLine(string message, ConsoleColor foregroundColor = ConsoleColor.DarkCyan)
        {
            Console.ForegroundColor = foregroundColor;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        static string PostFix(string fileName, int postFixNumber = 1) //postFixNumber is optional
        {
            return fileName + postFixNumber;
        }
    }
}
