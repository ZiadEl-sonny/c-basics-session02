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

            Book book = new Book();
          
            Console.WriteLine(book);

            #endregion

        }
    }
}
