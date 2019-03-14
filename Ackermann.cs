using System;

namespace AckermannCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            int inputM = -1;
            int inputN = -1;
            int result = 0;
            bool invalidInput = false;

            do
            {
                invalidInput = false;
                //Prompt for and read in 'm' typecasting the input string to an integer and check validity
                Console.WriteLine("Please enter a positive interger number for M.");
                input = Console.ReadLine();
                if (!int.TryParse(input, out inputM))
                {
                    Console.WriteLine("Not an integer, try again.");
                    inputM = -1;
                }
                else
                {
                    //Prompt for and read in 'n' typecasting the input string to an integer and check validity
                    Console.WriteLine("Please enter a positive interger number for N.");
                    input = Console.ReadLine();
                    if (!int.TryParse(input, out inputN))
                    {
                        Console.WriteLine("Not an integer, try again.");
                        inputN = -1;
                    }
                }

                //Ensure M and N are positive
                if (inputM < 0 || inputN < 0)
                {
                    Console.WriteLine("Invalid inputs, please enter positive integers for both M and N.");
                    invalidInput = true;
                }
            } while (invalidInput != false);

            //Call function to calculate the Ackermann value
            result = Ackermann(inputM, inputN);

            Console.WriteLine("The Ackermann result for {0} and {1} is: {2}.", inputM, inputN, result);
        }

        //Ackermann recursive function
        static int Ackermann(int m, int n)
        {
            //Base case
            if (m == 0)
            {
                return n + 1;
            }

            //First recursive path
            else if (m > 0 && n == 0)
            {
                return Ackermann(m - 1, 1);
            }
            //Second recursive path
            else if (m > 0 && n > 0)
            {
                return Ackermann(m - 1, Ackermann(m, n - 1));
            }

            return -1;

        }

    }
}
