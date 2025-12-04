namespace extra_opdracht3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* 
            * Opdracht 3 – Leeftijdscheck (bool return)

            Leerdoel:

                Een methode die een bool teruggeeft.

                if gebruiken met het resultaat van een methode.

            Opdracht:
            Schrijf een kleine “leeftijdscheck”.

                Maak een methode, bijvoorbeeld:

            static bool IsVolwassen(int leeftijd)

            Deze methode geeft true terug als de leeftijd 18 of hoger is, anders false.

                In Main:

                    Vraag de gebruiker om zijn/haar leeftijd.

                    Lees de leeftijd in en zet die om naar int.

                    Roep IsVolwassen aan met de ingevoerde leeftijd.

                    Gebruik een if om een andere boodschap te tonen voor:

                        iemand die volwassen is;

                        iemand die nog niet volwassen is.

            Uitbreiding (optioneel):
            Maak een tweede methode:
            static string BepaalLeeftijdscategorie(int leeftijd)

            Bijvoorbeeld categorieën: “kind”, “tiener”, “volwassene”, “senior”.
            Toon deze categorie in Main.*/
            bool result = AgeChecker.IsVolwassen(22);
            Console.WriteLine(result);
            string categorie = AgeChecker.BepaalLeeftijdscategorie(22);
            Console.WriteLine(categorie);

        }
    }

    class AgeChecker
    {
        public static bool IsVolwassen(int leeftijd)
        {
            return leeftijd >= 18;
        }

        public static string BepaalLeeftijdscategorie(int leeftijd)
        {
            if (leeftijd < 13)
            {
                return "kind";
            }
            else if (leeftijd < 20)
            {
                return "tiener";
            }
            else if (leeftijd < 65)
            {
                return "volwassene";
            }
            else
            {
                return "senior";
            }
        }
    }
}
