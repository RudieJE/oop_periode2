/*
 * 
Oefening 4_10
Maak een klasse Book. Leg hiervan het ISBN nummer vast (constructor), de titel en auteur en aantal bladzijden.
Voor het testen gebruik je de gegevens van het boek Zie Scherp Scherper. (Google de gegevens).
Het is nu overigens tijd om het boek aan te schaffen, als je dat nog niet gedaan hebt!
 */
namespace opdracht_4_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        public class Book
        {
            private string isbn;
            private string title;
            private string author;
            private int numberOfPages;
            public Book(string isbn)
            {
                this.isbn = isbn;
            }
            public string Title
            {
                get { return title; }
                set { title = value; }
            }
            public string Author
            {
                get { return author; }
                set { author = value; }
            }
            public int NumberOfPages
            {
                get { return numberOfPages; }
                set { numberOfPages = value; }
            }
        }
    }
}
