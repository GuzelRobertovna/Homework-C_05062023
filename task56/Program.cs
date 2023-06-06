// Задача 56: Задайте прямоугольный двумерный массив. Напишите
// программу, которая будет находить строку с наименьшей суммой элементов

int rows = Prompt("Введите количество строк массива: ");
int columns = Prompt("Введите количество столбцов массива: ");
int[,] array = new int[rows, columns];
FillArray(array, rows, columns, -10, 60);
PrintArray(array);
MinSumofElements(array);


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
            Console.Write($"[{matrix[i, j]}]   ");
        }
        Console.WriteLine();

    }
}


void MinSumofElements(int[,] matrix)
{
    int summa = GetNewArray(matrix, 0);
    int count = 0;
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        if (GetNewArray(matrix, i) < summa) count = i;
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов {count + 1}: ");
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"[{matrix[count, j]}]   ");
    }
    Console.WriteLine();
}


int GetNewArray(int[,] matrix, int k)
{
    int sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
        sum += matrix[k, j];
    return sum;
}