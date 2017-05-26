using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //变量的定义
            short a;
            int b;
            double c;

            //变量的初始化
            a = 10;
            b = 322;
            c = a + b;

            Console.WriteLine("a + b = {0}", c);

            //接受用户的输入并存储为变量
            int num;
            num = int.Parse(Console.ReadLine());

            Console.WriteLine(num);
        }
    }
}
