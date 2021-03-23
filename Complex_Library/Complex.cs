using System;

namespace Complex_Library
{
    public struct Complex
    {
        public double a, b;

        public Complex(double a, double b) 
        {
            this.a = a;
            this.b = b;                   
        }

        public static Complex operator +(Complex nmbr1, Complex nmbr2) 
        {
            return new Complex(
                a: nmbr1.a+nmbr2.a,
                b: nmbr1.b+nmbr2.b
                );
        }

        public static Complex operator -(Complex nmbr1, Complex nmbr2)
        {
            return new Complex(
                a: nmbr1.a - nmbr2.a,
                b: nmbr1.b - nmbr2.b
                );
        }

        public static Complex operator *(Complex nmbr1, Complex nmbr2)
        {
            return new Complex(
                a: nmbr1.a * nmbr2.a - nmbr1.b * nmbr2.b,
                b: nmbr1.b * nmbr2.a + nmbr2.b * nmbr1.a
                );
        }

        public static Complex operator /(Complex nmbr1, Complex nmbr2)
        {
            return new Complex(
                a: (nmbr1.a*nmbr2.a+nmbr1.b*nmbr2.b)/(Math.Pow(nmbr2.a,2)+Math.Pow(nmbr2.b,2)),
                b: ((nmbr1.b * nmbr2.a - nmbr1.a * nmbr2.b) / (Math.Pow(nmbr2.a, 2) + Math.Pow(nmbr2.b, 2)))
                );
        }

        public override string ToString()
        {
            
            if (b>=0) return $"{a} + {b}i";
            else return $"{a} - {-b}i";
        }
    }
}
