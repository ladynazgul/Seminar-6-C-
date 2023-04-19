// В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет

int[,] FillArray(int row, int col, int min, int max)
{
    Random random = new Random();
    int[,] matrix = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            matrix[i, j] = random.Next(min, max);
        }
    }
    return matrix;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

bool CompareNumber(int[,] arr, int number)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == number)
                return true;
        }
    }
    return false;
}

void PrintIndices(int[,] array, int number)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == number)
                Console.WriteLine($"[{i} , {j}] ");
        }
    }
}

int[,] matr = FillArray(5, 6, 0, 20);
PrintArray(matr);
Console.WriteLine();
Console.WriteLine("Задайте число n: ");
int n = int.Parse(Console.ReadLine() ?? "0");
bool contain = CompareNumber(matr, n);
if (contain == true)
    {
        Console.WriteLine($"Заданное число находится на следующих позициях: ");
        PrintIndices(matr, n);
    }
else
    Console.WriteLine($"Такого числа нет среди элементов данного массива. ");


