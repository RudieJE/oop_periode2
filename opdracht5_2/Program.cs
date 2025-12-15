
/* 
 Maak een kopie van opdracht 5_1.
Vraag de gebruiker 5 keer om een getal welke wordt toegevoegd aan de lijst
Druk alle getallen in de lijst af door een for loop te gebruiken. Tip met de .Count property tel je het aantal items in de lijst.
 */
namespace opdracht5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            List<int> getallen = new List<int>();
            getallen.Add(10);
            getallen.Add(20);
            getallen.Add(30);
            getallen.Add(40);
            getallen.Add(50);
            foreach (int getal in getallen)
            {
                Console.WriteLine(getal);
            }
            Console.WriteLine("getallen.Sum(): " + getallen.Sum());
            Console.WriteLine("getallen.OrderBy: " + string.Join(", ", getallen.OrderBy(g => g)));
            Console.WriteLine("getallen.Count(): " + getallen.Count());
            
            int amount = 1;

            while (amount < 5 )
            {
                Console.WriteLine("Voer een getal in: ");
                string? userInput = Console.ReadLine();
                if (userInput != null)
                {
                    try
                    {
                        getallen.Add(int.Parse(userInput));
                        amount++;
                        Console.WriteLine("huidige iteration: " + amount);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Ongeldige invoer, voer een geldig getal in.");
                    }
                }
            }

            if(amount == 5) { 
                for (int i = 0; i < getallen.Count; i++)
                {
                    Console.WriteLine(getallen[i]);
                }
            }


        }

       
    }
}
