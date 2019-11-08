using System;
using System.Collections.Generic;
using System.Text;

namespace Example_12 {
    class Program {
        static void Main (string[] args) {

            //Here we define a random number generator object, which is
            //used to generate random numbers.
            Random r = new Random ();

            //Here we define an array of double numbers of size 5
            double[] doubleNumbers = new double[5];

            //Here we initialize the array with random double numbers.
            //doubleNumbers.Length returns the number of locations in the
            //array.
            for (int i = 0; i < doubleNumbers.Length; i++)
                doubleNumbers[i] = 1000 * r.NextDouble ();

            Console.WriteLine ("The content of doubleNumbers array:");

            //Here we print the content of the array. In the Write()
            //method we reserve 8 places for each number and print each
            //number with 4 decimal numbers.
            for (int i = 0; i < doubleNumbers.Length; i++)
                Console.Write ("{0, 10:f4} ", doubleNumbers[i]);

            Console.WriteLine ();

            //Here we define a 3x4 matrix
            int[, ] intNumbers = new int[3, 4];

            //In the following we firs initialize matrix number.
            //numbers.GetLength(0) returns the length of the first dimension
            //of the matrix, numbers.GetLength(0) returns the the length of
            //the second dimension, etc.
            for (int i = 0; i < intNumbers.GetLength (0); i++)
                for (int j = 0; j < intNumbers.GetLength (1); j++)
                    //Here we initialize the matrix location by a value
                    //between 0 and 99.
                    intNumbers[i, j] = r.Next (100);

            Console.WriteLine ("The content of intNumbers matrix:");

            //In the following we print the content of matrix numbers
            for (int i = 0; i < intNumbers.GetLength (0); i++) {
                for (int j = 0; j < intNumbers.GetLength (1); j++)
                    Console.Write ("{0,5}", intNumbers[i, j]);

                Console.WriteLine ();
            }

            //Here we deine a three-dimensiona array and initialize it
            int[, , ] cubeDimensions = new int[3, 2, 4];
            for (int i = 0; i < cubeDimensions.GetLength (0); i++)
                for (int j = 0; j < cubeDimensions.GetLength (1); j++)
                    for (int k = 0; k < cubeDimensions.GetLength (2); k++)
                        cubeDimensions[i, j, k] = r.Next (-10, 10);

            //Here we print the content of three-dimensiona array and initialize it
            for (int i = 0; i < cubeDimensions.GetLength (0); i++) {
                Console.WriteLine ("Dimension values for side " + (i + 1) + ":");
                for (int j = 0; j < cubeDimensions.GetLength (1); j++) {
                    for (int k = 0; k < cubeDimensions.GetLength (2); k++)
                        Console.Write ("{0,4:0}", cubeDimensions[i, j, k] + " ");

                    Console.WriteLine ();
                }

                Console.WriteLine ();

            }

            //Here we define a matrix, whose rows have different lengths (jagged array)
            double[][] customMatrix = new double[4][];
            for (int i = 0; i < customMatrix.GetLength (0); i++) {
                customMatrix[i] = new double[r.Next (3, 7)];

                for (int j = 0; j < customMatrix[i].GetLength (0); j++)
                    customMatrix[i][j] = 10 * r.NextDouble ();

            }

            Console.WriteLine ("The content of the jagged array: ");
            //Here we print out the content of the jagged array
            for (int i = 0; i < customMatrix.GetLength (0); i++) {
                for (int j = 0; j < customMatrix[i].GetLength (0); j++)
                    Console.Write ("{0,6:f2}", customMatrix[i][j]);

                Console.WriteLine ();

            }
            Console.ReadKey ();
        }
    }
}