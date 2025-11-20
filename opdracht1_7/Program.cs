using System;

namespace Opdracht1_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 5;
            int result = Factorial(number);
            Console.WriteLine($"Factorial of {number} is {result}");

            number = 9;
            int power = 3;
            result = Power(number, power);
            Console.WriteLine($"power of {number} is {result}");

            number =50;
            result = Root(number);
            Console.WriteLine($"Root of {number} is {result}");

            number = 20;
            result = Divide(number, 4);
            Console.WriteLine($"Division of {number} is {result}");

            number = 10;
            result = Subtract(number, 4);
            Console.WriteLine($"Subtraction of {number} is {result}");

            number = 6;
            result = multiply(number, 4);
            Console.WriteLine($"Multiplication of {number} is {result}");

            number = 8; 
            result = Addition(number, 4);
            Console.WriteLine($"Addition of {number} is {result}"); 
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
        static int Divide(int input,int divider)
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
        static int Power(int input, int power )
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