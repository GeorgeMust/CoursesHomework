namespace lesson6Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Создать метод который умеет слаживать две матрицы(два двумерных массива).
            Метод должен вернуть новый двумерный массив*/
            Console.WriteLine("Введите количество строк матриц: ");
            int quanLines = inVal();
            Console.WriteLine("Введите количество колонок матриц: ");
            int quanColumns = inVal();
            int[,] matrixA = new int[quanLines, quanColumns];
            int[,] matrixB = new int[quanLines, quanColumns];
            int[,] sumMatrixAB = new int[quanLines, quanColumns];
            Console.WriteLine("Заполнение матрицы A: ");
            matrin(matrixA);
            Console.WriteLine("Заполнение матрицы B: ");
            matrin(matrixB);
            sumMatrixAB = sumMatrix(matrixA, matrixB, sumMatrixAB);
            Console.WriteLine("Сумма матриц A + B = ");
            for (int i = 0; i < sumMatrixAB.GetLength(0); i++)
            {
                for (int j = 0; j < sumMatrixAB.GetLength(1); j++)
                {
                    Console.Write("Элемент строки " + i + " колонки " + j + ": " + sumMatrixAB[i, j] + Environment.NewLine);
                }
                Console.WriteLine();
            }
        }
        static int[,] sumMatrix(int[,] matrixA, int[,] matrixB, int[,] sumMatrAB)
        {
            for (int i = 0; i < matrixA.GetLength(0); i++)
            {
                for (int j = 0; j < matrixA.GetLength(1); j++)
                {
                    sumMatrAB[i, j] = matrixA[i, j] + matrixB[i, j];
                }
            }
            return sumMatrAB;
        }
        static int[,] matrin(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = inVal();
                    Console.Write("Элемент строки " + i + " колонки " + j + ": " + matrix[i, j] + Environment.NewLine);
                }
                Console.WriteLine();
            }
            return matrix;
        }
        static int inVal()
        {
            bool parseOk = false;
            while (!parseOk)
            {
                string? inStr = Console.ReadLine();
                if (int.TryParse(inStr, out int num))
                {
                    return num;
                }
                else
                {
                    Console.WriteLine("Неверный формат данных");
                }
            }
            return 0;
        }
    }
}
