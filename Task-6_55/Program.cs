// Написать программу, которая обменивает элементы первой строки и последней строки

int[,] CreateMatrix(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max);
        }
    }
    return matrix;
}

int[,] ReplaceRow(int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int value = array[0, i];
        array[0, i] = array[array.GetLength(0) - 1, i];
        array[array.GetLength(0) - 1, i] = value;
    }
    return array;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] >= 10) Console.Write($" {array[i, j]}  ");
            else Console.Write($"  {array[i, j]}  ");
        }
        Console.WriteLine();
    }
}

int row = 3;
int col = 5;
int min = 1;
int max = 20;

int[,] matrix = CreateMatrix(row, col, min, max);
PrintMatrix(matrix);
Console.WriteLine();
int[,] newMatrix = ReplaceRow(matrix);
PrintMatrix(newMatrix);