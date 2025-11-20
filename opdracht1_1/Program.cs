using System;

namespace Opdracht1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // The string is fetched directly from the method and printed to the console
            Console.WriteLine(UserinputS());

            //the dictionary is fetched from the method and stored in a variable before being printed to the console
            Dictionary<string, string> full_adress = new Dictionary<string, string>();
            full_adress = UserInputD();
            foreach (KeyValuePair<string, string> kvp in full_adress)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }




        static string  UserinputS()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your street: ");
            string street = Console.ReadLine();
            Console.Write("Enter your city: ");
            string city = Console.ReadLine();
            Console.Write("Enter your postal code: ");
            string postalCode = Console.ReadLine();
            string address = $"name: {name}" + $"\nstreet: {street}" +
                             $"\ncity: {city}" +
                             $"\npostal code: {postalCode}";
            
            return $"name: {name}" +
                   $"\nstreet: {street}" +
                   $"\ncity: {city}" +
                   $"\npostal code: {postalCode}" +
                   $"\n\nFULL ADRESS\n{address}";
        }

        static Dictionary<string, string> UserInputD()
        {
            Dictionary<string, string> full_adress = new Dictionary<string, string>();
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your street: ");
            string street = Console.ReadLine();
            Console.Write("Enter your city: ");
            string city = Console.ReadLine();
            Console.Write("Enter your postal code: ");
            string postalCode = Console.ReadLine();
            string address = $"name: {name}" + $"\nstreet: {street}" +
                             $"\ncity: {city}" +
                             $"\npostal code: {postalCode}";


            full_adress.Add("name", name);
            full_adress.Add("street", street);  
            full_adress.Add("city", city);  
            full_adress.Add("postal code", postalCode); 
            full_adress.Add("full adress", address);
            return full_adress;

        }
    }
}
