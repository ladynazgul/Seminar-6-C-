// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов

void FillArray(int [,] array, int min, int max)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max);
        }
    }
}

void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

double[] GetAverage(int[,] matrix)
{
    double[] average = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum = sum + matrix[i, j];
        }
        average[j] = Math.Round((Convert.ToDouble(sum) / Convert.ToDouble(matrix.GetLength(0))), 1);
    }
    return average;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($" # {i + 1} = {array[i]}  ");
    }
}

Console.Write(" Введите количество строк ");
int x = int.Parse(Console.ReadLine() ?? "0");
Console.Write(" Введите количество столбцов ");
int y = int.Parse(Console.ReadLine() ?? "0");
int[,] matrix = new int [x, y];
FillArray(matrix, 0, 20);
PrintMatrix(matrix);
double[] average = GetAverage(matrix);
Console.WriteLine("Среднее арифметическое равно: ");
PrintArray(average);