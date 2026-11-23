using System.Drawing;
using System.Globalization;
using System.Security.Cryptography;

namespace GNet38_C_Basics05
{
    internal class Program
    {
      
        static void Main(string[] args)
        {
            #region Question1
            //Add a private string password = "secret"; field to a Book class. Try to print it from Main (outside the class). What happens, and why?
            //Book book = new Book();
            // Console.WriteLine(book.password);
            //private مش هتطبع حاجة لانها 
            #endregion
            #region Questionز2
            //Add an internal int copiesInStock = 5; field to Book. Print it from Main. Does it compile?
            // Why ?
            //Book add = new Book();
            //Console.WriteLine(add.copieslnStock);
            //هيشتغل لانه intenal داخل المشروع 
            #endregion
            #region Question3
            //Add a public string Title; field to Book. Set it and print it from Main.
            //Book title = new Book();
            // title.Title = "khaled";
            // Console.WriteLine(title.Title);

            #endregion
            #region Question4
            //Declare an enum Genre { Fiction, NonFiction, Science }. Add a Genre property to Book,
            //assign it Genre.Science, and print it.
            // Book hh = new Book();
            // Genre grad01 = Genre.Science;

            //Console.WriteLine(Genre.Science);
            #endregion
            #region Question5
            //Using the Genre enum above, print the underlying int value of
            //Genre.Fiction, Genre.NonFiction, and Genre.Science by casting each to int.
            //Genre grad01 = Genre.Fiction;
            //Console.WriteLine((int)grad01);
            //Genre grad02 = Genre.NonFiction;
            //Console.WriteLine((int)grad02);
            //Genre grad03 = Genre.Science;
            //Console.WriteLine((int)grad03);
            #endregion
            #region Question6
            //Given int genreNumber = 1;, cast it into a Genre value and print the result.
            // Genre genreNumber = (Genre)1;
            //Console.WriteLine(genreNumber.ToString());
            #endregion
            #region Question7
            //Given Genre genre = Genre.Fiction;, convert it into a string using ToString() and print it.
            // Genre genreNumber = Genre.Fiction;
            //Console.WriteLine(genreNumber.ToString());
            #endregion
            #region Question8
            //Given string genreText = "Science";, convert it into a Genre value using Enum.Parse() and
            // print the result.
            string genreText = "Science";

            Genre genre = (Genre)Enum.Parse(typeof(Genre), genreText);

            Console.WriteLine(genre);
            #endregion
            #region Question9
            // string genreText = "Science"; Genre genre = (Genre)Enum.Parse(typeof(Genre), genreText);
            //string genreText2 = "Mystery";

            //bool success = Enum.TryParse(genreText2, out Genre result);

            //if (success)
            //{
            //    Console.WriteLine(result);
            //}
            //else
            //{
            //    Console.WriteLine("Unknown genre");
            //}
            
            #endregion
            

        }
    }
}
