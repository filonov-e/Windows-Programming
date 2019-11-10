using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;

namespace Assignment1
{
    class Part1
    {
        static void PrintMatrix(Matrix<double> M)
        {
            for (int i = 0; i < M.ColumnCount; i++)
            {
                Console.Write(" _______");
            }
            Console.Write('\n');
            foreach (double[] row in M.ToRowArrays())
            {
                foreach (double item in row)
                {
                    Console.Write(string.Format("|{0, 7:F2}", item));
                }
                Console.Write("|\n");
                foreach (double item in row)
                {
                    Console.Write(" -------");
                }
                Console.Write('\n');
            }
        }

        public static void Run()
        {
            Console.WriteLine("Running part 1...");
            Random random = new Random();
            int dimensionOne = random.Next(20) + 1;
            int dimensionTwo = random.Next(20) + 1;

            Matrix<double> A = Matrix<double>.Build.Random(dimensionOne, dimensionTwo);
            Matrix<double> B = Matrix<double>.Build.Random(dimensionOne, dimensionTwo);

            Console.WriteLine("Matrix A:");
            PrintMatrix(A);
            Console.WriteLine("Matrix B:");
            PrintMatrix(B);
            Console.WriteLine("A - B:");
            PrintMatrix(A - B);
            Console.WriteLine("A + B:");
            PrintMatrix(A + B);
            Console.WriteLine("A .* B:");
            PrintMatrix(A.PointwiseMultiply(B));
            Console.WriteLine("A / B:");
            PrintMatrix(A.PointwiseDivide(B));
        }
    }
}
