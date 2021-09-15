using System;

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

        public void OutputMatrixTrace(int[,] matrixArray)
        {
            if (matrixArray == null || matrixArray.Length < 1)
            {
                Console.WriteLine("Matrix is empty!");
                return;
            }

            int matrixTrace = 0;
            int rows = matrixArray.GetUpperBound(0) + 1;
            int columns = matrixArray.Length / rows;

            Console.Write("\n");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    int value = matrixArray[i, j];

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
                        matrixTrace += value;

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(value);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write(value);
                    }

                    if (j < columns - 1)
                    {
                        Console.Write(", ");
                    }
                    else
                    {
                        Console.Write("\n");
                    }
                }
            }

            Console.WriteLine("\nMatrix trace = " + matrixTrace + "\n");
        }

        public void OutputSnakeSequence(int[,] matrixArray)
        {
            if (matrixArray == null || matrixArray.Length < 1)
            {
                Console.WriteLine("Matrix is empty!");
                return;
            }

            int rows = matrixArray.GetUpperBound(0) + 1;
            int columns = matrixArray.Length / rows;
            int[] snakeSequence = new int[rows * columns];

            int cycle = 0;
            int edge = 0;
            int point = 0;

            if (columns == 1)
            {
                edge = 1;
            }

            for (int i = 0; i < snakeSequence.Length; i++)
            {
                if (edge % 4 == 0)
                {
                    snakeSequence[i] = matrixArray[cycle, point];
                    point++;
                    if (point == columns - (cycle + 1))
                    {
                        point = cycle;
                        edge++;
                    }
                    continue;
                }

                if (edge % 4 == 1)
                {
                    snakeSequence[i] = matrixArray[point, columns - (cycle + 1)];
                    point++;
                    if (point == rows - (cycle + 1))
                    {
                        point = columns - (cycle + 1);
                        edge++;
                    }
                    continue;
                }

                if (edge % 4 == 2)
                {
                    snakeSequence[i] = matrixArray[rows - (cycle + 1), point];
                    point--;
                    if (point == cycle)
                    {
                        point = rows - (cycle + 1);
                        edge++;
                    }
                    continue;
                }

                if (edge % 4 == 3)
                {
                    snakeSequence[i] = matrixArray[point, cycle];
                    point--;
                    if (point == cycle)
                    {
                        cycle++;
                        point = cycle;
                        edge++;
                    }
                    continue;
                }
            }

            Console.WriteLine("Matrix snake sequence is [ " + String.Join(", ", snakeSequence) + " ]");
        }
    }
}
