using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015_Enum
{
    class Program
    {
        //枚举列表中的每个符号代表一个整数值，一个比它前面的符号大的整数值。默认情况下，第一个枚举符号的值是 0
        enum Days { Sun, Mon, tue, Wed, thu, Fri, Sat };
        //flags类型的枚举，里面的每个元素都是二进制数，可以按位操作，在此种类型的枚举中可以定义一个变量表示
        [Flags]
        enum Days2
        {
            None = 0x0,
            Sunday = 0x1,
            Monday = 0x2,
            Tuesday = 0x4,
            Wednesday = 0x8,
            Thursday = 0x10,
            Friday = 0x20,
            Saturday = 0x40
        }


        static void Main(string[] args)
        {
            //从 enum 类型到整型的转换需要用显式类型转换来完成
            int WeekdayStart = (int)Days.Mon;
            int WeekdayEnd = (int)Days.Fri;

            Console.WriteLine("Monday: {0}", WeekdayStart);
            Console.WriteLine("Friday: {0}", WeekdayEnd);
            //使用 System.Enum 方法发现和操作枚举值
            //注意，在循环中如果取值是int类型，就返回枚举的值；如果使用var类型，就返回的是枚举的名称
            foreach (var item in Enum.GetValues(typeof(Days)))
            {
                Console.WriteLine(item);
            }

            Days2 meetingDays = Days2.Tuesday | Days2.Thursday;
            // Initialize with two flags using bitwise OR.
            meetingDays = Days2.Tuesday | Days2.Thursday;

            // Set an additional flag using bitwise OR.
            meetingDays = meetingDays | Days2.Friday;

            Console.WriteLine("Meeting days are {0}", meetingDays);
            // Output: Meeting days are Tuesday, Thursday, Friday

            // Remove a flag using bitwise XOR.
            meetingDays = meetingDays ^ Days2.Tuesday;
            Console.WriteLine("Meeting days are {0}", meetingDays);
            // Output: Meeting days are Thursday, Friday

        }
    }
}
