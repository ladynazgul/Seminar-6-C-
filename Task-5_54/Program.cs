// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

int[,] CreateMantrix(int row, int col, int min, int max)
{
    int[,] arr = new int[row, col];
    for (int i =0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(min, max);
        }
    }
    return arr;
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

double[] GetAverage(int[,] array)
{
    double[] result = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
            result[j] = sum / array.GetLength(1);
        }
    }
    return result;
}

void PrintArray(double[] array)
{
    Console.WriteLine("----------------------");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}  ");
    }
}

int row = 5;
int col = 5;
int min = 0;
int max = 20;

int[,] matrix = CreateMantrix(row, col, min, max);
PrintMatrix(matrix);
double[] average = GetAverage(matrix);
PrintArray(average);
Console.WriteLine();
Console.WriteLine();