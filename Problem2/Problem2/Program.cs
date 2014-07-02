using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{

    class Program
    {
        static void Main(string[] args)
        {
            double book1;
            double book2;

            Console.WriteLine("Enter price of book one");
            book1 = Convert.ToDouble(Console.Read());
            Console.ReadLine();

            Console.WriteLine("Enter price of book two");
            book2 = Convert.ToDouble(Console.Read());
            Console.ReadLine();

            if (book1 == book2)
            {
                Console.WriteLine("0");
                Console.ReadLine();
            }
            if (book1 > book2)
            {
                Console.WriteLine("1");
                Console.ReadLine();
            }
            if (book1 < book2)
            {
                Console.WriteLine("-1");
                Console.ReadLine();
            }

        }
    }
}