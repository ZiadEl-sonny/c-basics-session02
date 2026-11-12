using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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
            //Book book = new Book();

            //Console.WriteLine(book.ToString());
            //Console.WriteLine(book.Equals(book));
            //Console.WriteLine(book.GetHashCode());
            //Console.WriteLine(book.GetType());

            #endregion

            #region Question 3

            //Write code that divides 10 by 0 inside a try block, catches the exception, prints "Cannot
            // divide by zero", and then prints "Done" in a finally block.

            //try
            //{
            //    int num1 = 0;
            //    int num2 = 10 / num1;
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("Cannot divide by Zero");
            //    Console.WriteLine(ex.Message);

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Cannot divide by Zero");
            //    Console.WriteLine(ex.Message);
            //}
            //finally { Console.WriteLine("Done"); }


            #endregion

            #region Question 4
            //Declare an int pages = 300; then store it in a double variable without using a cast.

            //int pages = 300;
            //double copyPages = pages;


            #endregion

            #region Question 5

            //Declare a double price = 49.99; then convert it into an int using a cast.


         
            double price = 49.99;
            int copyPrice = (int)price;
            Console.WriteLine(copyPrice);



            #endregion


        }
    }
}
