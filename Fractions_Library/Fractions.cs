using System;

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
            
            if (n % 2 == 0 && d % 2 == 0) // это условие проверяет кратность и отдаёт сокращённую дробь
            {
                while (n > d)
                {
                    i = n / d;
                    n = n - i * d;
                    
                }

                while (n % 2 == 0 && d % 2 == 0)
                {
                    n = n / 2;
                    d = d / 2;
                }
                                              

                return new Fraction(
                i: i,
                n: n,
                d: d
                );

                
            }

            if (n >= d)
            {
                while (n >= d) // это условие получает целое число если знаменатель больше делителя
                {
                    i = n / d;
                    n = n - i * d; 
                    
                }
                return new Fraction(
                i: i,
                n: n,
                d: d
                );
            }

            else return new Fraction(
                i: i,
                n: n,
                d: d
                );      // в случае если дробь правильная и не подлежит упрощению, то выводит результат
        }

        //public override Fraction operator +() 
        //{
            
        //}


    
        //public static Fraction integer_calculation (int i, int n, int d)
        //{
                       
        //    return new Fraction(
        //        i: i + (n/d),
        //        n: ,
        //        d:
        //        );
               
          
        //}

        public override string ToString()
        {
            if (n > 0 && n < d && i > 0) return $"{i},{n}/{d}";
            else if (i > 0 && n == 0) return $"{i}";
            else return $"{n}/{d}";
        }
    }
}
