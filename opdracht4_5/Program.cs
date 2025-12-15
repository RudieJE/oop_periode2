
/* 

Maak een klasse Auto

De auto moet de volgende gegevens bevatten:

    Merk
    Kleur
    MaxSnelheid
    HuidigeSnelheid
Het merk moet in de constructor gezet worden.
Maak in je opstartklasse twee Auto’s aan van de merken Volvo en Toyota. Merk geef je dus direct bij het aanmaken mee.
Set de andere parameters door middel van een property
Maak in de klasse een methode public override string ToString() aan die alle gegevens teruggeeft. Gebruik “\n” om een onderscheid te maken tussen de verschillende regels.
Druk nu de gegevens af in je opstartklasse door bijvoorbeeld: Console.WriteLine(auto);
Druk met behulp van de methode ToString() het volgende af:
Auto
Merk: Toyota
Kleur: wit
Max. Snelheid: 150
Huidige Snelheid: 80

*/
namespace opdracht4_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    partial class Auto
    {
        private string merk;
        private string kleur;
        private int maxSnelheid;
        private int huidigeSnelheid;
        public Auto(string merk)
        {
            this.merk = merk;
        }
        public string Kleur
        {
            get { return kleur; }
            set { kleur = value; }
        }
        public int MaxSnelheid
        {
            get { return maxSnelheid; }
            set { maxSnelheid = value; }
        }
        public int HuidigeSnelheid
        {
            get { return huidigeSnelheid; }
            set { huidigeSnelheid = value; }
        }
        public override string ToString()
        {
            return $"Auto\nMerk: {merk}\nKleur: {kleur}\nMax. Snelheid: {maxSnelheid}\nHuidige Snelheid: {huidigeSnelheid}";
        }
    }
}
