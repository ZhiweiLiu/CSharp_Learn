using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_packaging
{
    public class PirvateRectangle
    {
        private double length;
        private double width;

        public void input_length_and_width()
        {
            Console.WriteLine("请输入length");
            length = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("请输入width");
            width = Convert.ToDouble(Console.ReadLine());
        }

        public double GetArea()
        {
            return length * width;
        }

        public void Display()
        {
            Console.WriteLine("长度{0}", length);
            Console.WriteLine("宽度{0}", width);
            Console.WriteLine("面积{0}", GetArea());

        }
    }
}
