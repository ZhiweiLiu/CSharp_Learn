using System;

//类的继承
namespace InheritanceApplication
{
    //基类是shape
    class Shape
    {
        //具有两个属性长和宽，两个方法用于设置长宽
        public void setWidth(int w)
        {
            width = w;
        }
        public void setHeight(int h)
        {
            height = h;
        }
        protected int width;
        protected int height;
    }

    // 派生类Rectangle，继承自shape类，添加了一个方法getArea（）
    class Rectangle : Shape
    {
        public int getArea()
        {
            return (width * height);
        }
    }

    class RectangleTester
    {
        static void Main(string[] args)
        {
            Rectangle Rect = new Rectangle();

            Rect.setWidth(5);
            Rect.setHeight(7);

            // 打印对象的面积
            Console.WriteLine("总面积： {0}", Rect.getArea());
            Console.ReadKey();
        }
    }
}