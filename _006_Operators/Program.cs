using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 21;
            int b = 10;
            int c;

            c = a + b;
            Console.WriteLine("line1--c的值为{0}", c);
            c = a - b;
            Console.WriteLine("line2--c的值为{0}", c);
            c = a * b;
            Console.WriteLine("line3--c的值为{0}", c);
            c = a / b;
            Console.WriteLine("line4--c的值为{0}", c);
            c = a % b;
            Console.WriteLine("line5--c的值为{0}", c);

            //先自增，再赋值
            c = ++a;
            Console.WriteLine("line6--c的值为{0}", c);

            //先赋值，再自增
            c = a++;
            Console.WriteLine("line7--c的值为{0}", c);
            Console.WriteLine("line8--a的值为{0}", a);

            Console.WriteLine("--------------------------------------");
            //关系运算符==，！=，>,<,>=,<=
            if (a==b)
            {
                Console.WriteLine("line1-- a等于b");
            }
            else
            {
                Console.WriteLine("line1--a不等于b");
            }

            if (a<b)
            {
                Console.WriteLine("lin2-- a小于b");
            }
            else
            {
                Console.WriteLine("line2--a不小于b");
            }

            if (a>b)
            {
                Console.WriteLine("line3--a大于b");
            }
            else
            {
                Console.WriteLine("line3--a不大于b");
            }

            Console.WriteLine("---------------------");
            Console.WriteLine();

            // 逻辑运算符&& || ！

            /* 位运算符& | ^ ~<<  >>
                是对二进制数进行计算的方式，可以按照bool值的逻辑运算来理解
                &表示且，只有两个都为1时，返回1；
                |表示或，两个只要有一个为1，返回1；
                ~表示翻转，将1变成0，0变成1；
                ^表示两个值是否相同，两个一样的时候返回0，不一样的时候返回1
                <<2左移运算符，将2进制左移位，最后两位用00补齐
                >>2右移运算符，将2进制右移两位，前两位用00补齐
            */

            int A = 60;
            int B = 13;
            int C = 0;

            Console.WriteLine("A的值为{0}",Convert.ToString(A, 2));
            Console.WriteLine("B的值为{0}",Convert.ToString(B, 2));

            //A和B进行&运算 
            C = A & B;
            Console.WriteLine("C的值为A&B={0}",C);
            Console.WriteLine("C的二进制数为{0}", Convert.ToString(C, 2));

            //A和B进行|运算
            C = A | B;
            Console.WriteLine("C={0}",C);
            Console.WriteLine("C的二进制数为{0}", Convert.ToString(C, 2));

            C = A ^ B;
            Console.WriteLine(C);

            C = ~A;
            Console.WriteLine(C);

            C = A << 2;
            Console.WriteLine(C);

            C = A >> 2;
            Console.WriteLine(C);


            //赋值运算符
            int x = 21;
            int z;

            // 赋值运算符=，z=21了
            z = x;
            Console.WriteLine("line1-- = z的值={0}", z);

            //赋值运算符+=；z=z+x所以z=42了
            z += x;
            Console.WriteLine("line2-- += z的值={0}", z);

            //赋值运算符-=,z=42
            z -= x;
            //z = z-x ;so  z=42-21=21
            Console.WriteLine("line3-- -= z={0}", z);

            //赋值运算符*=;z=21*21
            z *= x;
            Console.WriteLine("line4-- *= z = {0}", z);

            //赋值运算符/=
            z /= x;
            Console.WriteLine("line5 -- /=z ={0}", z);

            //赋值运算符%=
            z = 200;
            z %= x;
            Console.WriteLine("line6 -- %=z ={0}", z);

            //赋值运算符，轮到位运算符了           
            Console.WriteLine(Convert.ToString(z, 2));
            Console.WriteLine(Convert.ToString(x, 2));
            z &= x;
            Console.WriteLine("line7 -- &= z = {0}", Convert.ToString(z,2));

            //其他运算符,sizeof返回数据类型的大小
            Console.WriteLine("-------------------");
            Console.WriteLine("int的大小是{0}", sizeof(int));
            Console.WriteLine("short的大小是{0}", sizeof(short));
            Console.WriteLine("double的大小是{0}", sizeof(double));

            //typeof,返回class的类型

            //三元运算符的实例
            int numa, numb;
            numa = 10;
            //当a=1成立时，b=20，否则b=30；
            numb = (numa == 1) ? 20:30;
            Console.WriteLine("b的值是{0}",numb);


        }
    }
}
