using Assignment_1.Classes;

namespace Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Q01
            object book = new Book { Title = "Ay haga", Pages = 5 };
            Console.WriteLine(book);

            // Q02
            Console.WriteLine($"ToString: {book.ToString()}");
            Console.WriteLine($"Equals: {book.Equals(book)}");
            Console.WriteLine($"GetHashCode: {book.GetHashCode()}");
            Console.WriteLine($"GetType: {book.GetType()}");

            // Q03 - compile-time error
            //int pages = "464";

            int pages = 464;
            Console.WriteLine(pages);

            // Q04
            try
            {
                int divisor = 0;
                int result = 10 / divisor;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            finally
            {
                Console.WriteLine("Done");
            }

            // Q05
            int pages1 = 300;
            double pages1Double = pages1;
            Console.WriteLine(pages1Double);

            // Q06
            double price = 49.99;
            int price1 = (int)price;
            Console.WriteLine(price1);

            // Q07
            string pagesText = "464";
            int convertedPages = Convert.ToInt32(pagesText);
            Console.WriteLine(convertedPages);

            // Q08
            string yearText = "2023";
            int year = int.Parse(yearText);
            Console.WriteLine(year);

            string badText = "abc";
            int number;

            if (int.TryParse(badText, out number))
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("Invalid number");
            }

            // Q09
            int pages2 = 464;
            string pages2str = pages2.ToString();
            Console.WriteLine(pages2str);
            Console.WriteLine(pages2str.GetType());

            // Q10
            int copies = 100;
            object boxedCopies = copies;
            int unboxedCopies = (int)boxedCopies;
            Console.WriteLine(boxedCopies);
            Console.WriteLine(unboxedCopies);
        }
    }
}
