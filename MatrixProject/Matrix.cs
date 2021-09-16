using System;

namespace MatrixProject
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
            Rows = GreaterThanZero(rows);
            Columns = GreaterThanZero(columns);

            MatrixArray = GenerateMatrix();
            MatrixTrace = FindMatrixTrace();
            SnakeSequence = FindSnakeSequence();
        }

        private int GreaterThanZero(int inputValue)
        {
            int value = (inputValue > 0) ? inputValue : 1;

            return value;
        }

        private int[,] GenerateMatrix()
        {
            int[,] matrixArray = new int[Rows, Columns];

            Random random = new Random();

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    matrixArray[i, j] = random.Next(0, 101);
                }
            }

            return matrixArray;
        }

        private int FindMatrixTrace()
        {
            int matrixTrace = 0;

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    if (i == j)
                    {
                        matrixTrace += MatrixArray[i, j];
                    }
                }
            }

            return matrixTrace;
        }

        private int[] FindSnakeSequence()
        {
            int[] snakeSequence = new int[Rows * Columns];

            int cycle = 0;
            int edge = 0;
            int point = 0;

            if (Columns == 1)
            {
                edge = 1;
            }

            for (int i = 0; i < snakeSequence.Length; i++)
            {
                if (edge % 4 == 0)
                {
                    snakeSequence[i] = MatrixArray[cycle, point];
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
                    snakeSequence[i] = MatrixArray[point, Columns - (cycle + 1)];
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
                    snakeSequence[i] = MatrixArray[Rows - (cycle + 1), point];
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
                    snakeSequence[i] = MatrixArray[point, cycle];
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

            return snakeSequence;
        }
    }
}
