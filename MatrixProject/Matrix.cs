using System;

namespace MatrixProject
{
    public class Matrix
    {
        public int Rows { get; private set; }
        public int Columns { get; private set; }
        public int[,] MatrixArray { get; private set; }

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

        private int[,] GenerateMatrix()
        {
            int[,] array = new int[Rows, Columns];

            Random random = new Random();

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    array[i, j] = random.Next(0, 101);
                }
            }

            return array;
        }
    }
}
