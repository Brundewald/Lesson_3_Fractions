using System;
using Complex_Library;

namespace Complex_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi! This program will help with comlex numbers!\n");

            Complex_Calculator();

        }

        private static void Complex_Calculator()
        {
            while (true)
            {
                Complex nmbr1 = new Complex(a: 0, b: 0);
                Complex nmbr2 = new Complex(a: 0, b: 0);

                Console.Write("Enter real part for first number: ");
                nmbr1.a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter complex part for first number: ");
                nmbr1.b = Convert.ToDouble(Console.ReadLine());

                Console.Write("\nEnter real part for second number: ");
                nmbr2.a = Convert.ToDouble(Console.ReadLine());
                Console.Write("\nEnter complex part for second number: ");
                nmbr2.b = Convert.ToDouble(Console.ReadLine());

                Complex sum = nmbr1 + nmbr2;
                Console.Write($"\nThe sum of complex numbers is: {sum}\n");

                Complex sub = nmbr1 - nmbr2;
                Console.Write($"\nThe substraction of complex numbers is: {sub}\n");

                Complex mul = nmbr1 * nmbr2;
                Console.Write($"\nThe multiplication of complex numbers is: {mul}\n");

                Complex div = nmbr1 / nmbr2;
                Console.Write($"\nThe divide of complex numbers is: {div:F2}\n");

                Console.WriteLine("If you want to stop enter 'n'");
                var k = Console.ReadLine();
                if (k == "n") break;

            }
        }
    }
}
