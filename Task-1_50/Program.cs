// Показать двумерный массив размером m×n заполненный вещественными числами

double[,] CreateTable(int m, int n)
{
    double[,] table = new double[m, n];
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i, j] = (new Random()).Next(-20,80)/10.0; // new Random().NextDouble() * 100; - так выдает очень длинные дроби, с диапазоном лучше работает
        }
    }
    return table;
}

void PrintTable(double[,] tab)
{
    for (int i = 0; i < tab.GetLength(0); i++)
    {
        for (int j = 0; j < tab.GetLength(1); j++)
        {
            Console.Write(tab[i, j] + "   ");
        }
        Console.WriteLine();
    }
}

Console.Write($"Задайте m: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write($"Задайте n: ");
int n = int.Parse(Console.ReadLine() ?? "0");
double[,] newTable = CreateTable(m, n);
PrintTable(newTable);
