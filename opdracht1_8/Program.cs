using System;

namespace Opdracht1_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            *Maak een programma waarin je voor elke reken-operator een methode maakt met twee parameters.
            Er zijn totaal vijf reken-operatoren (+, - , /, *, %)

            Bijvoorbeeld int Plus(int x, int y), int Modulo(int x, int y)

            Test al deze methodes ook achter elkaar in je Main methode.

            int a = 10;

            int b = 2;

            Console.WriteLine(“optellen: “ + Plus(a, b));

            Ect… 
            */

            
            int square_z = 70;
            int square_x = 6;
            int square_y = 90;
            int square_surface = multiply(square_x, square_y);
            int square_volme = multiply(square_surface, square_z) * square_y;


            Console.WriteLine($"The volume is {square_volme} the surface area is {square_surface}");
        }



        static int Addition(int input, int additional)
        {
            double intermediate_result = input + additional;
            int result = (int)intermediate_result;
            return result;
        }

        static int multiply(int input, int multiplier)
        {
            double intermediate_result = input * multiplier;
            int result = (int)intermediate_result;
            return result;
        }
        static int Subtract(int input, int subtractor)
        {
            double intermediate_result = input - subtractor;
            int result = (int)intermediate_result;
            return result;
        }
        static int Divide(int input, int divider)
        {
            double intermediate_result = input / divider;
            int result = (int)intermediate_result;
            return result;
        }
        static int Root(int input)
        {
            double intermediate_result = Math.Sqrt(input);
            intermediate_result = (int)intermediate_result;
            int result = 0;
            return result;
        }
        static int Power(int input, int power)
        {
            int result = 0;

            if (power == 0)
            {
                return 0;
            }
            else if (power == 1)
            {
                return input;
            }
            else
            {
                double intermediate_result = Math.Pow(input, power);
                result = (int)intermediate_result;
                return result;
            }

        }
        static int Factorial(int start_int)
        {

            int first_param = 0;
            int result = first_param;
            int second_param = 0; //5-1=4
            string formulating = $"start integer: {start_int} "; //5
            for (global::System.Int32 iterator = 0; iterator < start_int; iterator++)
            {
                second_param = start_int - iterator;

                if (iterator == 1)
                {
                    first_param = start_int * iterator; // 5*1=5 && <<<5*2=10>>>>
                    formulating += $"\n first_param{first_param} * second_param{second_param}"; //5=5*1 <<<10=5*2>>>
                    //Console.WriteLine($"\n first_param{first_param} * second_param{second_param}");
                }

                if (iterator > 0)
                {
                    first_param = first_param * second_param; // 5*4 =20 &&  20 * 3 =60 && 60*2=120 && 120*1=120
                    //result = first_param; //20 && 60 && 
                    formulating += $"\n result first_param{first_param} * second_param{second_param}"; //5*1
                    //Console.WriteLine($"\n first_param{first_param} * second_param{second_param}");
                }
                result = first_param;
                //Console.WriteLine(result);

            }

            return result;
        }
    }
}