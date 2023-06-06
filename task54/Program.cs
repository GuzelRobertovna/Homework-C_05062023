// Задача 54: Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива.


int rows = Prompt("Введите количество строк массива: ");
int columns = Prompt("Введите количество столбцов массива: ");
int[,] array = new int[rows, columns];
FillArray(array, rows, columns, -10, 60);
PrintArray(array);
Console.WriteLine($"Новый массив (элементы каждой строки упорядочены по убыванию):");
PrintArray(GetDecreaseArray(array));


int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine()!;
    int result = Convert.ToInt32(value);
    return result;
}


void FillArray(int[,] matrix, int m, int n, int minValue, int maxValue)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
}


void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}    ");
        }
        Console.WriteLine();

    }
}


int[,] GetDecreaseArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            GetNewArray(matrix, i);
        }
    }
    return matrix;
}


int[,] GetNewArray(int[,] matrix, int k)
{
    for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        if (matrix[k, j] < matrix[k, j + 1])
        {
            int temp = matrix[k, j];
            matrix[k, j] = matrix[k, j + 1];
            matrix[k, j + 1] = temp;
        }
    return matrix;
}