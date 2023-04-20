// В прямоугольной матрице найти строку с наименьшей суммой элементов.

int[,] FillMatrix(int row, int col, int min, int max)
{
    int[,] array = new int[row, col];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max);
        }
    }
    return array;
}

int FindRow(int[,] array)
{
    int index = 0;
    int sum = 0;
    int result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (i == 0) result = sum;
        else if (sum < result)
        {
        result = sum;
        index = i;
        }
    }
    return index;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "  ");
        }
        Console.WriteLine();
    }
}

int row = 5;
int col = 7;
int min = 1;
int max = 10;

int[,] matrix = FillMatrix(row, col, min, max);
PrintMatrix(matrix);
Console.WriteLine("***********");
int index = FindRow(matrix);
Console.WriteLine($"Наименьшая сумма элементов в строке с индексом {index}");