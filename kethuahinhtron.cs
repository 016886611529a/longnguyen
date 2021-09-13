using System;

namespace Hoctap
{
    class HinhTron
    {
        protected double r;

        public HinhTron(double r)
        {
            this.r = r;
        }
        public double dientich()
        {
            return 3.14 * r * r;
        }
        public double chuvi()
        {
            return 2 * 3.14 * r;
        }
    }
    class HinhTru : HinhTron
    {
        private double h;
        public HinhTru(double r, double h) : base(r)
        {
            this.h = h;
        }
        public double dientichxungquanh()
        {
            return 2 * 3.14 * r * h;// s xung quanh = 2 *pi *r *h; 
        }
        public double dientichtoanphan()
        {
            return 2 * 3.14 * r * (r + h); //s toàn phần = s xung quanh + 2 mặt đáy 
        }
    }
    class kethuahinhtron
    {
        static void Main(string[] args)
        {
            HinhTru x = new HinhTru(10, 5);
            Console.Write("Dien tich xung quanh va toan phan cua hinh tru la: {0}, {1}", x.dientichxungquanh(), x.dientichtoanphan());
            Console.ReadLine();
        }
    }
}