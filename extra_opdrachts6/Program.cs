namespace extra_opdracht6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* 
             
             Opdracht 6 – Rekenhulp voor twee getallen

                Je gaat een klein programma maken dat met twee hele getallen een paar dingen uitrekent:

                    De som

                    Het gemiddelde

                    Het verschil (welk getal is groter en hoeveel scheelt het?)

                Alles gebeurt in Program.cs, in dezelfde class als Main.
                Je gebruikt meerdere methoden, waaronder minimaal één void-methode.
                Wat het programma moet doen

                    Toon eerst een titel/intro op het scherm, bijvoorbeeld:
                    === Rekenhulp voor twee getallen ===

                    Vraag de gebruiker om twee hele getallen in te voeren.

                    Bereken:

                        De som van de twee getallen.

                        Het gemiddelde van de twee getallen als double.

                        Welk getal groter is en hoeveel verschil er tussen zit.

                    Toon de resultaten netjes onder elkaar.

                Verplichte methoden

                Maak in ieder geval deze methoden (allemaal static):

                    Titel tonen (void-methode)
                    static void ToonTitel()

                    Deze methode:

                        Print een titel en eventueel een korte uitleg.

                        Geeft verder niets terug (type void).

                    Getal inlezen
                    static int LeesGetal(string vraag)

                    Deze methode:

                        Print de tekst in vraag, bijvoorbeeld: "Voer het eerste getal in: "

                        Leest de invoer met Console.ReadLine().

                        Zet de invoer om naar int.

                        Geeft het ingelezen getal terug.

                    👉 Dit is de vereenvoudigde versie van “deel 2”: één vraag erin, één getal eruit.

                    Som berekenen
                    static int BerekenSom(int a, int b)

                    Deze methode:

                        Berekent a + b.

                        Geeft de som terug.

                    Gemiddelde berekenen
                    static double BerekenGemiddelde(int a, int b)

                    Deze methode:

                        Berekent het gemiddelde van a en b.

                        Let op dat je een double teruggeeft, geen integer-delingsfout.

                    Resultaten tonen (nog een void-methode, mag ook)
                    static void ToonResultaten(int a, int b, int som, double gemiddelde)

                    Deze methode:

                        Print de twee getallen.

                        Print de som.

                        Print het gemiddelde.

                        Bepaalt welk getal groter is en hoeveel het verschil is, en toont dat ook.

                        Als je het verschil liever in een aparte methode stopt, mag dat ook, maar is niet verplicht.
                             */
            Console.WriteLine("Hello, World!");
        }
    }

    class WholeNumberCalculator
    {
        public static void ShowTitle()
        {
            Console.WriteLine("=== Rekenhulp voor twee getallen ===");
        }
        public static int ReadNumber(string prompt)
        {
            Console.Write(prompt);
            return int.Parse(Console.ReadLine());
        }
        public static int CalculateSum(int a, int b)
        {
            return a + b;
        }
        public static double CalculateAverage(int a, int b)
        {
            return (a + b) / 2.0;
        }
        public static void ShowResults(int a, int b, int sum, double average)
        {
            Console.WriteLine($"Eerste getal: {a}");
            Console.WriteLine($"Tweede getal: {b}");
            Console.WriteLine($"Som: {sum}");
            Console.WriteLine($"Gemiddelde: {average}");
            if (a > b)
            {
                Console.WriteLine($"Het eerste getal is groter dan het tweede met {a - b}.");
            }
            else if (b > a)
            {
                Console.WriteLine($"Het tweede getal is groter dan het eerste met {b - a}.");
            }
            else
            {
                Console.WriteLine("Beide getallen zijn gelijk.");
            }
        }
    }
}
