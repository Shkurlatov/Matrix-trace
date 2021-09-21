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

        private readonly int[] ArrayRange;

        public Matrix(int rows, int columns, int[] arrayRange)
        {
            Rows = GreaterThanZero(rows);
            Columns = GreaterThanZero(columns);

            if (arrayRange != null)
            {
                ArrayRange = arrayRange;
            }
            else
            {
                ArrayRange = new int[] { 0, 1 };
            }

            GenerateMatrix();
            FindMatrixTrace();
            FindSnakeSequence();
        }

        private int GreaterThanZero(int inputValue)
        {
            if (inputValue > 0)
            {
                return inputValue;
            }

            return 1;
        }

        private void GenerateMatrix()
        {
            MatrixArray = new int[Rows, Columns];

            Random random = new Random();

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    MatrixArray[i, j] = random.Next(ArrayRange[0], ArrayRange[1]);
                }
            }
        }

        private void FindMatrixTrace()
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    if (i == j)
                    {
                        MatrixTrace += MatrixArray[i, j];
                    }
                }
            }
        }

        private void FindSnakeSequence()
        {
            SnakeSequence = new int[Rows * Columns];

            int cycle = 0;
            int edge = 0;
            int point = 0;

            for (int i = 0; i < SnakeSequence.Length; i++)
            {
                if (edge % 4 == 0)
                {
                    if (point == Columns - (cycle + 1))
                    {
                        int offset = 0;
                        while (i < SnakeSequence.Length)
                        {
                            SnakeSequence[i] = MatrixArray[cycle + offset, point];
                            i++;
                            offset++;
                        }
                        return;
                    }

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
        }
    }
}
