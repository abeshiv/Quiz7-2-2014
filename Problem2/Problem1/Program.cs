using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;

            Console.WriteLine("Welcome to the Program");
            Console.Write("Enter the first integer");
            x = Convert.ToInt32(Console.Read());
            Console.Write("Enter the second integer");
            y = Convert.ToInt32(Console.Read());

            if (y < x)
                Console.WriteLine(y + " is smaller than " + x);
                Console.ReadLine();
            else(x < y);
                Console.WriteLine(x + " is smaller than " + y);
                Console.ReadLine();





        }
    }
}
