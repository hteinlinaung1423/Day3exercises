using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3exercises
{
    class exe2
    {
        static void Main()
        {
            string name, gender;
            int age;

            Console.Write("Enter your name : ");
            name = Console.ReadLine();

            Console.Write("Enter your age : ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your Gender (M or F) :");
            gender = Console.ReadLine();

            if (gender == "M" )
            {
                if (age >= 45)
                { Console.WriteLine("Good Morning Uncle {0}", name); }
                else
                { Console.WriteLine("Good Morning Mr. {0}", name); }
                
            }
            else if (gender == "F")
            {
                if (age >= 45)
                { Console.WriteLine("Good Morning Aunty {0}", name); }
                else
                { Console.WriteLine("Good Morning Ms. {0}", name); }
            }

        }
    }
}
