// В двумерном массиве n×k заменить четные элементы на противоположные

int[,] CreateTable(uint row, uint col, int min, int max)
{
    int[,] originTab = new int[row, col];
    for (int i = 0; i < originTab.GetLength(0); i++)
    {
        for (int j = 0; j < originTab.GetLength(1); j++)
        {
            originTab[i, j] = new Random().Next(min, max + 1);
        }
    }
    return originTab;
}

int[,] ReplaceElements(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] % 2 == 0) matrix[i, j] = matrix[i, j] - 1;
        }
    }
    return matrix;
}

void PrintTable(int[,] matr)
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

int[,] originMatrix = CreateTable(5, 4, 0, 20); // если задано показать массив размером m*n, то количество строк и столбцов должно отличаться, вроде, правильно поняла?
PrintTable(originMatrix);
Console.WriteLine("---------------");
int[,] replacedMatrix = ReplaceElements(originMatrix);
PrintTable(replacedMatrix);
