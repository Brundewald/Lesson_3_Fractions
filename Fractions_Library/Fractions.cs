using System;

/*Created by Nikita Mialkin for GeekBrains*/

namespace Fractions_Library
{
    public struct Fraction
    {
        public int i, n, d; //integer, numerator, divisor
        
        public Fraction(int i, int n, int d) 
        {
            this.i = i;
            this.n = n;
            this.d = d;
        }

        public static Fraction Simplify(int i, int n, int d)
        {
            
            if (n != d && n % 2 == 0 && d % 2 == 0) // checking is numerato or divisor even number and numerator not equal divisor
            {
                while (n > d)
                {
                    i = n / d;
                    n = n - i * d;                    
                }//gets integer if numerator is bigger then divisor

                while (n % 2 == 0 && d % 2 == 0)
                {
                    n = n / 2;
                    d = d / 2;
                }//does a simplication                                    

                return new Fraction(
                i: i,
                n: n,
                d: d
                ); //return simplicated fraction               
            }

            if (n >= d) //if numerator or divisor not even number and numerator bigger then divisor then calculate integer
            {
                while (n >= d) // gets integer and numerator
                {
                    i = n / d;
                    n = n - i * d;                     
                } 

                return new Fraction(
                i: i,
                n: n,
                d: d
                ); //return simplicated fraction
            }

            else return new Fraction(
                i: i,
                n: n,
                d: d
                ); //return prober fraction
        }

        public static Fraction operator +(Fraction nmbr1, Fraction nmbr2)
        {
            if (nmbr1.d == nmbr2.d) return new Fraction(
                i: nmbr1.i + nmbr2.i,
                n: nmbr1.n + nmbr2.n,
                d: nmbr1.d
                );
            else return new Fraction(
                i: nmbr1.i + nmbr2.i,
                n: nmbr1.n * nmbr2.d + nmbr2.n * nmbr1.d,
                d: nmbr1.d*nmbr2.d
                );
        }

        public static Fraction operator -(Fraction nmbr1, Fraction nmbr2)
        {
            if (nmbr1.d == nmbr2.d) return new Fraction(
                i: 0,
                n: nmbr1.n - nmbr2.n,
                d: nmbr1.d
                );
            else return new Fraction(
                i: 0,
                n: nmbr1.n * nmbr2.d - nmbr2.n * nmbr1.d,
                d: nmbr1.d * nmbr2.d
                );
        }

        public static Fraction operator *(Fraction nmbr1, Fraction nmbr2)
        {
            return new Fraction(
                i: nmbr1.i * nmbr2.i,
                n: nmbr1.n * nmbr2.n,
                d: nmbr1.d * nmbr2.d
                );            
        }

        public static Fraction operator /(Fraction nmbr1, Fraction nmbr2)
        {
             return new Fraction(
                i: 0,
                n: nmbr1.n * nmbr2.d,
                d: nmbr1.d * nmbr2.n
                );            
        }


        public override string ToString()
        {
            if (n > 0 && n < d && i > 0) return $"{i},{n}/{d}";
            else if (i > 0 && n == 0 || i > 0 && n==d) return $"{i}";
            else return $"{n}/{d}";
        }
    }
}
