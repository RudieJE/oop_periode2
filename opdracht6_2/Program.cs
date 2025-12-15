
/* 
Voeg  een methode VraagNaam toe aan de Main. Deze methode geeft de ingevoerde naam terug.
Voeg een methode ToonNaam toe aan de main. Deze methode verwacht een string parameter “naam” om het volgende af te drukken.
De [naam] is [aantal tekens] lang.
Roep in de Main VraagNaam aan en bewaar de invoer in een variabele
Roep in de Main ToonNaam aan zodat het uiteindelijk het volgende op je scherm komt:
 
 */
namespace opdracht6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string naam = VraagNaam();
            ToonNaam(naam);
        }

        public static string VraagNaam()
        {
            Console.Write("Voer je naam in: ");
            return Console.ReadLine();
        }

        public static void ToonNaam(string naam)
        {
            Console.WriteLine($"De naam {naam} is {naam.Length} tekens lang.");
        }
    }
}
