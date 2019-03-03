using System;

namespace Assignment1_S19
{
    public static class NumberUtil
    {
        /// <summary>
        /// Method to determine whether a number is prime or not - see reference https://www.geeksforgeeks.org/prime-numbers/
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static bool IsPrimeNumber(int n)
        {
            // Corner case 
            if (n <= 1) { 
                return false;
             }

            // Check from 2 to n-1 
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }

        /// <summary>
        /// Method for calculating n term of a custom series 1/2 – 2!/3 + 3!/4 – 4!/5 --- n. 
        /// Given even term will always be negative.  
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static double GetNtermInCustomSeries(int n)
        {
            double val = (double) GetFactorial(n)/ (n + 1);

            // making sure even term is negavite
            if (n % 2 == 0) { 
                val = -val;
            }

            return val;
        }

        /// <summary>
        /// Method for computing factorial of a number
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static ulong GetFactorial(int number)
        {
            ulong fact = 1;

            // Corner case
            if (number < 0){
                throw new Exception("Number must be a positive integer");
            }

            for (uint i = 1; i <= number; i++){
                fact = fact * i;
            }

            if (number == 0 || number == 1) { 
                fact = 1;
             }

            return fact;
        }
    }
}
