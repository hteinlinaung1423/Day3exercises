using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3exercises
{
    class exe6
    {
        static void Main()
        {
            double tv, dvd, mp3;
            double tvtotal=0,dvdtotal=0,total=0;
            double disprice;
            Console.WriteLine("Product Name: TV \t Price: $900");
            Console.Write("Please Write order quantity for TV :");
            tv = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Product Name: DVD \t Price: $500");
            Console.Write("Please write order quantity for DVD :");
            dvd= Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Product Name: MP3 \t Price: $700");
            Console.Write("Please write order quantity for MP3 :");
            mp3 = Convert.ToInt32(Console.ReadLine());

            if (tv == 0 && dvd == 0 && mp3 == 0)
            {
                Console.WriteLine("Thanks You! See you again!");
            }
            else
            {
                tvtotal += 900 * tv;
                dvdtotal += 500 * dvd;
                
                total = tvtotal + dvdtotal + (700*mp3);

            }

            if (total > 10000)
            {
                disprice = (tvtotal + dvdtotal) * 0.15;
                Console.WriteLine("{0}", disprice);
                total -= disprice;
                Console.WriteLine("Total Amount discount included: ${0:0,0.0}", total);
            }

            else if (total > 5000)
            {
                disprice = (tvtotal + dvdtotal) * 0.1;
                total -= disprice;
                Console.WriteLine("Total Amount discount included: ${0:0,0.0}", total);
            }
            
            else
            {
                Console.WriteLine("No discount under $5000 ");
                Console.WriteLine("Total Amount no discount included: ${0:0,0.0}", total);
            }

        }
    }
}
