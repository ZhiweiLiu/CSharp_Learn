using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_packaging
{

    class Rectangle
    {
        //成员变量
        public double length = 2.0;
        public double width = 3.0;

        public double getArea()
        {
            return length * width;
        }

        public void Display()
        {
            Console.WriteLine("长度{0}", length);
            Console.WriteLine("宽度{0}", width);
            Console.WriteLine("面积{0}", getArea());

        }
    }
    class excuteRectangle
    {
        static void Main(string[] args)
        {
            //public 所有的对象都可以访问
            //private 对象本身在对象内部可以访问
            //protected 只有该类对象及其子对象可以访问
            //internal 同一个程序级的对象可以访问
            //protected internal 同一个程序集内的对象，或者该类对象及其子对象可以访问

            Rectangle r = new Rectangle();
            r.length = 5.0;
            r.width = 10.0;
            r.Display();

            PirvateRectangle pr = new PirvateRectangle();
            pr.input_length_and_width();
            pr.Display();
        }
    }
}
