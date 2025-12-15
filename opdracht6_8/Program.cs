
/*
 * 
Vraag de gebruiker om een getal, dit getal van je toe aan een List
Stel na het invoeren van een getal de vraag of de gebruiker nog een getal wil toevoegen.
Sorteer na afloop de lijst en druk het volgende af:
    De som van de getallen.
    Het gemiddelde van de getallen (let op afronding).
    Het hoogste getal.
    Het laagste getal
 */
namespace opdracht6_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> getallen = new List<int>();
            Console.WriteLine("Voer een getal in:");
            string? userInput = Console.ReadLine();
            if(userInput != null)
            {
                try
                {
                    getallen.Add(int.Parse(userInput));
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ongeldige invoer, voer een geldig getal in.");
                }
            }
          
            while (true)
            {

                //Waarom is de antwoord variabele in the if statement, na de or clasule niet null en geeft die aan that the property may be null
                //Dat komt het beter is om eerst de property te checken op null en daarna pas de waarde te gebruiken.
                Console.WriteLine("Wil je nog een getal toevoegen? (ja/nee)");
                string? antwoord = Console.ReadLine();
                string antwoorod_nullcheck = antwoord ?? "";
                if (antwoorod_nullcheck!= "" && antwoorod_nullcheck.ToLower() == "ja" || antwoorod_nullcheck.ToLower() == "j")
                {
                    Console.WriteLine("Voer een getal in:");
                    userInput = Console.ReadLine();
                    if (userInput != null)
                    {
                        try
                        {
                            getallen.Add(int.Parse(userInput));
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Ongeldige invoer, voer een geldig getal in.");
                        }
                    }
                }
                else
                {
                    break;
                }
            }

            if (getallen.Any())
            {
                Console.WriteLine($"De som van de getallen is: {getallen.Sum()}");
                Console.WriteLine($"Het gemiddelde van de getallen is: {Math.Round(getallen.Average(), 2)}");
                Console.WriteLine($"Het hoogste getal is: {getallen.Max()}");
                Console.WriteLine($"Het laagste getal is: {getallen.Min()}");
            }
            else
            {
                Console.WriteLine("Geen getallen ingevoerd.");
            }
        }
    }
}
