using System;

namespace kethuatamgiac
{
    class Tamgiac
    {
        protected double a, b, c;
        public Tamgiac(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;

        }
        public double dientich()
        {           
            double p,s;
            p = (a + b + c) / 2;
            s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return s;
        }
         class Tudien:Tamgiac
        {
            private double h;
            public Tudien(double a, double b, double c,double h) : base(a,b,c)
            {
                this.h = h;

            }
            public double Dientichtoanphan()
            {
                return dientich()* 4;

            }
            public double thetichtudien()
            {
                return (1 / 3) * Dientichtoanphan() * h;
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Tudien x = new Tudien(8,7,9,8);
                Console.WriteLine("dien tich tam giac\tdien tich toan phan\tthe tich:{0},{1},{2}",x.dientich(),x.Dientichtoanphan(),x.thetichtudien());
                Console.ReadLine();

            }
        }
    }
}
