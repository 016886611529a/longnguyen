using System;

namespace ConsoleApp5
{
    abstract class Hinh
    {
        public abstract void TinhToan();
    }
    class HinhTron:Hinh
    {
        double r;
        public HinhTron(double r)
        {
            this.r = r;
        }
        public override void TinhToan()
        {
            Console.WriteLine("dientichhinhtron:{0}", r * r * 3.14);
        }
    }
    class HinhCau:Hinh
    {
        double r;
        public HinhCau (double r)
        {
            this.r = r;
        }
        public override void TinhToan()
        {
            Console.WriteLine("dientichmatcau:{0}", 4 * 3.14 * r * r);
        }
    }
    interface  Hinh1
    {
        public void TinhToan1();
    }
    class HinhTron1 : Hinh1
    {
        double r;
        public HinhTron1(double r)
        {
            this.r = r;
        }
        public void TinhToan1()
        {
            Console.WriteLine("dientichhinhtron:{0}", r * r * 3.14);
        }
    }
    class HinhCau1 : Hinh1
    {
        double r;
        public HinhCau1(double r)
        {
            this.r = r;
        }
        public  void TinhToan1()
        {
            Console.WriteLine("dientichmatcau:{0}", 4 * 3.14 * r * r);
        }
    }
    
    class dahinh
    {
        static void Main(string[] args)
        {
            double r;
            Console.WriteLine("nhap ban kinh:" );r = double.Parse(Console.ReadLine());
            HinhTron x = new HinhTron(r);
            x.TinhToan();
            HinhCau y = new HinhCau(r);
            y.TinhToan();
            HinhTron1 z = new HinhTron1(r);
            z.TinhToan1();
            HinhCau1 u = new HinhCau1(r);
            u.TinhToan1();
            Console.ReadLine();
        }
    }
}
