// В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет

int[,] CreateMatrix(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j =0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max);
        }
    }
    return matrix;
}

int[] FindPosition(int[,] matr, int number)
{
    int[] position = new int[2];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] == number)
            {
                position[0] = i + 1;
                position[1] = j + 1;
                return position;
            }
        }
    }
    position[0] = -1;
    position[1] = -1;
    return position;
}

void PrintMatrix(int[,] matrix)
{
    Console.WriteLine("Массив:");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] / 1000 > 0) Console.Write($"{matrix[i, j]}  ");
            else if (matrix[i, j] / 100 > 0) Console.Write($" {matrix[i, j]}  ");
            else if (matrix[i, j] / 10 > 0) Console.Write($"  {matrix[i, j]}  ");
            else Console.Write($"   {matrix[i, j]}  ");
        }
        Console.WriteLine();
    }
}

void ShowPosition(int[] pos, int num)
{
    Console.WriteLine();
    if (pos[0] > 0 && pos[1] > 0) Console.WriteLine($"Число {num} есть в данном архиве. Находится в {pos[0]}-й строке, {pos[1]}-м столбце");
    else Console.WriteLine($"Числа {num} в данном массиве нет");
    Console.WriteLine();
}

int SetNumber()
{
    Console.WriteLine();
    Console.Write("Введите число: ");
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

int row = 5;
int col = 7;
int min = 10;
int max = 100;

int[,] mainMatrix = CreateMatrix(row, col, min, max);
PrintMatrix(mainMatrix);
int number = SetNumber();
int[] position = FindPosition(mainMatrix, number);
ShowPosition(position, number);

