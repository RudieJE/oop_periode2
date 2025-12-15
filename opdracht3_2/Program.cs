
/* 
 * 
Opdracht 3_2
Maak een klasse van een Tafel. Maak als instance variabelen de lengte, breedte en hoogte en naam aan. Zorg ervoor dat je deze gegevens kunt aanpassen, maak daarbij gebruik van full properties (Zie paragraaf 9.4.3 van je boek). Maak ook een methode die alle gegevens (properties) afdrukt zoals hieronder:

Gegevens van een object Tafel:

Naam: ikea
Lengte: 160
Breedte: 80
Hoogte: 100
 */
namespace opdracht3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }


    }
public class Tafel
    {
        private string naam;
        private int lengte;
        private int breedte;
        private int hoogte;
        public string Naam
        {
            get { return naam; }
            set { naam = value; }
        }
        public int Lengte
        {
            get { return lengte; }
            set { lengte = value; }
        }
        public int Breedte
        {
            get { return breedte; }
            set { breedte = value; }
        }
        public int Hoogte
        {
            get { return hoogte; }
            set { hoogte = value; }
        }
        public void PrintGegevens()
        {
            Console.WriteLine("Gegevens van een object Tafel:");
            Console.WriteLine("Naam: " + Naam);
            Console.WriteLine("Lengte: " + Lengte);
            Console.WriteLine("Breedte: " + Breedte);
            Console.WriteLine("Hoogte: " + Hoogte);
        }
    }
}
