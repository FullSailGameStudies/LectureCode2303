using System.Runtime.CompilerServices;

namespace Day09
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Gotham!");

            Calculator t1000 = new();
            int n1 = 5, n2 = 2;
            int sum = t1000.Sum(n1,n2);
            Console.WriteLine($"{n1} + {n2} = {sum}");

            double product = t1000.Multiply(5, 3);

            ConsoleColor myColor = ConsoleColor.Magenta;
            ConsoleColor newColor = myColor.RandoColor();
            myColor.MakeForeground();

            List<int> nums = new List<int>();
        }
    }

    /*  
        ╔═════════════╗ 
        ║ OVERLOADING ║ - polymorphism by changing parameters
        ╚═════════════╝ 

        You can overload a method in 3 ways:
        1) different types on the parameters
        2) different number of parameters
        3) different order of parameters


        CHALLENGE 1:
            Add a overload of the Sum method to sum 2 doubles
    */

    static class Extensions
    {
        static Random randy = new Random();
        public static double Multiply(this Calculator t800, double d1, double factor)
        {
            return d1 * factor;
        }
        public static ConsoleColor RandoColor(this ConsoleColor color)
        {
            return (ConsoleColor)randy.Next(16);
        }
        public static void MakeForeground(this ConsoleColor color)
        {
            Console.ForegroundColor = color;
        }
    }
    class Calculator
    {
        public int Sum(int n1, int n2)
        {
            return n1 + n2;
        }
        public double Sum(double n1, double n2)
        {
            return n1 + n2;
        }
        public string Sum(string n1, string n2)
        {
            return n1 + n2;
        }
    }
}