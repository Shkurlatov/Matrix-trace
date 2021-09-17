using System;
using MatrixProject;

namespace TraceProject
{
    public class ConsoleInterface
    {
        public int InputNumber(string message)
        {
            if (message == null)
            {
                message = "";
            }

            Console.WriteLine(message);

            int.TryParse(Console.ReadLine(), out int num);

            while (num < 1)
            {
                Console.WriteLine("Please enter an intager greater than zero");
                int.TryParse(Console.ReadLine(), out num);
            }

            return num;
        }

        public void OutputMatrixTrace(Matrix matrix)
        {
            if (IsEmpty(matrix))
            {
                return;
            }

            Console.Write("\n");

            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Columns; j++)
                {
                    int value = matrix.MatrixArray[i, j];

                    if (value < 100)
                    {
                        Console.Write(" ");
                    }

                    if (value < 10)
                    {
                        Console.Write(" ");
                    }

                    if (i == j)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(value);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write(value);
                    }

                    if (j < matrix.Columns - 1)
                    {
                        Console.Write(", ");
                    }
                    else
                    {
                        Console.Write("\n");
                    }
                }
            }

            Console.WriteLine("\nMatrix trace = " + matrix.MatrixTrace);
        }

        public void OutputSnakeSequence(Matrix matrix)
        {
            if (IsEmpty(matrix))
            {
                return;
            }

            Console.WriteLine("\nMatrix snake sequence is [ " + String.Join(", ", matrix.SnakeSequence) + " ]");
        }

        private bool IsEmpty(Matrix matrix)
        {
            if (matrix == null || matrix.MatrixArray.Length == 0)
            {
                Console.WriteLine("\nThe matrix is empty!");

                return true;
            }

            return false;
        }
    }
}
