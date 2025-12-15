
/* 
Opdracht 5_1
Maak een List aan voor het opslaan van gehele getallen.
Voeg 5 getallen toe aan de lijst.
Druk alle getallen in de lijst af door foreach te gebruiken.
 */
namespace opdracht5__
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
            Console.WriteLine("getallen.OrderBy: "  + string.Join(", ", getallen.OrderBy(g => g)));
            Console.WriteLine("getallen.Count(): " + getallen.Count());
        }
    }
}
