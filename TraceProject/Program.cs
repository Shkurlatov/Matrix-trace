using MatrixProject;

namespace TraceProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Configuration configuration = new Configuration();
            ConsoleInterface console = new ConsoleInterface();

            Matrix matrix = new Matrix(console.InputNumber("Enter number of rows"), console.InputNumber("Enter number of columns"), configuration.GetArrayRange());

            console.OutputMatrixTrace(matrix);

            console.OutputSnakeSequence(matrix);
        }
    }
}
