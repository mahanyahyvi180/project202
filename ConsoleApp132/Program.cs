using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp132
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Square of integer 7 is:{Square(7)}");
            Console.WriteLine($"Square of double 7.5 is:{Square(7.5)}");
            Console.ReadLine();
        }
        static int Square(int intValue)
        {
            Console.WriteLine($"Called with square int argument:{intValue}");
            return intValue * intValue;
        }
        static double Square(double doubleValue)
        {
            Console.WriteLine($"Called with square double argument:{doubleValue}");
            return doubleValue * doubleValue;
        }
         
            
    }
}
