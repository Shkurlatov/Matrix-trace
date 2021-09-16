using System.Collections.Generic;
using Xunit;
using MatrixProject;
using TraceProject;

namespace Task2UnitTestProject
{
    public class TraceTests
    {
        [Theory]
        [MemberData(nameof(MatrixTestData))]
        public void Matrix_InitializationAndGenerate(int expectedArrayLength, int rowsNum, int columnsNum)
        {
            // Arrange
            var matrix = new Matrix(rowsNum, columnsNum);

            // Assert
            Assert.Equal(expectedArrayLength, matrix.MatrixArray.Length);

            int matrixTrace = 0;
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Columns; j++)
                {
                    Assert.True(matrix.MatrixArray[i, j] > -1 && matrix.MatrixArray[i, j] < 101);

                    if (i == j)
                    {
                        matrixTrace += matrix.MatrixArray[i, j];
                    }
                }
            }

            Assert.Equal(matrixTrace, matrix.MatrixTrace);
            Assert.Equal(expectedArrayLength, matrix.SnakeSequence.Length);
        }

        public static IEnumerable<object[]> MatrixTestData()
        {
            yield return new object[] { 16, 4, 4 };
            yield return new object[] { 15, 3, 5 };
            yield return new object[] { 1, 0, 0 };
            yield return new object[] { 1, -1, -1 };
            yield return new object[] { 4, 4, -1 };
            yield return new object[] { 6, -2, 6 };
            yield return new object[] { 5, 0, 5 };
            yield return new object[] { 8, 8, 0 };
            yield return new object[] { 10_000, 100, 100 };
            yield return new object[] { 1, 5 / 4, 3 / 8 };
        }
    }
}
