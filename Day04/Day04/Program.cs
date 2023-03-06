using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Day04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Recursion, Sorting, Searching

            /*
                ╔═════════╗ 
                ║Recursion║
                ╚═════════╝ 
             
                Recursion happens when a method calls itself. This creates a recursive loop.
                
                All recursive methods need an exit condition, something that prevents the loop from continuing.
              
            */
            int j = 0;
            DoIt(j);
            for (int i = 0; i < 1000; i++)
            {

            }
            ulong result = Factorial(5);
            int N = 0;
            //RecursiveLoop(N);
            Console.ResetColor();


            /*
                CHALLENGE 1:

                    convert this for loop to a recursive method called Bats. 
                    Call Bats here in Main.
             
                    for(int i = 0;i < 100;i++)
                    {
                        Console.Write((char)78);
                        Console.Write((char)65);
                        Console.Write(' ');
                    }
            */
            Console.Clear();
            Console.WriteLine();
            int k = 0;
            Bats(k);

            Console.Write((char)66);
            Console.Write((char)65);
            Console.Write((char)84);
            Console.Write((char)77);
            Console.Write((char)65);
            Console.Write((char)78);
            Console.WriteLine("!!!!!!!!!");



            /*
                ╔═══════╗ 
                ║Sorting║
                ╚═══════╝ 
             
                Sorting is used to order the items in a list/array is a specific way
             
                CHALLENGE 2:

                    Convert this BubbleSort pseudo-code into a C# method             
                     
                    procedure bubbleSort(A : list of sortable items)
                      n := length(A)
                      repeat
                          swapped := false
                          for i := 1 to n - 1 inclusive do
                              if A[i - 1] > A[i] then
                                  swap(A, i - 1, i)
                                  swapped = true
                              end if
                          end for
                          n := n - 1
                      while swapped
                    end procedure
                    
            */
            List<int> numbers = new() { 5, 4, 3, 2, 1 };
            PrintMe(numbers);
            BubbleSort(numbers);
            PrintMe(numbers);

            string s1 = "Batman", s2 = "Aquaman";
            int compareResult = s1.CompareTo(s2);
            // returns...
            // -1  s1 LESS THAN s2
            //  0  s1 EQUALS s2
            //  1  s1 GREATER THAN s2
            if(compareResult == 0) Console.WriteLine($"{s1} EQUALS {s2}");
            else if (compareResult < 0) Console.WriteLine($"{s1} LESS THAN {s2}");
            else if (compareResult > 0) Console.WriteLine($"{s1} GREATER THAN {s2}");
        }

        private static void PrintMe(List<int> numbers)
        {
            Console.WriteLine();
            foreach (int i in numbers)
                Console.Write($"{i} ");
            Console.WriteLine();
        }

        static void BubbleSort(List<int> A)
        {
            int n = A.Count;
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 1; i <= n-1; i++)
                {
                    if (A[i - 1] > A[i])
                    {
                        //int temp = A[i - 1];
                        //A[i - 1] = A[i];
                        //A[i] = temp;
                        (A[i], A[i-1]) = (A[i-1], A[i]);//using tuples
                        swapped = true;
                    }
                }
                --n;
            } while (swapped);
        }

        private static void Bats(int k)
        {
            //for (; i < 100; i++)
            if(k < 100)
            {
                Console.Write((char)78);
                Console.Write((char)65);
                Console.Write(' ');
                Bats(++k);//k++ and k+1
            }
        }

        static ulong Factorial(uint N)
        {
            if (N <= 1) 
                return 1;

            ulong result = N * Factorial(N - 1); //N * (N-1)!
            return result;
        }

        private static void DoIt(int j)
        {
            if(j < 1000)
            {
                Console.WriteLine("Done it.");
                DoIt(j + 1);
            }
        }

        static void RecursiveLoop(int N)
        {
            //an Exit Condition. This will stop the loop when N >= Console.WindowWidth
            if (N < Console.WindowWidth)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Write(' ');
                Thread.Sleep(20);

                RecursiveLoop(N + 1);//calls itself which makes the method recursive

                Thread.Sleep(20);
                Console.CursorLeft = N;
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.Write(' ');
            }
        }
    }
}
