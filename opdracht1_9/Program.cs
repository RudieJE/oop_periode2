using System;

namespace Opdracht1_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            //Om de prijs per jaar voor electra te berekenen
            //Om de prijs per jaar voor het gas te berekenen
            //Om een mooie afdruk te maken voor de klant:

            //1,40 per m3 gas
            PriceGasInVolume(1.40f, 1000f);
            //0,30 per kWh elektra
            PriceElecInVolume(0.30f, 3050f);   
            //3050 kWh per jaar
            PriceElecInVolume(0.30f, 3050f);
            //1000 m3 gas per jaar  
            PriceGasInVolume(0.17f, 1500f);
        }


        static float PriceGasInVolume(float priceGas, float volumeGas)
        {
            float price_total = 0f;
            price_total = priceGas * volumeGas;
            Console.WriteLine($"The total price for gas is: {price_total} euros on a demand of {volumeGas}");
            return price_total;
        }

        static float PriceElecInVolume(float priceElec, float electkWh)
        {
            float price_total = 0f;
            price_total = priceElec * electkWh;
            Console.WriteLine($"The total price for electricity is: {price_total} euros on demand of {electkWh}");
            return price_total;
        }
    }
}
