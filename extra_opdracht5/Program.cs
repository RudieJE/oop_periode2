namespace extra_opdracht5
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
          * Opdracht 5 – Eenvoudige cijferberekening (combinatie van alles)

            Leerdoel:

                Een klein programma ontwerpen met meerdere samenwerkende methoden.

                Werken met int, double, bool en string in methoden.

                Parameters goed kiezen.

            Opdracht:
            Schrijf een programma dat een “eindcijfer” berekent op basis van drie onderdelen:

                Toets 1

                Toets 2

                Project

            Kies zelf wegingen (bijv. alle drie 1/3, of project zwaarder laten tellen).

            Maak minimaal deze methoden:

                Inleesmethode (één methode hergebruiken):
                static double LeesCijfer(string naamVanOnderdeel)

                    Schrijft bijvoorbeeld: "Voer het cijfer in voor Toets 1:"

                    Leest een regel van de console.

                    Zet die om naar double.

                    Geeft het cijfer terug.

                Rekenmethode voor eindcijfer:
                static double BerekenEindcijfer(double toets1, double toets2, double project)

                Beoordelingsmethode (string return):
                static string BepaalBeoordeling(double eindcijfer)

                Deze geeft bijvoorbeeld “Onvoldoende”, “Voldoende”, “Goed” terug, afhankelijk van het cijfer.

                In Main:

                    Roep drie keer LeesCijfer aan (voor elk onderdeel).

                    Roep daarna BerekenEindcijfer aan.

                    Gebruik BepaalBeoordeling met het eindcijfer.

                    Toon zowel het eindcijfer als de beoordeling.

            Uitbreiding (optioneel):
            Voeg een methode toe die bool teruggeeft:
            static bool IsGeslaagd(double eindcijfer)

            En toon in Main met een if-statement of de student geslaagd is.
          */
            Console.WriteLine("Hello, World!");
        }
    }

    class Cijferberekenaar
    {
        public static double LeesCijfer(string naamVanOnderdeel)
        {
            Console.Write($"Voer het cijfer in voor {naamVanOnderdeel}: ");
            string input = Console.ReadLine();
            double cijfer = double.Parse(input);
            return cijfer;
        }
        public static double BerekenEindcijfer(double toets1, double toets2, double project)
        {
            // Voorbeeld weging: Toets 1 = 30%, Toets 2 = 30%, Project = 40%
            return (toets1 * 0.3) + (toets2 * 0.3) + (project * 0.4);
        }
        public static string BepaalBeoordeling(double eindcijfer)
        {
            if (eindcijfer >= 7.0)
                return "Goed";
            else if (eindcijfer >= 5.5)
                return "Voldoende";
            else
                return "Onvoldoende";
        }
        public static bool IsGeslaagd(double eindcijfer)
        {
            return eindcijfer >= 5.5;
        }
    }
}
