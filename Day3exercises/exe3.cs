using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3exercises
{
    class exe3
    {
        static void Main()
        {
            int mark;
            Console.Write("Enter your mark : ");
            mark = Convert.ToInt32(Console.ReadLine());
            if (mark >= 80 && mark <= 100)
            {
                Console.WriteLine("You scored {0} marks which is A grade", mark);
            }
            else if (mark >= 60 && mark <= 79)
            {
                Console.WriteLine("You scored {0} marks which is B grade", mark);
            }
            else if (mark >= 40 && mark <= 59)
            {
                Console.WriteLine("You scored {0} marks which is C grade", mark);
            }
            else if (mark >= 0 && mark <= 39)
            {
                Console.WriteLine("You scored {0} marks which is F grade", mark);
            }
            else
            {
                Console.WriteLine("Input error!");
            }
        }
    }
}
