using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            var right = 0;
            var wrong = 0;
            Console.WriteLine("How many legs does chicken have?");
            Console.WriteLine("A: 2");
            Console.WriteLine("B: 4");
            Console.WriteLine("C: 8");
            if(Console.ReadLine().ToUpper() == "A")
            {
                right++;
            }
            else
            {
                wrong++;
            }
            Console.WriteLine("How many legs does frog have?");
            Console.WriteLine("A: 2");
            Console.WriteLine("B: 4");
            Console.WriteLine("C: 8");
            if (Console.ReadLine().ToUpper() == "B")
            {
                right++;
            }
            else
            {
                wrong++;
            }
            Console.WriteLine("How many legs does crab have?");
            Console.WriteLine("A: 2");
            Console.WriteLine("B: 4");
            Console.WriteLine("C: 8");
            if (Console.ReadLine().ToUpper() == "C")
            {
                right++;
            }
            else
            {
                wrong++;
            }
            Console.WriteLine("Your score is: " + right + " right " + wrong + " wrong");
        }
    }
}
