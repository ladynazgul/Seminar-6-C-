// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

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

int[,] ReplaceElements(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
           if (i % 2 == 0 && j % 2 == 0) matr[i, j] *= matr[i, j];
           else matr[i, j] = matr[i, j]; 
        }
    }
    return matr;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < 10) Console.Write($" {matrix[i, j]}  ");
            else Console.Write($"{matrix[i, j]}  ");
        }
        Console.WriteLine();
    }
}

int row = 5;
int col = 10;
int min = 1;
int max = 10;

int[,] initialMatrix = CreateMatrix(row, col, min, max);
PrintMatrix(initialMatrix);
Console.WriteLine("---------");
int[,] changedMatrix = ReplaceElements(initialMatrix);
PrintMatrix(changedMatrix);
