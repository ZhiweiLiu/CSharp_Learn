using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_Method
{
    class NumberManipulator
    {
        // Access Specifier：访问修饰符，这个决定了变量或方法对于另一个类的可见性。
        // Return type：返回类型，一个方法可以返回一个值。返回类型是方法返回的值的数据类型。如果方法不返回任何值，则返回类型为 void。
        // Method name：方法名称，是一个唯一的标识符，且是大小写敏感的。它不能与类中声明的其他标识符相同。
        // Parameter list：参数列表，使用圆括号括起来，该参数是用来传递和接收方法的数据。参数列表是指方法的参数类型、顺序和数量。参数是可选的，也就是说，一个方法可能不包含参数。
        // Method body：方法主体，包含了完成任务所需的指令集。
        public int FindMax(int num1, int num2)
        {
            int result;
            if (num1>num2)
            {
                result = num1;
            }
            else
            {
                result = num2;
            }
            return result;
        }

        //递归调用，计算阶乘
        public int factorial(int num)
        {
            int result;
            if (num==1)
            {
                result = 1;
            }
            else
            {
                result = factorial(num - 1)*num;
            }

            return result;
        }

        //用值传递参数,是参数传递的默认方式，会在内存中重新创建一个位置用于存储参数，此种情况下方法内部的形参的变化不会导致实参的改变
        public void swap(int a, int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;

        }

        //按引用传递，会改变实参，在参数前加ref
        public void swap2(ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
        }

        //按输出传递参数，return用于在从函数中返回一个值，用输出参数可以将return返回的值赋给参数
        public int getValue(out int x)
        {
            //在方法内部需要对参数进行赋值才可以离开
            int temp = 1;
            x = temp;
            //这里测试一下参数最后到底是赋值的结果还是return的结果
            return 3;
        }

        // 可以用类的实例在另外一个类中调用其他类的方法
        class Test
        {
            static void Main(string[] args)
            {
                int a = 100;
                int b = 200;
                int m = 5;

                NumberManipulator n = new NumberManipulator();
                Console.WriteLine("a和b中较大的值为{0}", n.FindMax(a, b));
                Console.WriteLine("{0}的阶乘{1}", m, n.factorial(m));
                
                //使用swap方法交换a、b的值，实际上只是在方法内部又复制了一个a、b进行交换
                //并不影响a、b实际上的值
                n.swap(a, b);

                Console.WriteLine("执行交换方法swap后a的值{0}", a);
                Console.WriteLine("执行交换方法swap后b的值{0}", b);

                n.swap2(ref a, ref b);
                Console.WriteLine("执行交换方法swap2后a的值{0}", a);
                Console.WriteLine("执行交换方法swap2后b的值{0}", b);

                //输出参数的测试
                n.getValue(out a);
                Console.WriteLine("输出参数的测试结果，看a变成啥了{0}", a);
                //输出结果是a=1了，所以输出参数输出的不是方法的返回值，而是在方法中给参数附的值
           }
        }
    }
}
