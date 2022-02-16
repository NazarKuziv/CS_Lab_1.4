using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lab_1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            double x, xp, xk, dx, a, b, c, F;
            Console.Write("xp = ");
            xp = Convert.ToDouble(Console.ReadLine());
            Console.Write("xk = ");
            xk = Convert.ToDouble(Console.ReadLine());
            Console.Write("dx = ");
            dx = Convert.ToDouble(Console.ReadLine());
            Console.Write("a = ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b = ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c = ");
            c = Convert.ToDouble(Console.ReadLine());
            x = xp;

            Console.WriteLine("---------------------------");
            Console.WriteLine("{0,-10} | {1,-19}", 'x', 'F');
            Console.WriteLine("---------------------------");

            while (x <= xk)
            {
                if (c < 0 && b != 0)
                    F = a * Math.Pow(x, 2) + Math.Pow(b, 2) * x;
                else
                    if (c > 0 && b == 0)
                    F = (x + a) / (x + c);
                else
                    F = x / c;

                Console.WriteLine("{0,-10} | {1,-19}", x, F );

                x += dx;
            }
            Console.WriteLine("---------------------------");
            Console.ReadKey();
        }
    }
}
