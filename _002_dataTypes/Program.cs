using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_dataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //布尔类型
            bool b = false;
            //byte类型，范围是0~255
            byte x = 0;
            //sbyte类型，范围是-128~127
            sbyte sbyte_num = 0;
            //char类型，范围是16位的unicode字符
            char s = '\0';
            //decimal类型，128位精确的10进制数据，28-29 有效位数，(-7.9 x 1028 到 7.9 x 1028) / 100 到 28
            decimal bignum = 0.0M;
            //double类型，64位双精度浮点型,(+/ -)5.0 x 10 - 324 到(+/ -)1.7 x 10308
            double double_num = 0.0D;
            //float类型，32位单精度浮点型，-3.4 x 1038 到 + 3.4 x 1038
            float float_num = 0.0f;
            //int,32位有符号整型数，-2,147,483,648 到 2,147,483,647
            int int_num = 0;
            //uint,32位无符号整型数，0 到 4,294,967,295
            uint uint_num = 0;
            //long,64位有符号整型数，-923,372,036,854,775,808 到 9,223,372,036,854,775,807
            long long_num = 0L;
            //ulong,64位无符号整型数，0 到 18,446,744,073,709,551,615
            ulong ulong_num = 0;
            //short,16位有符号整型数，-32,768 到 32,767
            short short_num = 0;
            //ushort,16位无符号整型数，0~65535
            ushort ushort_num = 0;


            //表达式 sizeof(type) 产生以字节为单位存储对象或类型的存储尺寸
            Console.WriteLine("Size of int:{0}", sizeof(int));

            /*引用类型（Reference types）
             * 引用类型不包含存储在变量中的实际数据，但是包含对变量的引用
             * 就是表示内存位置
             * 内置的引用类型有：object，dynamic和string
            */

            /*object是所有数据类型的基类
             * 当一个值类型转换为object类型时，叫装箱；当一个object类型转换为值类型时，叫拆箱
             */
            object obj;
            obj = int_num;
            int int_num2 = (int)obj;
            Console.WriteLine("int_num2 = {0}", int_num2);

            //Dynamic类型，动态变量
            dynamic d = 20;

            //string类型
            string str = "runoob.com";
            //前面加@的字符串会将转义字符比如\当作普通字符对待
            string str1 = @"C:\Windows";


            //指针类型



        }
    }
}
