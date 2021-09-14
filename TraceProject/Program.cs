using System;

namespace TraceProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix = new Matrix(InputNumber("Enter number of rows"), InputNumber("Enter number of columns"));

            matrix.OutputMatrixTrace();

            matrix.OutputSnakeSequence();

            static int InputNumber(string message)
            {
                Console.WriteLine(message);

                int.TryParse(Console.ReadLine(), out int num);

                while (num < 1)
                {
                    Console.WriteLine("Please enter an intager greater than zero");
                    int.TryParse(Console.ReadLine(), out num);
                }

                return num;
            }
        }
    }
}
