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



            //double price = 49.99;
            //int copyPrice = (int)price;
            //Console.WriteLine(copyPrice);



            #endregion

            #region Question 6


            //Given string pagesText = "464";, convert it into an int using the Convert class.


            //string pagesText = "464";
            //int pages = Convert.ToInt32(pagesText);
            //Console.WriteLine(pages.GetType());


            #endregion

            #region Question 7


            //Given string yearText = "2023";, convert it using int.Parse(). Then given string badText =
            // "abc";, use int.TryParse() to safely try converting it, and print "Invalid number" if it fails.


            //string yearText = "2026";
            //int year = int.Parse(yearText);
            //Console.WriteLine(year.GetType());

            //string badText = "abc";

            //bool res = int.TryParse(badText, out int num);
            //Console.WriteLine(res ? $"{num}" : "Invalid Number");

            #endregion

            #region  Question 8

            //Given int pages = 464;, convert it into a string using ToString() and print its type using
            //GetType() to prove it's now a string.

            //int pages = 464;
            //string pages2 = pages.ToString();
            //Console.WriteLine(pages2.GetType());

            #endregion

            #region Question 9
            //Declare int copies = 100;. Box it into an object variable, then unbox it back into a new int
            //variable, and print both.


            //int copies = 300;
            //object copiesOBJ = copies;
            //int unboxedCopies = (int)copiesOBJ;
            //Console.WriteLine(unboxedCopies.GetType());
            //Console.WriteLine(copiesOBJ.GetType());


            #endregion

            #region Question 10


            //Declare an int? year = null;. Print whether it has a value, then assign it 2023 and print its
            //value.

            //int? Year = null;
            //Console.WriteLine(Year.HasValue);

            //Year = 2026;
            //Console.WriteLine(Year.Value);

            #endregion

            #region Question 11

            //Declare a string? reviewer = null;. Print whether it is null.

            string? reviewer = null;
            Console.WriteLine(reviewer == null);

            #endregion

        }
    }
}
