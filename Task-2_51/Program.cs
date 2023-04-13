// Задать двумерный массив следующим правилом: Aₘₙ = m+n

int[,] CreateMatrix(int row, int col)
{
    int[,] matr = new int[row, col];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = i + j + 2;
        }
    }
    return matr;
}

void PrintTable(int[,] tab)
{
    for (int i = 0; i < tab.GetLength(0); i++)
    {
        for (int j = 0; j < tab.GetLength(1); j++)
        {
            Console.Write($"{tab[i, j]} ");
        }
        Console.WriteLine();
    }
}

int row = new Random().Next(5, 11);
int col = new Random().Next(10, 16);

int[,] table = CreateMatrix(row, col);
PrintTable(table);
