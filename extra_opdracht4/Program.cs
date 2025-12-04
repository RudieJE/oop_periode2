namespace extra_opdracht4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* 
             * 
             
         Opdracht 4 – Temperatuurconverter (meerdere methoden + verschillende return types)

        Leerdoel:

        Meerdere methoden gebruiken in één programma.

        double als parameter en return type.
    
        Eén methode die een string teruggeeft.

        Opdracht:
        Maak een simpel temperatuur-conversieprogramma.

            Maak minstens deze twee methoden:

        static double CelsiusNaarFahrenheit(double celsius) static double FahrenheitNaarCelsius(double fahrenheit)

            In Main:

                Vraag de gebruiker of hij/zij wil omrekenen van Celsius naar Fahrenheit, of andersom (bijvoorbeeld met invoer "C" of "F").

                Vraag daarna om de temperatuur.

                Afhankelijk van de keuze:

                    Roep de juiste methode aan.

                Toon de uitkomst op het scherm.

        Extra (iets moeilijker, optioneel):
        Maak nog een methode die de uitkomst als mooie tekst teruggeeft, bijvoorbeeld:
        static string MaakTemperatuurTekst(double origineleWaarde, double omgerekendeWaarde, string vanEenheid, string naarEenheid)

        En gebruik deze methode in Main om de tekst te tonen.
             */
            Console.WriteLine("Hello, World!");
        }
    }

    class Temperature 
    {
       public static double CelsiusNaarFahrenheit(double celsius)
       {
            return (celsius * 9 / 5) + 32;
        }

        public static double FahrenheitNaarCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

        public static string MaakTemperatuurTekst(double origineleWaarde, double omgerekendeWaarde, string vanEenheid, string naarEenheid)
        {
            return $"{origineleWaarde} graden {vanEenheid} is gelijk aan {omgerekendeWaarde} graden {naarEenheid}.";
        }

        public  static void PrintTemperatureConversion(double origineleWaarde, double omgerekendeWaarde, string vanEenheid, string naarEenheid)
        {
            string resultText = MaakTemperatuurTekst(origineleWaarde, omgerekendeWaarde, vanEenheid, naarEenheid);
            Console.WriteLine(resultText);
        }

        public static void ConvertAndPrint(double temperature, bool celsiusToFahrenheit)
        {
            if (celsiusToFahrenheit)
            {
                double converted = CelsiusNaarFahrenheit(temperature);
                PrintTemperatureConversion(temperature, converted, "Celsius", "Fahrenheit");
            }
            else
            {
                double converted = FahrenheitNaarCelsius(temperature);
                PrintTemperatureConversion(temperature, converted, "Fahrenheit", "Celsius");
            }
        }   
}
