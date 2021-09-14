using System;

namespace TraceProject
{
    public class Matrix
    {
        public int Rows { get; private set; }
        public int Columns { get; private set; }
        public int[,] MatrixArray { get; private set; }
        public int MatrixTrace { get; private set; }
        public int[] SnakeSequence { get; private set; }

        public Matrix(int rows, int columns)
        {
            if (rows > 0)
            {
                Rows = rows;
            }
            else
            {
                Rows = 1;
            }

            if (columns > 0)
            {
                Columns = columns;
            }
            else
            {
                Columns = 1;
            }

            MatrixArray = GenerateMatrix();
        }

        public void OutputMatrixTrace()
        {
            Console.Write("\n");

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    int value = MatrixArray[i, j];

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
                        MatrixTrace += value;

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(value);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write(value);
                    }

                    if (j < Columns - 1)
                    {
                        Console.Write(", ");
                    }
                    else
                    {
                        Console.Write("\n");
                    }
                }
            }

            Console.WriteLine("\nMatrix trace = " + MatrixTrace + "\n");
        }

        public void OutputSnakeSequence()
        {
            SnakeSequence = new int[Rows * Columns];

            int cycle = 0;
            int edge = 0;
            int point = 0;

            if (Columns == 1)
            {
                edge = 1;
            }

            for (int i = 0; i < SnakeSequence.Length; i++)
            {
                if(edge % 4 == 0)
                {
                    SnakeSequence[i] = MatrixArray[cycle, point];
                    point++;
                    if (point == Columns - (cycle + 1))
                    {
                        point = cycle;
                        edge++;
                    }
                    continue;
                }

                if (edge % 4 == 1)
                {
                    SnakeSequence[i] = MatrixArray[point, Columns - (cycle + 1)];
                    point++;
                    if (point == Rows - (cycle + 1))
                    {
                        point = Columns - (cycle + 1);
                        edge++;
                    }
                    continue;
                }

                if (edge % 4 == 2)
                {
                    SnakeSequence[i] = MatrixArray[Rows - (cycle + 1), point];
                    point--;
                    if (point == cycle)
                    {
                        point = Rows - (cycle + 1);
                        edge++;
                    }
                    continue;
                }

                if (edge % 4 == 3)
                {
                    SnakeSequence[i] = MatrixArray[point, cycle];
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

            Console.WriteLine("Matrix snake sequence is [ " + String.Join(", ", SnakeSequence) + " ]");
        }

        private int[,] GenerateMatrix()
        {
            int[,] array = new int[Rows, Columns];

            Random random = new Random();

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    array[i,j] = random.Next(0, 101);
                }
            }
            
            return array;
        }
    }
}
