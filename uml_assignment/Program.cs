/* 
 
Opdracht 3_1
Maak een klasse van een Klok. Leg het uur (int) en de minuten (int) vast als instance variabele.
Gebruik full properties (zie paragraag 9.4.3 van je boek) om uur en minuten te kunnen aanpassen. Druk de gegevens van het object die is gemaakt van de klasse Klok. Maak ook een methode die de tijd afdrukt.
Resultaat:
Het is nu 12:00
Zet de tijd en druk deze af:
Het is nu 23:23

 */


namespace uml_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Klok klok = new Klok();
            klok.Uur = 23;
            klok.Minuten = 23;
            Console.WriteLine("Het is nu " + klok.Uur + ":" + klok.Minuten);
        }
    }
     public class Klok
    {
        private int uur;
        private int minuten;
        decimal secondes;
        public int Uur
        {
            get { return uur; }
            set { uur = value; }
        }
        public int Minuten
        {
            get { return minuten; }
            set { minuten = value; }
        }
        public decimal Secondes
        {
            get { return secondes; }
            set { secondes = value; }
        }
        public Klok()
        {
            decimal secondes = 0;
            int uur = 12;   
            int minuten = 0;
        }
    }
}
