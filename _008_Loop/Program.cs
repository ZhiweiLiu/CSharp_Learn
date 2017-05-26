using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            //使用while进行循环
            int i = 1;
            int j = 1;
            while (i<10)
            {
                
                Console.WriteLine("这是第{0}次循环，i={1}", i,i);
                i++;
            }

            //使用do while进行循环
            do
            {
                if (j == 6)
                {
                    j += 1;
                    break;
                }
                Console.WriteLine("这是dowhile的第{0}次", j);
                j++;

            } while (j<10);

            Console.WriteLine("为了看下continue的效果");

            //for循环
            for (int m = 1; m <= 100; m++)
            {
                if (m%2==0)
                {
                    Console.WriteLine(m);
                }
               
            }

        }
    }
}
