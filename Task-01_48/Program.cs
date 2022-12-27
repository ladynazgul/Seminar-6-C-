// Показать двумерный массив размером m×n заполненный целыми числами

int[,] CreateMatrix(int row, int col, int min, int max)
{
    int[,] table = new int[row, col];
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
    for (int i = 0; i < matr.Length(0); i++)
    {
        for (int j = 0; i < matr.Length(0); i++)
    }
}