using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013_String
{
    class Program
    {
        static void Main(string[] args)
        {
            //字符串，字符串连接
            string fname, lname;
            fname = "Rowan";
            lname = "Atkinson";

            string fullname = fname + lname;
            Console.WriteLine("Full name: {0}", fullname);

            // 通过使用string构造函数
            char[] letters = { 'H', 'e', 'l', 'l', 'o' };
            string greeting = new string(letters);
            Console.WriteLine("Greeting:{0}", greeting);

            //方法返回字符串
            string[] sarray = { "Hello", "From", "Tutorials", "Point" };
            string message = String.Join("", sarray);
            Console.WriteLine("Message:{0}", message);

            //用于转化值的格式化方法
            DateTime waiting = new DateTime(2012, 10, 10, 17, 58, 1);
            string chat = String.Format("Message sent at {0:t} on {0:D}",waiting);
            Console.WriteLine("Message :{0}", chat);

            //1. compare(string strA,string strB， bool ignoreCase) 比较两个指定的string对象，并返回一个表示他们在排列顺序中相对位置的整数
            //如果ignoreCase参数为真时，该方法不区分大小写
            //比较结果：strA在strB之前，结果为负；strA在strB之后，结果为正；两个字符串相同，记过为0

            string strA = "This is test";
            string strB = "This is text";
            string strC = "THIS IS TEST";

            int compare_result = String.Compare(strA, strB);
            Console.WriteLine("strA和strB比较的结果是：{0}", compare_result);
            Console.WriteLine("strA和strC比较的结果是：{0}", String.Compare(strA, strC));
            Console.WriteLine("strA和strC忽略大小写后比较的结果是:{0}", String.Compare(strA, strC, true));

            //2. Concat（str strA, str strB, str strC, str strD） 连接多个字符串,虽然教程上写的是4个但实际可以连接更多，下面例子连接了5个字符串
            Console.WriteLine(String.Concat(fname, lname, strA, strB, strC));

            //3. Contains(string value) 返回一个指定string对象是否出现在字符串中的值，需要区分大小写
            bool contains_result = strA.Contains("This");
            Console.WriteLine("Contains返回值，strA中存在this吗？：{0}", contains_result);

            //4. Copy(string str) 创建一个与指定字符串有相同值的新的string对象
            string strD = String.Copy(strC);
            Console.WriteLine("从strC复制过来一个新的字符串strD：{0}", strD);

            //5. CopyTo( int sourceIndex, char[] destination, int destinationIndex, int count )
            //从 string 对象的指定位置开始复制指定数量的字符到 Unicode 字符数组中的指定位置
            char[] CopyTo_chars = new char[12];
            strA.CopyTo(0, CopyTo_chars, 0, 12);
            foreach (char item in CopyTo_chars) 
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            //6. EndsWith( string value ) 判断 string 对象的结尾是否匹配指定的字符串
            // 还有个StartWith，一样的逻辑
            bool EndsWith_result = strA.EndsWith("test");
            Console.WriteLine("判断strA是否以test结尾，结果：{0}", EndsWith_result);

            //7. Equals( string value ) 判断当前的 string 对象是否与指定的 string 对象具有相同的值
            //Equals(string a, string b) 判断两个指定的 string 对象是否具有相同的值
            //这里是判断值是否相等，而不是判断两个string是否相同，跟stra==strb是不一样的
            //神奇的事情发生了，strC==strD返回的值竟然是true
            bool Equals_result1 = strA.Equals("this is test");
            bool Equals_result2 = String.Equals(strC, strD);

            Console.WriteLine("判断strA的值是否等于this is test，结果是：{0}", Equals_result1);
            Console.WriteLine("判断strC和strD的值是否相等，结果是：{0}", Equals_result2);
            Console.WriteLine("判断strC是否等于strD，结果是:{0}", strC == strD);
            //我重新定义一个值跟strC相同的字符串，这次不用copy来赋值看两个string是否相同
            string strE = "THIS IS TEST";
            Console.WriteLine("判断strC是否等于strE，结果是:{0}", strC == strE);
            //返回的结果竟然也是true，说明在C#中 ==表示的是两个变量的值是否相同，而不是指两个变量是否指向同一个内存位置.


            //8. Format(string format, Object arg0) 把指定字符串中一个或多个格式项替换为指定对象的字符串表示形式
            string strF = String.Format("现在是{0:t} on {0:d}", DateTime.Now);
            Console.WriteLine(strF);

            //9. public int IndexOf( string value, int startIndex ) 
            //返回指定字符串从该实例中指定字符位置开始搜索第一次出现的索引，索引从 0 开始。
            //第一个参数string类型可以改为char类型，表示字符在该字符串中第一次出现的索引
            //第二个参数startindex可以不写，默认从0开始
            int IndexOf_result = strA.IndexOf("is",10);
            int IndexOf_result1 = strA.IndexOf("is");
            //从索引位置10开始查找，没找到is
            Console.WriteLine("is 在strA中首次出现的索引，从10开始，结果为：{0}", IndexOf_result);
            //从头开始查找，找到了is
            Console.WriteLine("is 在strA中首次出现的索引，从0开始，结果为：{0}", IndexOf_result1);



            //10. public int IndexOfAny(char[] anyOf, int startIndex)
            //返回某一个指定的 Unicode 字符数组中任意字符从该实例中指定字符位置开始搜索第一次出现的索引，索引从 0 开始
            char[] IndexOfAny_char = { 'i', 's', 'a', 'b' };
            //结果是2，因为从第2个字符开始算，‘i’出现在了strA的第3个
            Console.WriteLine("IndexOfAny_char中的任意字符在strA中首次出现的索引：{0}", strA.IndexOfAny(IndexOfAny_char, 1));


            //11. public string Insert( int startIndex, string value ) 
            //返回一个新的字符串，其中，指定的字符串被插入在当前 string 对象的指定索引位置
            string strG = strA.Insert(1,"now ");
            Console.WriteLine("在strA前面插入now,结果是:{0}", strG);

            //12. public static bool IsNullOrEmpty(string value)
            //指示指定的字符串是否为 null 或者是否为一个空的字符串
            string strH = null;
            Console.WriteLine("strH是否是空字符串：{0}", String.IsNullOrEmpty(strH));

            //13. public static string Join( string separator, string[] value, int startIndex, int count ) 
            //连接接一个字符串数组中的指定位置开始的指定元素，使用指定的分隔符分隔每个元素。其中startindex和count是默认参数，可以不写
            string str1 = String.Join(" ", sarray);
            Console.WriteLine("用空格连接sarray中的每个字符串：{0}", str1);

            string str2 = String.Join(" ", sarray, 1, 2);
            Console.WriteLine("用空格连接sarray中索引1开始，后面3个字符串：{0}", str2);

            //14. public int LastIndexOf( char value ) 参数也可以是string类型
            //返回指定 Unicode 字符在当前 string 对象中最后一次出现的索引位置，索引从 0 开始
            Console.WriteLine("s在strA中最后出现的索引位置：{0}", strA.LastIndexOf('s'));

            //15. public string Remove( int startIndex, int count ) 
            // 从当前字符串的指定位置开始移除指定数量的字符，并返回字符串;如果不写count则表示删除索引之后所有的字符
            Console.WriteLine("删除strA的第2到5个字符：{0}", strA.Remove(1, 4));

            //16. public string Replace( string oldValue, string newValue ) 
            //把当前 string 对象中，所有指定的字符串替换为另一个指定的字符串，并返回新的字符串
            //参数也可以使用char类型
            //先看下上面以方法是否改变的strA本身，还是重新定义一个新的变量
            Console.WriteLine("看看strA删除字符后，本身是否发生变化：{0}", strA);
            //说明用Remove方法，是返回了一个新的变量，原来的变量不变
            //将strA中所有的i换成a
            Console.WriteLine("将strA中所有的i换成a:{0}", strA.Replace('i', 'a'));

            //17. public string[] Split( char[] separator, int count ) 
            //返回一个字符串数组，包含当前的 string 对象中的子字符串，
            //子字符串是使用指定的 Unicode 字符数组中的元素进行分隔的。int 参数指定要返回的子字符串的最大数目。
            Console.WriteLine("用空格分割strA：{0}，{1}", strA.Split(' '),1);
            //发现一个有趣的事，当使用格式化字符串时，如果参数是一个数组，那么格式符号｛0｝中的0代表数组参数的索引
            //如果参数是不同类型的多个参数，那么要求格式符号的数量跟参数的数量相同，否则会报错
            //如上例所示，｛0｝打印出来的结果不是string数组中某个元素，而是该数组的类型

            //18. public char[] ToCharArray( int startIndex, int length ) 
            //返回一个带有当前 string 对象中所有字符的 Unicode 字符数组，从指定的索引开始，直到指定的长度为止。
            char[] ToCharArray_strA = strA.ToCharArray(1, 5);
            foreach (char item in ToCharArray_strA)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            //19. public string ToLower()
            // 把字符串转换为小写并返回。
            //public string ToUpper()
            //把字符串转换为大写并返回。
            Console.WriteLine("strD全部转化为小写后：{0}", strD.ToLower());
            Console.WriteLine("fullname全部转化为大写后：{0}", fullname.ToUpper());


            //20. public string Trim()
            //移除当前 String 对象中的所有前导空白字符和后置空白字符
            string str3 = "         this is test              ";
            Console.WriteLine("str3去掉所有的空白符：{0}", str3.Trim());
        }
    }
}
