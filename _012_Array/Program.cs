using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_Array
{
    class Program
    {
        //将数组和数组长度作为参数，返回平均值
        double getAverage(int[] arr,int size)
        {
            int i;
            double avg;
            int sum = 0;

            for (i = 0; i < size; i++)
            {
                sum += arr[i];
            }
            avg = (double) sum / size;
            return avg;

        }

        //可变长度的数组作为参数
        public int AddElement(params int[] arr)
        {
            int sum = 0;
            foreach (int i in arr)
            {
                sum += i;

            }
            return sum;

        }

        static void Main(string[] args)
        {
            int[] n= new int[10];
            int i, j;

            //初始数组n中的元素
            for (i = 0; i < 10; i++)
            {
                n[i] = i + 100;
            }

            //输出数组中每个元素的值
            for (j = 0; j < 10; j++)
            {
                Console.WriteLine("Element[{0}]={1}", j, n[j]);
            }

            //foreach循环
            foreach (int item in n)
            {
                int m = item - 100;
                Console.WriteLine("Foreach循环中Element[{0}]={1}", m, item);
            }

            //多维数组

            int[,] a= new int[5, 2] { { 0, 0 }, { 1, 2 }, { 2, 4 }, { 3, 6 }, { 4, 8 } };
            int x, y;
            // 输出每个元素的值

            for (x = 0; x < 5; x++)
            {
                for (y = 0; y < 2; y++)
                {
                    Console.WriteLine("Element[{0},{1}]={2}", x, y, a[x, y]);
                }
            }

            //传递数组给函数
            Program pro = new Program();
            int[] blance = new int[] { 1000, 2, 3, 17, 50 };
            double avg;
            avg = pro.getAverage(blance, blance.Length);

            Console.WriteLine("平均值是{0}", avg);

            Program paramarray = new Program();
            int[] paraarr = { 512, 720, 250, 567, 889 };
            int sum = paramarray.AddElement(paraarr);
            Console.WriteLine("数组paraarr的总合是{0}", sum);

            /*Array类的一些方法
             * 1. Clear 根据元素的类型，设置数组中某个范围的元素为0，为false或者为null
             * 2. Copy(Array,Array,int32) 从数组的第一个元素开始复制某个范围的元素到另一个数组的第一个元素位置，长度有32位整数指定
             * 3. CopyTo(Array,int32) 从当前的一维数组中复制所有的元素到另一个指定的一维数组的指定索引位置。索引由一个32位整数指定
             * 4. GetLength 获取一个32位整数，该值表示指定维度的数组中的元素总数
             * 5. GetLongLength 获取一个64位整数，该值表示制定维度的数组中的元素综合
             * 6. GetLowerBound 获取数组中指定维度的下界
             * 7. GetType 获取当前实例的类型，从对象（Object）继承
             * 8. GetUpperBound 获取数组中指定维度的上界
             * 9. GetValue（int32） 获取一维数组中指定位置的值。索引由一个32位的整型数指定
             * 10. IndexOf(Array,Object) 搜索指定的对象，返回整个一维数组中第一次出现的索引
             * 11. Reverse（Array） 逆转一维数组中的所有元素的顺序
             * 12. SetValue(Object,int32) 给一维数组中制定位置的元素设置值。索引由一个32位整数指定。
             * 13. Sort(Array) 使用数组中的每个元素的IComparable实现来排序整个一维数组中的元素
             * 14. ToString 返回一个表示当前对象的字符串，从Object继承
            */

            int[] list = { 1, 2, 3, 4, 5, 6, 7,8,9 };
            int[] temp = list;
            int[] temp1 =new int[6];
            // 打印原始数组
            foreach (int num in list)
            {
                Console.Write(num + " ");
            }

            // Clear方法
            Array.Clear(temp, 2, 5);
            Console.WriteLine("Clear后的temp数组是");
            foreach (int item in temp)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //Copy方法
            Array.Copy(temp, temp1, 6);
            Console.Write("Copy后的temp1数组是");
            foreach (int item in temp1)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //CopyTo方法
            temp1.CopyTo(temp, 2);
            Console.Write("CopyTo后的temp数组是");
            foreach (int item in temp)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            //GetLength方法
            Console.WriteLine(temp.GetLength(0));

            //GetLowerBound和GetUpperBound方法
            Console.WriteLine(temp.GetLowerBound(0));
            Console.WriteLine(temp.GetUpperBound(0));


            //GetType方法
            Console.WriteLine(temp.GetType());

            //GetValue方法
            Console.WriteLine(temp.GetValue(1));

            //IndexOf方法
            Console.WriteLine(Array.IndexOf(temp, 2));

            //Reverse方法
            Console.WriteLine("Reverse方法");
            foreach (int item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            //Reverse方法返回的是一个序列（可以理解为python中的可迭代对象），而不是一个数组，所以原数组并不会被改变
            int[] reversed = list.Reverse().ToArray();
            foreach (int item in reversed)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("reverse结束");
            //SetValue方法
            Console.WriteLine("SetValue之前的list");
            foreach (int item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            list.SetValue(3, 1);
            Console.Write("SetValue之后的list");
            foreach (int item in list)
            {
                Console.Write(item + " ");
            }

            //Sort方法
            Array.Sort(list);
            Console.WriteLine("Sort后的list");
            foreach (int item in list)
            {
                Console.Write(item + " ");
            }
            //toString方法
            Console.WriteLine(list.ToString());
        }
    }
}
