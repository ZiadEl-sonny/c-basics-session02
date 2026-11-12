using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace c_basics_session02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            //Create a Book class with a Title (string) and Pages (int). Create a Book object and store it
            //in a variable of type object.Print it.

            //Book book = new Book();

            //Console.WriteLine(book);

            #endregion

            #region Question 2
            //Using the Book class above, print the result of calling ToString(), Equals() (compare book
            //with itself), GetHashCode(), and GetType() on book.
            Book book = new Book();

            Console.WriteLine(book.ToString());
            Console.WriteLine(book.Equals(book));
            Console.WriteLine(book.GetHashCode());
            Console.WriteLine(book.GetType());

            #endregion

        }
    }
}
