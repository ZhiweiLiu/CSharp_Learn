using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_Condition
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            int b = 200;
            int c = 30;

            if (a>=100)
            {
                Console.WriteLine("a>=100条件成立了"); 
                if (b==100)
                {
                    Console.WriteLine("b=100条件也成立了");
                }
                else
                {
                    Console.WriteLine("a>=100并且b!=100");
                }
            }

            switch (a)
            {
                case 10:
                    {
                        Console.WriteLine("这里是用switch语句输出的的内容，当a==10时");
                        break;
                    }
                case 20:
                    {
                        Console.WriteLine("这里是用switch输出的内容，当a==20时");
                        break;
                    }
                default:
                    Console.WriteLine("没有满足条件的值，走到了default上");
                    break;
            }
        }
    }
}
