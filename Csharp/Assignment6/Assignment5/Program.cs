using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    struct Books 
    {
        private string title;
        private string author;
        private string subject;
        private int book_id;
        public void GetValues(string t,string a,string s,int b)
        {
            title = t;
            author = a;
            subject = s;
            book_id = b;
        }
        public void ShowValues()
        {
            Console.WriteLine("Title : {0}", title);
            Console.WriteLine("Author : {0}", author);
            Console.WriteLine("Subject : {0}", subject);
            Console.WriteLine("Book_id : {0}", book_id);
            Console.Read();
        }
    };
    public class TestStructures
    {
        public static void Main(string[] args)
        {
            Books b1 = new Books();
            b1.GetValues("c programming", "Dennis Ritchie", "c ", 65748);
           
            b1.ShowValues();

        }

    }
    

    
}
