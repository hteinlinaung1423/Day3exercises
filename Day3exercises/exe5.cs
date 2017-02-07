using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3exercises
{
    class exe5
    {
        static void Main()
        {
            int a;
            int first, second, third;
            Console.Write("Enter a three digit number (100 - 999) : ");
            a = Convert.ToInt32(Console.ReadLine());
            first =a / 100;
            second = (a % 100)/10;
            third = (a % 100) % 10;
            Console.WriteLine("{0} {1} {2}", first, second, third);
            double sum = Math.Pow(first, 3) + Math.Pow(second, 3) + Math.Pow(third, 3);

            if (sum == a)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
           

        }

    }
}
