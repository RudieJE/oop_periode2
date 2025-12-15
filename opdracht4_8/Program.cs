/*
 * 
 
Vervolg op oefening 4_7 (kopieer de code in een nieuw project) Maak een controle of het telefoonnummer uit 11 karakters bestaat. Geef een foutmelding als dat niet zo is.
Controleer of in het email-adres een @ zit. Geef een foutmelding als dat niet zo is.
Test deze opties ook in je opstartklasse

ChatGPT said:
In American (U.S.) notation, dates are typically written in Month–Day–Year order.
Standard Formats
MM/DD/YYYY → e.g., 02/17/2025
Month DD, YYYY → e.g., February 17, 2025
Common Variations
M/D/YY → e.g., 2/17/25
Mon. DD, YYYY → e.g., Feb. 17, 2025
Month DD (informal, year implied) → February 17
Key Differences from international style
U.S. starts with month first
(Most of the world uses DD/MM/YYYY or YYYY-MM-DD.)
If you want, I can give examples, convert dates between formats, or explain when each style is used.
 */

using System.Text;

namespace opdracht4_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person WallohBaba = new Person("WallohBaba");
            WallohBaba.Birthdate = new DateTime(1996, 8, 20);
            WallohBaba.Address = "Baba Street 123, Babaville";

            try
            {
                WallohBaba.Telephone = "1234567890"; // Invalid length
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
         public class Person
        {
            private string name;
            private DateTime birthdate;
            private string address;
            private string telephone;
            private string email;
            public Person( string name)
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
                set { 
                    int allowedLength = 11;
                    if (value.Length != allowedLength)
                    {
                        throw new ArgumentException($"Telephone number must be {allowedLength} characters long.");
                    }
                }
            }
            public string Email
            {
                get { return email; }
                set { email = value; }
            }
            public override string ToString()
            {
                String manual_concatonated_string =  $"Name: {name}, Birthdate: {birthdate.ToShortDateString()}, Address: {address}, Telephone: {telephone}, Email: {email}";
                StringBuilder sb = new StringBuilder();
                sb.Append( name );
                sb.Append( birthdate.ToShortDateString() );
                sb.Append( address );
                sb.Append( telephone );
                sb.Append( email );
                return sb.ToString();

            }
        }
    }
}
