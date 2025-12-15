
/* 
 
Opdracht 3_1
Maak een klasse van een Klok. Leg het uur (int) en de minuten (int) vast als instance variabele.
Gebruik full properties (zie paragraag 9.4.3 van je boek) om uur en minuten te kunnen aanpassen. Druk de gegevens van het object die is gemaakt van de klasse Klok. Maak ook een methode die de tijd afdrukt.
Resultaat:
Het is nu 12:00
Zet de tijd en druk deze af:
Het is nu 23:23

Kopieer de opdracht van 3_1. Zorg nu dat de waarde van de uren nooit groter dan 23 en kleiner dan 0 kunnen worden. Zorg er ook voor dat de minuten nooit groter dan 59 of kleiner dan 0 kunnen worden.

 */
namespace opdracht3_5
{
    internal class Program
    {
        static void Main(string[] args)
        {


            try
            {
                Console.WriteLine("Seconds: ");
                decimal seconds = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Hours: ");
                int uur = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Minutes: ");
                int minuten = Convert.ToInt32(Console.ReadLine());
                Klok klok = new Klok(seconds, uur, minuten);
                Console.WriteLine("Het is nu " + klok.Uur + ":" + klok.Minuten + ":" + klok.Secondes);

            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
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
        public Klok(decimal secondes, int uur, int minuten)
        {

            if (minuten >= 0 || minuten <= 60)
            {
                this.minuten = minuten;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Minutes must be between 0 and 60.");
            }
            if (uur >= 0 || uur <= 24)
            {
                this.uur = uur;

            }
            else
            {
                throw new ArgumentOutOfRangeException("Hours must be between 0 and 24.");
            }
            if (secondes >= 0.00m || secondes <= 60.00m)
            {
                this.secondes = secondes;

            }
            else
            {
                throw new ArgumentOutOfRangeException("Seconds must be between 0 and 60.");
            }
        }
    }
}
