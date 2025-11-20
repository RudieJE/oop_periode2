using System;

namespace Opdracht1_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /*
            * Schrijf een programma dat de 3e letter in een woord omzet in een # teken.
            Verwachte output:
            Geef een woord: Garage
            Output: Ga#age
            */
            string text = "Hello, world!";
            string substring = text.Substring(7);

            //loop through each character in the string and print it on a new line
            foreach (char c in text)
            {
                Console.WriteLine(c);
            }

            //print the character at index 3
            Console.WriteLine($"print from the 3 index {substring[3]}");

            //loop through each character in the string using index and print it on a new line
            for (int i = 0; i < text.Length; i++)
            {
                Console.WriteLine($"Character at index {i}: {text[i]}");
            }


            string slava = "У меня есть знание кое-чтo";
            string slava_substring = slava.Substring(0);
            Console.WriteLine($"Сколько долго мое предложение? он: {slava.Length}");
            for (int i = 0; i < slava_substring.Length; i++)
            {
                Console.WriteLine($"Character at index {i}: {slava_substring[i]}");
            }

            //lets cut the string, slave up and negate from negative to positive: У меня есть знание кое-что мы стали хорошими людьями счасливый!
            string new_
            for (int i = slava_substring.Length - 1; i >= 0; i--)
            {

                if(i >= 36)
                {
                    int iterations_left = slava.Length - 36; 
                    for(int j = 0; j < iterations_left; j++)
                    {

                        Console.WriteLine($"Character at index {36 + j}: {'!'}");
                    }

                }
                Console.WriteLine($"Character at index {i}: {slava_substring[i]}");
                //Replace the string character per character, index for index or replace a set of characters from a specific index?
            }

        }
    }
}
