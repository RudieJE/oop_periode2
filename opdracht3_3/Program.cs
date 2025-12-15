/* 
 * 
Opdracht 3_3
Maak een klasse van een Auto. We maken gebruik van full properties (zie boek paragraaf 9.4.3) (Merk, Type, Kleur en Topsnelheid).  
Maak ook een methode die alle gegevens (properties) afdrukt zoals hieronder:
Gegevens van een object Auto:
Merk: VW
Type: Golf
Kleur: Groen
Topsnelheid: 200 
 */


namespace opdracht3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto auto = new Auto();
            auto.Merk = "VW";
            auto.Type = "Golf";
            auto.Kleur = "Groen";
            auto.Topsnelheid = 200;
            auto.PrintGegevens();
        }

    }
    public class Auto
    {
        private string merk;
        private string type;
        private string kleur;
        private int topsnelheid;
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
        public int Topsnelheid
        {
            get { return topsnelheid; }
            set { topsnelheid = value; }
        }
        public void PrintGegevens()
        {
            Console.WriteLine("Gegevens van een object Auto:");
            Console.WriteLine("Merk: " + Merk);
            Console.WriteLine("Type: " + Type);
            Console.WriteLine("Kleur: " + Kleur);
            Console.WriteLine("Topsnelheid: " + Topsnelheid);
        }
    }
}
