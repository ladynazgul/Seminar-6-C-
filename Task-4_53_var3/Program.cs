// решение препода, задача по нахождению числа в массиве

int[,] CreateMatrix(int row, int col, int min, int max)
{
    var random = new Random();
    int[,] matrix = new int[row, col];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = random.Next(min, max);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}


// int[]? FindMatrixIndexes(int[,] matrix, int number)
// {
//     int[]? result = null;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if(matrix[i, j] == number)
//             {
//                 result = new int[2] {i, j};
//                 return result;
//             }
//         }
//     }
//     return result;
// }

// вариант "кортеж"
(int, int)? FindMatrixIndexes(int[,] matrix, int number)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(matrix[i, j] == number)
            {
                return (i, j);
            }
        }
    }
    return null;
}

int[,] matrix = CreateMatrix(3, 3, 1, 20);
Console.WriteLine("Your matrix:");
PrintMatrix(matrix);
Console.Write("Enter a number to find in matrix: ");
int number = int.Parse(Console.ReadLine() ?? "0");
// int[]? result = FindMatrixIndexes(matrix, number);
var result = FindMatrixIndexes(matrix, number);
if(result == null)
// if(result[0] == -1 && result[1] == -1)
    Console.WriteLine("There is no number in matrix");
else
    Console.WriteLine($"Found number in matrix in {result.GetValueOrDefault().Item1} {result.GetValueOrDefault().Item2} positions");

// При варианте без null строка 71 изменяется на if(result[0] == -1 && result[1] == -1)