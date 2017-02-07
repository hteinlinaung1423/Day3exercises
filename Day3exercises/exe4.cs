using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3exercises
{
    class exe4
    {
        static void Main()
        {
            double dist, fare=0.0;
            Console.Write("Enter a distance you travelled in km : ");
            dist = Convert.ToDouble(Console.ReadLine());
            dist = Math.Round(dist, 1);
            if (dist <= 0.5)
            {
                fare = 2.40;
            }
            else if (dist > 0.5 && dist <= 9)
            {
                fare = 2.40 + 85 * 0.04;
            }
            else
            {
                fare = 2.40 + 85 * 0.04 + (dist * 10 - 90) * 0.05; 
            }

            Console.WriteLine("Total Cost : {0:0.0}", fare);
        }
    }
}
