using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            /*类型转换有隐式和显式两种
             * 隐式的转换--比如从小的整数类型转换为大的整数类型
             * 显式转换--需要使用强制转换运算符，而且会造成数据丢失
             */
            double d = 5673.64;
            byte b = 234;
            int i;

            //强制转换double为int
            i = (int)d;
            Console.WriteLine(i);

            //将一个数字的字符串转为整型
            string str = i.ToString();
            int m = Convert.ToInt32(str);
            int n = int.Parse(str);
            Console.WriteLine(m.GetType());
            Console.WriteLine("n的类型是{0}", n.GetType());
        }
    }
}
