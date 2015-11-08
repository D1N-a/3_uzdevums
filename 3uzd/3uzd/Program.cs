using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3uzd
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, w, z;


            Console.WriteLine("Ievadiet x \n\t");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("\nIevadiet y\n\t");
            y = int.Parse(Console.ReadLine());

            Console.WriteLine("\n\tx = " + x.ToString()
                + "\n\ty = " + y.ToString());
            w = x + y;


            Console.WriteLine("\n\tx un y summa ir : {0}", x+y);

            z = x * y;
            Console.WriteLine("\n\tx * y = " + z.ToString() + "\n");
            for (int i = 0; i < z; i++)
            {
                Console.Write("* ");
            }

                Console.ReadKey();

        }
    }
}
