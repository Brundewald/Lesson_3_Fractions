using System;
using Fractions_Library;

/*Created by Nikita Mialkin for GeekBrains*/

namespace Lesson_3_Fractions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi! This program will help you with rational fractions.\n");
            Fraction_Calculator();
            Console.Write("Bye!");
        }

        private static void Fraction_Calculator()
        {
            while (true)
            {

                int a = 0;
                int b = 0;
                Fraction nmbr1 = new Fraction(0, 0, 0);
                Fraction nmbr2 = new Fraction(0, 0, 0);

                Console.WriteLine("Enter first fraction");
                
                nmbr1.n = getNumerator(ref b);
                nmbr1.d = getDivisor(ref a);
                Console.Write($"First fraction: {nmbr1}\n");

                Console.WriteLine("Enter second fraction");
                nmbr2.n = getNumerator(ref b);
                nmbr2.d = getDivisor(ref a);
                Console.Write($"Second fraction: {nmbr2}\n");
                
                Fraction sum = nmbr1 + nmbr2;   //sum
                Console.Write($"\nHere is sum: {sum}\n");

                Fraction sumS = Fraction.Simplify(sum.i, sum.n, sum.d);
                Console.Write($"\nHere is simplicated sum: {sumS}\n");

                Fraction sub = nmbr1 - nmbr2;   //substraction
                Console.Write($"\nHere is substraction: {sub}\n");

                Fraction subS = Fraction.Simplify(sub.i, sub.n, sub.d);
                Console.Write($"\nHere is simplicated substraction: {subS}\n");

                Fraction mul = nmbr1 * nmbr2; //multiplication
                Console.Write($"\nHere is multiplication: {mul}\n");

                Fraction mulS = Fraction.Simplify(mul.i, mul.n, mul.d);
                Console.Write($"\nHere is simplicated multiplication: {mulS}\n");

                Fraction div = nmbr1 / nmbr2; //divide
                Console.Write($"\nHere is divide: {div}\n");

                Fraction divS = Fraction.Simplify(div.i, div.n, div.d);
                Console.Write($"\nHere is simplicated divide: {divS}\n");

                double decSum = sum.n / sum.d;
                Console.Write($"\nHere is sum decimal: {decSum:F2}\n");

                double decSub = sub.n / sub.d;
                Console.Write($"\nHere is sum decimal: {decSub:F2}\n");

                double decMul = mul.n / mul.d;
                Console.Write($"\nHere is sum decimal: {decMul:F2}\n");

                double decDiv = div.n / div.d;
                Console.Write($"\nHere is sum decimal: {decDiv:F2}\n");

                Console.Write("If you don't want to repeat press 'n': ");
                string rpt = Console.ReadLine();

                if (rpt == "n") break;
            }
           
        }

      

        private static int getNumerator(ref int b)
        {
            
            while (true)
            {
                Console.Write("\nEnter the numerator:");
                var n = int.TryParse(Console.ReadLine(), out b);

                if (b > 0 && n)
                {
                    break;
                }

            }

            return b;
            }
         
        private static int getDivisor(ref int a)
        {
            
            while (true)
            {

                Console.Write("\nEnter the divisor:");
                var d = int.TryParse(Console.ReadLine(), out a);
                if (a > 0 && d)
                {
                    
                    break;
                }

            }

            return a;
        }
    }   
}
