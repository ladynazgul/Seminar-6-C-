// Показать двумерный массив размером m×n заполненный целыми числами

int[,] CreateMatrix(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

 int row = new Random().Next(5, 10);
 int col = new Random().Next(5, 10);
 int min = 1;
 int max = 100;

 int[,] table = CreateMatrix(row, col, min, max);
 PrintMatrix(table);