
/*
 * 
Maak een klasse Person
Deze heeft een
Name
Birthdate
Address
Telephone
Email
De “name” moet verplicht gezet worden in de constructor. Alle andere waarden moet door middel van full properties aangepast worden. Birthdate moet door middel van een string ingevoerd worden in het formaat: dd-mm-yyyy
Druk door middel van het gebruik van de ToString() methode alle gegevens af.
 */
namespace opdracht4_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
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
}
