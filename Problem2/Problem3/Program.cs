using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int x = 1; x <= 100; x++)
            {
                bool y = x % 3 == 0;
                bool z = x % 5 == 0;
                if (y && z)
                    Console.WriteLine("FizzBuzz");
                else if (y)
                    Console.WriteLine("Fizz");
                else if (z)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(x);
            
            }
        }
        
        
    }
}
