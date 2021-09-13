using System;
using static donkethua.Hinhchunhat;

namespace donkethua
{
    class Hinhchunhat
    {
        public double d, r;

        public Hinhchunhat(double d, double r)
        {
            this.d = d;
            this.r = r;
        }

        
        public double dientich()
        {
            return d * r;
        }
         public class Hinhhop : Hinhchunhat
        {
            private double c;
            public Hinhhop (double d,double r,double c) : base(d,r)
            {
                this.c = c;

            }
            public double dientichtp()
            {
                return dientich()* c;
            }


        }
            
    }
    class donkethuachunhat
    {
        static void Main(string[] args)
        {
            double d, r, c;
            
            d = double.Parse(Console.ReadLine());
            r = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            Hinhhop x = new Hinhhop(d,r,c);
            Console.WriteLine("dientichhinhtudienla:{0}", x.dientichtp());
              Console.ReadLine();
        }
    }
}
