// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


Console.WriteLine("Трехмерный массив размером 2 x 2 x 2: ");
int[,,] array = new int[2, 2, 2];
FillArray(array);
PrintArray(array);



void FillArray(int[,,] array)
{
    int[] matrix1 = new int[array.Length];
    int number;
    for (int i = 0; i < matrix1.Length; i++)
    {
        matrix1[i] = new Random().Next(10, 100);
        number = matrix1[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (matrix1[i] == matrix1[j])
                {
                    matrix1[i] = new Random().Next(10, 100);
                    j = 0;
                    number = matrix1[i];
                }
            }
        }
    }
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = matrix1[count];
                count++;
            }
        }
    }

}




void PrintArray(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
                Console.Write($"{matrix[i, j, k]} ({i},{j},{k}) \t");
            Console.WriteLine();
        }
    }
}


