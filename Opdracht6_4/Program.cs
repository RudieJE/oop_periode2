
/*
 * 
Maak een klasse van een Auto. Maak als instance variabelen de merk, type, kleur en kilomers per liter  aan.
Zorg ervoor dat je deze gegevens kunt aanpassen, maak daarbij gebruik van full properties (Zie paragraaf 9.4.3 van je boek). 
Maak ook een methode in deze klasse die alle gegevens (properties) afdrukt zoals hieronder:
Deze [kleur] auto is van het [merk] en het type [type] en heeft een verbruik van [kilometersperliter].
Voeg een methode toe om het aantal liters te berekenen dat nodig is om 100 kilometer te rijden.
Als je deze methode aanroept dan wordt het volgende op het scherm afgedrukt.
Deze auto verbruikt [aantal] liter benzine om 100 kilometer te rijden. Rond het aantal liters af op 2 decimalen.
Vraag in de Main aan de gebruiker om kleur, merk, type en verbruik van de auto.
Maak in de Main een nieuwe Auto aan.
Vul de nieuwe auto met de waarden die de gebruiker heeft ingevoerd en druk de gegevens van de auto af met de eerste methode. Roep daarna de methode aan om het verbruik per 100 kilometer af te drukken.
 */
namespace Opdracht6_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Auto mijnAutp = new Auto();
            Console.Write("Voer de kleur van de auto in: ");
            mijnAutp.Kleur = Console.ReadLine();
            Console.Write("Voer het merk van de auto in: ");
            mijnAutp.Merk = Console.ReadLine();

        }



    }

    public class Auto
    {
        private string merk;
        private string type;
        private string kleur;
        private double kilometersPerLiter;
        public string Merk
        {
            get { return merk; }
            set { merk = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public string Kleur
        {
            get { return kleur; }
            set { kleur = value; }
        }
        public double KilometersPerLiter
        {
            get { return kilometersPerLiter; }
            set { kilometersPerLiter = value; }
        }
        public void PrintDetails()
        {
            Console.WriteLine($"Deze {kleur} auto is van het {merk} en het type {type} en heeft een verbruik van {kilometersPerLiter} kilometers per liter.");
        }
        public void BerekenVerbruikPer100Km()
        {
            double litersNodig = 100 / kilometersPerLiter;
            Console.WriteLine($"Deze auto verbruikt {litersNodig:F2} liter benzine om 100 kilometer te rijden.");
        }
    }
}
