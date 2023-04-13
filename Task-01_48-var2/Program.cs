// Показать двумерный массив размером m×n заполненный целыми числами, это то, что показал Олег

int[,] CreateMatrix(uint rows, uint columns, int start, int end) // uint - означает неотрицательные числа
{
    Random random = new Random();
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            matrix[i, j] = random.Next(start, end);
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} ");
        Console.WriteLine();
    }
}

int[,] matrix = CreateMatrix(9, 9, 0, 20);
PrintMatrix(matrix);