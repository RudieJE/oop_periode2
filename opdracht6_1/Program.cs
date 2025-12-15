
/*
 * 
 * Opdracht 6_1
Voeg een methode PrintKlas toe in de Main.
Deze Methode  heeft de volgende parameters (klas en aantalLeerlingen)
De methode druk het volgende af:
Klas [klas] heeft [aantalLeerlingen] leerlingen
Zorg ervoor van in de Main deze methode 2 keer wordt aangeroepen:
Klas 2ISD1A, 21 leerlingen
Klas 2ISD1B, 23 leerlingen
 */
namespace opdracht6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintKlas("2ISD1A", 21);
            PrintKlas("2ISD1B", 23);
            Console.WriteLine("Hello, World!");
        }

        public static void PrintKlas(string klas, int aantalLeerlingen)
        {
            Console.WriteLine($"Klas {klas} heeft {aantalLeerlingen} leerlingen");
        }
    }
}
