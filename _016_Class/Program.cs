using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _016_Class
{

    class Child
    {
        private int age;
        private string name;
        public static int id=1001;

        // Default constructor:默认的构造函数
        public Child()
        {
            name = "N/A";
        }
        // 创建一个方法来改变静态变量的值
        public void changeid(int x)
        {
            id = x;
        }

        // Constructor:带参数的构造函数
        public Child(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        // Printing method:方法
        public void PrintChild()
        {
            Console.WriteLine("{0}, {1} years old.", name, age);
        }
    }

    class StringTest
    {
        static void Main()
        {
            // Create objects by using the new operator:
            Child child1 = new Child("Craig", 11);
            Child child2 = new Child("Sally", 10);

            // Create an object using the default constructor:
            Child child3 = new Child();

            // Display results:
            Console.Write("Child #1: ");
            child1.PrintChild();
            Console.Write("Child #2: ");
            child2.PrintChild();
            Console.Write("Child #3: ");
            child3.PrintChild();
            // 静态变量 关键字static  定义的是个常量，无需实例化类即可调用
            Console.WriteLine(Child.id);

            child1.changeid(100);
            // 只能使用类名来调用静态变量，不能使用实例来调用
            // 所以这里如果使用child1.id 就会报错
            Console.WriteLine(Child.id);
            

        }
    }
    /* Output:
        Child #1: Craig, 11 years old.
        Child #2: Sally, 10 years old.
        Child #3: N/A, 0 years old.
    */
}
