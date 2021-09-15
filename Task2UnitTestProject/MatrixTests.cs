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

            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Columns; j++)
                {
                    Assert.True(matrix.MatrixArray[i, j] > -1 && matrix.MatrixArray[i, j] < 101);
                }
            }
        }

        [Theory]
        [MemberData(nameof(ConsoleInputTestData))]
        public void Console_Input(string message)
        {
            // Arrange
            var console = new ConsoleInterface();

            // Act
            int number = console.InputNumber(message);

            // Assert
            Assert.Equal(0, number);
        }

        [Theory]
        [MemberData(nameof(ConsoleOutputTestData))]
        public void Console_Output(int[,] matrixArray)
        {
            // Arrange
            var console = new ConsoleInterface();

            // Act
            console.OutputMatrixTrace(matrixArray);
            console.OutputSnakeSequence(matrixArray);
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

        public static IEnumerable<object[]> ConsoleInputTestData()
        {
            yield return new object[] { null };
            yield return new object[] { "" };
            yield return new object[] { "        " };
            yield return new object[] { "Hello World!" };
            yield return new object[] { "你好，世界!" };
            yield return new object[] { "¡Hola Mundo!" };
            yield return new object[] { "こんにちは世界!" };
        }

        public static IEnumerable<object[]> ConsoleOutputTestData()
        {
            yield return new object[] { null };
            yield return new object[] { new int[0, 0] };
            yield return new object[] { new int[1, 0] };
            yield return new object[] { new int[0, 1] };
            yield return new object[] { new int[1, 1] { { 1 } } };
            yield return new object[] { new int[4, 4] { { 1, 2, 3, 4 }, { 1, 2, 3, 4 }, { 1, 2, 3, 4 }, { 1, 2, 3, 4 } } };
            yield return new object[] { new int[3, 5] { { 1, 2, 3, 4, 5 }, { 1, 2, 3, 4, 5 }, { 1, 2, 3, 4, 5 } } };
        }
    }
}
