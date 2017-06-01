using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014_Struct
{
    struct Books
    {
        public string title;
        public string author;
        public string subject;
        public int book_id;

        public void getValues(string t,string a,string s,int i)
        {
            title = t;
            author = a;
            subject = s;
            book_id = i;

        }

        public void display()
        {
            Console.WriteLine("Title : {0}", title);
            Console.WriteLine("Author : {0}", author);
            Console.WriteLine("Subject : {0}", subject);
            Console.WriteLine("Book_id :{0}", book_id);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        {
                Books Book1 = new Books();
                Books Book2 = new Books();

                ///* book 1 详述 */
                //Book1.title = "C Programming";
                //Book1.author = "Nuha Ali";
                //Book1.subject = "C Programming Tutorial";
                //Book1.book_id = 6495407;

                ///* book 2 详述 */
                //Book2.title = "Telecom Billing";
                //Book2.author = "Zara Ali";
                //Book2.subject = "Telecom Billing Tutorial";
                //Book2.book_id = 6495700;

                ///* 打印 Book1 信息 */
                //Console.WriteLine("Book 1 title : {0}", Book1.title);
                //Console.WriteLine("Book 1 author : {0}", Book1.author);
                //Console.WriteLine("Book 1 subject : {0}", Book1.subject);
                //Console.WriteLine("Book 1 book_id :{0}", Book1.book_id);

                ///* 打印 Book2 信息 */
                //Console.WriteLine("Book 2 title : {0}", Book2.title);
                //Console.WriteLine("Book 2 author : {0}", Book2.author);
                //Console.WriteLine("Book 2 subject : {0}", Book2.subject);
                //Console.WriteLine("Book 2 book_id : {0}", Book2.book_id);
                Book1.getValues("C Programming", "Nuha Ali", "C Programming Tutorial", 6495407);
                Book2.getValues("Telecom Billing", "Zara Ali", "Telecom Billing Tutorial", 6495700);

                Book1.display();
                Console.WriteLine("----------------");
                Book2.display();
            }

        }
    }
}
