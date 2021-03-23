using System;
using Fractions_Library;

namespace Lesson_3_Fractions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi! This program will help you with rational fractions.\n");
            while (true)
            {
                int a;
                
                

                Fraction nmbr = new Fraction(0, 0, 0);
                
                a = getNumerator(ref nmbr);
                a = getDivisor(ref nmbr);

                nmbr = Fraction.Simplify(nmbr.i, nmbr.n, nmbr.d);

                Console.Write($"You entered fraction: {nmbr}\n");
                                
                Console.Write("Do you want to repeat? (y/n): ");
                string rpt = Console.ReadLine();

                if (rpt == "n") break;
            }
            Console.Write("Bye!");
        }

        private static int getDivisor(ref Fraction nmbr)
        {
            int a;
            while (true)
            {

                Console.Write("\nEnter the divisor:");
                var d = int.TryParse(Console.ReadLine(), out a);
                if (a > 0 && d)
                {
                    nmbr.d = a;
                    break;
                }

            }

            return a;
        }

        private static int getNumerator(ref Fraction nmbr)
        {
            int a;
            while (true)
            {
                Console.Write("\nEnter the numerator:");
                var n = int.TryParse(Console.ReadLine(), out a);

                if (a > 0 && n)
                {
                    nmbr.n = a;
                    break;
                }

            }

            return a;
        }
    }
}
