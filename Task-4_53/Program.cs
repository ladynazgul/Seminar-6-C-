// В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет

int[,] CreateMatrix(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j =0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max);
        }
    }
    return matrix;
}

int[] FindPosition(int[,] matr, int number)
{
    int[] position = new int[2];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] == number)
            {
                position[0] = i + 1;
                position[1] = j + 1;
                return position;
            }
        }
    }
    position[0] = -1;
    position[1] = -1;
    return position;
}

void PrintMatrix(int[,] matrix)
{
    Console.WriteLine("Массив:");
    for (int i = 0; i < matrix.GetLength; i++)
    {
        for (int j = 0; j < matrix.GetLength; j++)
        {
            if (matrix[i, j] / 1000 > 0) Console.Write($"{matrix[i, j]}  ");
            else if (matrix[i, j] / 100 > 0) Console.Write($" {matrix[i, j]}  ");
            else if (matrix[i, j] / 10 > 0) Console.Write($"  {matrix[i, j]}  ");
            else Console.Write($"   {matrix[i, j]}  ");
        }
        Console.WriteLine();
    }
}