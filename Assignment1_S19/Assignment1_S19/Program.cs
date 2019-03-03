﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment1_S19
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 25;
            printPrimeNumbers(a, b);

            int n1 = 5;
            double r1 = getSeriesResult(n1);
           

            int n4 = 5;
            printTriangle(n4);

            int[] arr = new int[] { 1, 2, 3, 2, 2, 1, 3, 2 };
            computeFrequency(arr);

            // write your self-reflection here as a comment
            // need to use ulong for factorial as after n=20 the number become negative
            // need to convert the int division to double otherwise anything less than 1 will be negative
            // try to utilize built-in function such as LINQ to compute the frequency 

            Console.Read();
        }

        #region printPrimeNumbers
        /// <summary>
        /// Method for printing all prime numbers within a give range of x and y
        /// </summary>
        /// <param name="x">lower bound</param>
        /// <param name="y">upper bound</param>
        public static void printPrimeNumbers(int x, int y)
        {
            try{
                if (x <= y && y > 1) // Only print out prime numbers for valid range
                {
                    Console.WriteLine($"List of prime numbers between {x} and {y}");
                    for (int i = x; i <= y; i++)
                    {
                        if (NumberUtil.IsPrimeNumber(i))
                            Console.WriteLine($"{i}");
                    }
                }
                else
                {
                    Console.WriteLine($"No prime numbers between {x} and {y}");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception occured while computing printPrimeNumbers()");
                Console.WriteLine($"{ex.Message}");
                //TODO: get inner exception for more detail
            }
        }
        #endregion

        #region getSeriesResult
        /// <summary>
        /// This method computes the series 1/2 – 2!/3 + 3!/4 – 4!/5 --- 
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static double getSeriesResult(int n)
        {
            double returnVal = 0;
            try{
                for (int i = 1; i <= n; i++)
                {
                    returnVal = returnVal + NumberUtil.GetNtermInCustomSeries(i);
                }

                returnVal = Math.Round(returnVal, 3);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception occured while computing getSeriesResult()");
                Console.WriteLine($"{ex.Message}");
                //TODO: get inner exception for more detail
            }

            Console.WriteLine($"\r\nThe sum of the series of {n} is: {returnVal}");

            return returnVal;
        }
        #endregion

        #region printTriangle
        /// <summary>
        /// This method prints a triangle using *
        /// </summary>
        /// <param name="n"></param>
        public static void printTriangle(int n)
        {
            try
            {
                // making dynmaic array
                var list = new List<string>();
                for (int i = 0; i < n; i++)
                {
                    list.Add(string.Empty);
                }

                var array = list.ToArray();
                for (int i = 0; i < n; i++)
                {
                    array[i] = TrianglePatternUtil.GetLineIndentation(i+1, n)
                            + TrianglePatternUtil.GetLeftSideOfLine(i + 1) 
                            + TrianglePatternUtil.GetRightSideOfLine(i + 1);
                }

                Console.WriteLine($"\r\nPrinting triangle pattern with n={n}");
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"{array[i]}");
                }

                // Write your code here
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printTriangle()");
            }
        }
        #endregion

        #region computeFrequency
        /// <summary>
        /// This method computes the frequency of each element in the array
        /// </summary>
        /// <param name="a"></param>
        public static void computeFrequency(int[] a)
        {
            try
            {
                
                // converting array to list
                var list = a.ToList();

                // utilizing built-in groupby in LINQ
                var g = list.GroupBy(b => b).Select(b => new { val = b.First(), count = b.Count() });

                Console.WriteLine($"\r\nNumber\tFrequencey");
                foreach (var i in g)
                {
                    Console.WriteLine($"{i.val}\t{i.count}");
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception occured while computing computeFrequency()");
                Console.WriteLine($"{ex.Message}");
                //TODO: get inner exception for more detail
            }
        }
        #endregion

    }
}
