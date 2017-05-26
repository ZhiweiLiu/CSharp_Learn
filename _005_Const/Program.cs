using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Const
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.1415926;
            double r;
            Console.WriteLine("please enter radius");
            r = Convert.ToInt32(Console.ReadLine());
            double areaCircle = pi * r * r;
            Console.WriteLine("radius{0}, area{1}", r, areaCircle);
            Console.ReadLine();
        }
    }
}
