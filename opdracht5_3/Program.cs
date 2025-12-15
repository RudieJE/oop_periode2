/*
 * 
Pas opdracht 5_2 aan, waarbij je de gebruiker vraagt 5 getallen in te voeren.
Ieder getal wordt toegevoegd aan de List
Druk op het scherm het volgende af:
- Alle getallen
- De som van de getallen
- Gemiddelde waarde van de getallen
 */
namespace opdracht5_3
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
            getallen.Add(150);
            foreach (int getal in getallen)
            {
                Console.WriteLine(getal);
            }
            Console.WriteLine("getallen.Sum(): " + getallen.Sum());
            Console.WriteLine("getallen.OrderBy: " + string.Join(", ", getallen.OrderBy(g => g)));
            Console.WriteLine("getallen.Count(): " + getallen.Count());

            int amount = 1;

            while (amount < 5)
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


            //when more items are added to the list, the total amount of those members of the list will exceed the hart set iteration value of the property amount.
     
                for (int i = 0; i < getallen.Count; i++)
                {
                    Console.WriteLine(getallen[i]);
                }

                Console.WriteLine($"De som van de getallen is: {getallen.Sum()}");
                Console.WriteLine($"Het gemiddelde van de getallen is: {getallen.Average()}");
                Console.WriteLine($"Het hoogste getal is: {getallen.Max()}");
                Console.WriteLine($"Het laagste getal is: {getallen.Min()}");


                //remove all numbers less than 100 with an lambda expression, also called predicate function
                getallen.RemoveAll(number =>  number < 100);


                //iterate again through the list and print all numbers though everything is now deleted except the number higher 100
                for (int i = 0; i < getallen.Count; i++)
                {
                    Console.WriteLine(getallen[i]);
                }

            }
        
    }
}
