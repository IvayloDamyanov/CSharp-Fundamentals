using System;

namespace SpiralMatrix
{
    class SpiralMatrix
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[,] matrix = new int[N, N];
            int digit = 1;
            int steps = N - 1;
            int posX = 0;
            int posY = 0;
            while (steps > 0)
            {
                for (int i = 0; i < steps; i++)
                {
                    matrix[posX, posY] = digit;
                    digit++;
                    posY++;
                }
                for (int i = 0; i < steps; i++)
                {
                    matrix[posX, posY] = digit;
                    digit++;
                    posX++;
                }
                for (int i = 0; i < steps; i++)
                {
                    matrix[posX, posY] = digit;
                    digit++;
                    posY--;
                }
                for (int i = 0; i < steps; i++)
                {
                    matrix[posX, posY] = digit;
                    digit++;
                    posX--;
                }
                posX++;
                posY++;
                steps -= 2;
            }
            if ((N * N) % 2 == 1)
            {
                matrix[posX, posY] = digit;
            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}