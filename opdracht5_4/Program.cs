
/* 
Maak een lijst met daarin 5 landen.
Voeg de 5 landen in code toe.
Druk alle landen af

| Land/Regio       | Landcode (ISO 3166-1 alpha-2)                                  |
| ---------------- | -------------------------------------------------------------- |
| Nederland        | NL                                                             |
| Duitsland        | DE                                                             |
| Rusland (Россия) | RU                                                             |
| Saudi-Arabië     | SA                                                             |
| Somalië          | SO                                                             |
| Senegal          | SN                                                             |
| China            | CN                                                             |
| Taiwan           | TW                                                             |
| Tibet            | (geen officiële ISO-code; wordt vaak onder China CN geplaatst) |
| Japan            | JP                                                             |
| Indonesië        | ID                                                             |
| Verenigde Staten | US                                                             |


Maak vervolgens ook een dictionairy waar in de namen van de landen de key is en de landcode de value.
The dictionairy neemt de key values van de volgende de list landen and the values van de landcodes worden dan in de functie toegevoegd. 
 */
namespace opdracht5_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //De lijst is hier geinitialiseerd en de landen worden toegevoegd.
            Console.WriteLine("Hello, World!");
            List<string> landen = new List<string>();
            landen.Add("Nederland");
            landen.Add("Duitsland");
            landen.Add("Rusland");
            landen.Add("Saudi-Arabië");
            landen.Add("Somalië");
            foreach (string land in landen)
            {
                Console.WriteLine(land);
            }


            /* Zie hier dat de dictionairy wordt aangemaakt. */ 
            
            Dictionary<string, string> landen_landcodes = new Dictionary<string, string>();
            landen_landcodes = new Program().MaakLandCodeDictionairy(landen);


            //Nu wordt de dictionairy aangemaakt en gevuld met de landen van de lijst en de bijbehorende landcodes worden toegevoegd in de functie MaakLandCodeDictionairy.
        }


        public Dictionary<string, string> MaakLandCodeDictionairy(List<string> landen)
        {
            Dictionary<string, string> landCodes = new Dictionary<string, string>();
            landCodes.Add("Nederland", "NL");
            landCodes.Add("Duitsland", "DE");
            landCodes.Add("Rusland", "RU");
            landCodes.Add("Saudi-Arabië", "SA");
            landCodes.Add("Somalië", "SO");
            landCodes.Add("Senegal", "SN");
            landCodes.Add("China", "CN");
            landCodes.Add("Taiwan", "TW");
            landCodes.Add("Tibet", "(geen officiële ISO-code; wordt vaak onder China CN geplaatst)");
            landCodes.Add("Japan", "JP");
            landCodes.Add("Indonesië", "ID");
            landCodes.Add("Verenigde Staten", "US");
            return landCodes;
        }

    }
}
