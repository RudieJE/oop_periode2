
/* 
 
Oefening 4_9
Vervolg op oefening 4_8 (kopieer de code in een nieuw project)
Haal het jaartal uit de geboortedatum. Zet deze om in Integer en maak een methode int GetAge().
Zorg dat ook de leeftijd afgedrukt wordt met de methode ToString()
 */
namespace opdracht4_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }


    }

    public class Person
    {
        private string name;
        private DateTime birthdate;
        private string address;
        private string telephone;
        private string email;
        public Person(string name)
        {
            this.name = name;
        }
        public DateTime Birthdate
        {
            get { return birthdate; }
            set { birthdate = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string Telephone
        {
            get { return telephone; }
            set { telephone = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public override string ToString()
        {
            return $"Name: {name}, Birthdate: {birthdate.ToShortDateString()}, Address: {address}, Telephone: {telephone}, Email: {email}";
        }
    }
}
