
/* 
 
 
 Opdracht 3_4

Maak een klasse laptop met de volgende eigenschappen (Merk en BatterijPercentage)
Bij het aanmaken van de klasse staat het battrijpercentage op 80.

Het merk is Dell

Maak een methode LaadOp(int percentage)
Maak een methode Gebruik(int uren)
Maak een methode ToonStatus()
Bij LaadOp wordt het Batterijpercentage verhoogd met het opgegeven percentage, maar het Batterijpercentage kan nooit hoger dan 100 % worden. 
Bij Gebruik wordt het percentage ieder meegegeven uur met 10% verlaagd. ToonStatus() drukt het volgende af: “Het batterijpercentage is … % “
 */
namespace opdracht3_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Laptop laptop = new Laptop(merk: "Apple", batterijPercentage: 25);
            laptop.ToonStatus();
            
        }

        public class Laptop
        {
            private string merk;
            private int batterijPercentage;
            public string Merk
            {
                get { return merk; }
                set { merk = value; }
            }
            public int BatterijPercentage
            {
                get { return batterijPercentage; }
                set 
                { 
                    if (value > 100)
                        batterijPercentage = 100;
                    else if (value < 0)
                        batterijPercentage = 0;
                    else
                        batterijPercentage = value; 
                }
            }
            public Laptop(string merk, int batterijPercentage)
            {
                this.Merk = merk;
                this.BatterijPercentage = batterijPercentage;
            }
            public void LaadOp(int percentage)
            {
                BatterijPercentage += percentage;
            }
            public void Gebruik(int uren)
            {
                BatterijPercentage -= uren * 10;
            }
            public void ToonStatus()
            {
                Console.WriteLine("Het batterijpercentage is " + BatterijPercentage + " %");
            }
        }
    }

   
}
