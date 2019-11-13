using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Part1
    {
        static Random random = new Random();

        static void PrintMatrix(int[,] M)
        {
            for (int i = 0; i < M.GetLength(1); i++)
            {
                Console.Write(" _______");
            }
            Console.Write('\n');
            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    Console.Write(string.Format("|{0, 7}", M[i, j]));
                }
                Console.Write("|\n");
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    Console.Write(" -------");
                }
                Console.Write('\n');
            }
        }

        static void RandomFillMatrix(ref int[,] M)
        {
            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    M[i, j] = random.Next(100);
                }
            }
        }

        static int[,] getSquareMatrix(int dimension)
        {
            return new int[dimension, dimension];
        }

        static int[,] getMatrix(int dimension1, int dimension2)
        {
            return new int[dimension1, dimension2];
        }

        static int[,] getOperation(int[,] A, int[,] B, string operation)
        {
            int[] dimensionsA = new int[2] {
                A.GetLength(0),
                A.GetLength(1)
            };

            int[] dimensionsB = new int[2] {
                B.GetLength(0),
                B.GetLength(1)
            };

            if (operation == "add" || operation == "sub")
            {
                if (A.GetLength(0) != B.GetLength(0) || A.GetLength(1) != B.GetLength(1))
                {
                    throw new Exception("Dimensions of the matrices has to be equal!");
                }

                int[,] C = new int[dimensionsA[0], dimensionsA[1]];

                for (int i = 0; i < dimensionsA[0]; i++)
                {
                    for (int j = 0; j < dimensionsA[1]; j++)
                    {
                        switch (operation)
                        {
                            case "add":
                                C[i, j] = A[i, j] + B[i, j];
                                break;
                            case "sub":
                                C[i, j] = A[i, j] - B[i, j];
                                break;
                        }
                    }
                }

                return C;
            }
            else if (operation == "mult")
            {
                int[,] C = new int[dimensionsA[0], dimensionsB[1]];

                for (int i = 0; i < dimensionsA[0]; i++)
                {
                    for (int j = 0; j < dimensionsB[1]; j++)
                    {
                        C[i, j] = 0;
                        for (int k = 0; k < dimensionsB[0]; k++)
                        {
                            C[i, j] += A[i, k] * B[k, j];
                        }
                    }
                }

                return C;
            }
            else
            {
                throw new Exception("Operation does not exist!");
            }
        }

        public static void Run()
        {
            Console.WriteLine("Running part 1...");
            int dimension = random.Next(20) + 1;
            int dimension1 = random.Next(20) + 1;
            int dimension2 = random.Next(5) + 1;
            int dimension3 = random.Next(5) + 1;

            int[,] A = getSquareMatrix(dimension);
            int[,] B = getSquareMatrix(dimension);
            int[,] C = getMatrix(dimension1, dimension2);
            int[,] D = getMatrix(dimension2, dimension3);

            RandomFillMatrix(ref A);
            RandomFillMatrix(ref B);
            RandomFillMatrix(ref C);
            RandomFillMatrix(ref D);

            Console.WriteLine("Matrix A:");
            PrintMatrix(A);
            Console.WriteLine("Matrix B:");
            PrintMatrix(B);
            Console.WriteLine("A - B:");
            PrintMatrix(getOperation(A, B, "sub"));
            Console.WriteLine("A + B:");
            PrintMatrix(getOperation(A, B, "add"));
            Console.WriteLine("Matrix C:");
            PrintMatrix(C);
            Console.WriteLine("Matrix D:");
            PrintMatrix(D);
            Console.WriteLine("C * D:");
            PrintMatrix(getOperation(C, D, "mult"));
        }
    }
}
