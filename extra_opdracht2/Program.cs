namespace extra_opdracht2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
        Opdracht 2 – Gemiddelde berekenen (int + double return)

        Leerdoel:

            Methode met meerdere parameters.

            Verschil tussen int en double als return type.

        Opdracht:
        Maak een methode die van twee gehele getallen het gemiddelde teruggeeft als double.

            Maak een methode, bijvoorbeeld:

        static double BerekenGemiddelde(int getal1, int getal2)

            In Main:

                Vraag de gebruiker om twee hele getallen.

                Zet de invoer om naar int met int.Parse of Convert.ToInt32.

                Roep BerekenGemiddelde aan en sla de uitkomst op in een variabele.

                Toon het resultaat netjes op het scherm.

        Let op:
        Zorg dat je echt een double terugkrijgt (dus niet per ongeluk gehele deling).

        Uitbreiding (optioneel):
        Laat een tweede methode het resultaat afronden op 1 cijfer achter de komma en dat op het scherm printen.
             
             */
            Console.WriteLine("Hello, World!");
        }
    }


    class ValueReturner
    {
        public static double BerekenGemiddelde(int getal1, int getal2)
        {
            return (getal1 + getal2) / 2.0;
        }
    }
}
