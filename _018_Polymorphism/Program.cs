using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 多态性
// 分为静态多态性和动态多态性
// 静态多态性通过函数重载和运算符重载来实现
// 动态多态性则通过抽象类和虚方法来实现，这里只实现函数重载和抽象类
// 重载（override）可以理解为在一个类中写多个相同的方法，只是这些相同名称的方法参数的类型或者数量不同，那么在调用这些方法时会自动根据传入的参数来调用不同的方法
// 抽象类（abstract）是一个专门的类，里面只声明方法；具体的实现是通过一个继承该抽象类的子类来实现的，跟接口的实现类似,
// 虚方法（virtual）则是在父类中生命一个方法，在其子类中进行实现，关键子virtual
namespace _018_Polymorphism
{
    //通过函数重载实现静态多态性，函数的定义必须彼此不同，可以是参数列表中的参数类型不同，也可以是参数个数不同
    class printdata
    {
        public void print(int i)
        {
            Console.WriteLine("Printing int: {0}", i);
        }

        public void print(double f)
        {
            Console.WriteLine("Printing float: {0}", f);
        }

        public void print(string s)
        {
            Console.WriteLine("Printing string: {0}", s);
        }
    }

    //C# 允许您使用关键字 abstract 创建抽象类，用于提供接口的部分类的实现
    abstract class Shape
    {
        public abstract int area();
    }

    class Rectangle: Shape
    {
        private int length;
        private int width;

        public Rectangle(int a=0,int b=0)
        {
            length = a;
            width = b;
        }

        public override int area()
        {
            Console.WriteLine("Rectangle类的面积：");
            return length * width;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            printdata print_1 = new printdata();
            print_1.print(100);
            print_1.print(123.45);
            print_1.print("lalalalalallala");

            Rectangle rect = new Rectangle(10,7);
            int a = rect.area();
            Console.WriteLine("rect的面积是：{0}", a);

        }
    }
}

