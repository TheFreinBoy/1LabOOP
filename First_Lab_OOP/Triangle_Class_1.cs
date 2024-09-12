using System;
namespace Triangle
{
    class ClassTriangle
    {
        protected double a, b, c;
        public ClassTriangle(double a, double b, double c)
        {
            Exceptions(a, b, c);
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public double A
        {
            get { return a; }
            set {
                    if (ExistTriangle(value, b, c))
                    {
                        a = value;
                    }
                    else Exceptions( a, b, c);                    
                }
        }
        public double B
        {
            get { return b; }
            set {
                    if (ExistTriangle(value, a, c))
                    {
                        b = value;
                    }
                    else Exceptions( a, b, c);                   
                }
        }
        public double C
        {
            get { return c; }
            set {
                    if (ExistTriangle(value, b, a))
                    {
                        c = value;
                    }
                    else Exceptions( a, b, c);                    
                }
        }       
        public double AreaOfTriangle()
        {            
            double p = (a + b + c) / 2;                                        
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c)) ;           
        }

        public void Exceptions( double a, double b, double c )
        {
            if ( a <=0 || b <= 0 || c <= 0 )
            {
                throw new ArgumentException( "Сторони повинні бути додатніми" );
            }
            if (  a >= b + c || b >= a + c || c >= a + b )
            {
                throw new ArgumentException ( "Такого трикутника не існує" );
            }
        }    
        public bool ExistTriangle( double a, double b, double c )
        {
            return( a < b + c && b < a + c && c < a + b );
        }

    }
}