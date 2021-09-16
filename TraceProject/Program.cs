using MatrixProject;

namespace TraceProject
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleInterface console = new ConsoleInterface();

            Matrix matrix = new Matrix(console.InputNumber("Enter number of rows"), console.InputNumber("Enter number of columns"));

            console.OutputMatrixTrace(matrix);

            console.OutputSnakeSequence(matrix.SnakeSequence);
        }
    }
}
