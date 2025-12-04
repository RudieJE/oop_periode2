namespace extra_opdracht1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
             * Opdracht 1 – Begroeten met een naam (void + 1 parameter)

        Leerdoel:

            Een eenvoudige void-methode maken met 1 parameter.

            Methode aanroepen vanuit Main.

        Opdracht:
        Maak een methode die een naam binnenkrijgt en een begroeting op het scherm zet.

            Maak een methode, bijvoorbeeld:

        static void Begroet(string naam)

            In Main:

        Vraag met Console.WriteLine om de naam van de gebruiker.

        Lees de naam in met Console.ReadLine.

        Roep de methode Begroet( … ) aan met de ingevoerde naam.

        Uitbreiding (optioneel):
        Laat de methode ook de huidige dag van de week in de begroeting verwerken (mag hardcoded tekst zijn, dus nog niet met DateTime).
             */
        
        }
    }

    class Greeter
    {
        public static void Begroet(string naam)
        {
            Console.WriteLine($"Hallo {naam}, fijn je te zien vandaag!");
        }
    }
}
