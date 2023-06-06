// Задача 58: Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц
// Например, даны 2 матрицы:            Результирующая матрица будет:
// 2 4 | 3 4                            18 20
// 3 2 | 3 3                            15 18



int[,] array1 = GetArray();
int[,] array2 = GetArray();
if (array1.GetLength(1) == array2.GetLength(1) && array1.GetLength(0) == array2.GetLength(0))
{
    Console.WriteLine("Новый массив: ");
    PrintArray(CompositionOfArrays(array1, array2));
}
else Console.WriteLine("Размерности массивов не совпадают, невозможно найти произведение двух массивов");


int[,] GetArray()
{
    int rows = Prompt("Введите количество строк массива: ");
    int columns = Prompt("Введите количество столбцов массива: ");
    int[,] array = new int[rows, columns];
    FillArray(array, rows, columns, -10, 50);
    PrintArray(array);
    return array;
}


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


int[,] CompositionOfArrays(int[,] matrix1, int[,] matrix2)
{
    int[,] UserArray = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            int sum = 0;
            int k = 0;
            while (k < matrix1.GetLength(1))
            {
                sum += matrix1[i, k] * matrix2[k, j];
                k++;
            }
            UserArray[i, j] = sum;
        }
    }
    return UserArray;
}
