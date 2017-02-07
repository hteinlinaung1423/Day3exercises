using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3exercises
{
    class exe1
    {
        static void Main(string[] args)
        {
            string name, gender;
            Console.Write("Enter your name : ");
            name = Console.ReadLine();
            Console.Write("Enter your Gender (M or F) :");
            gender = Console.ReadLine();
            if (gender == "M" || gender == "m")
            {
                Console.WriteLine("Good Morning Mr.{0}", name);
            }
            else if (gender == "F" || gender == "f")
            {
                Console.WriteLine("Good Morning Ms.{0}", name);
            }
             
        }
    }
}
