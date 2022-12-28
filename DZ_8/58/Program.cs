// Задача 58: Задайте два двумерных массива (от 0 до 10). Напишите программу, которая будет находить произведение двух массивов (поэлементное).
// Например, даны 2 массива:
// 2 4
// 3 2

// 3 4
// 3 3
// Результирующая матрица будет:
// 6 16
// 9 6


Console.Write("Введите количество строк: ");
int n = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int m = int.Parse(Console.ReadLine());

int[,] array = new int[n, m];

int[,] array2 = new int[n, m];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(0, 10);
        Console.Write(array[i, j] + " ");

    }
    Console.WriteLine();
}

Console.WriteLine();

for (int i = 0; i < array2.GetLength(0); i++)
{
    for (int j = 0; j < array2.GetLength(1); j++)
    {
        array2[i, j] = new Random().Next(0, 10);
        Console.Write(array2[i, j] + " ");

    }
    Console.WriteLine();
}

Console.WriteLine();

for (int i = 0; i < array2.GetLength(0); i++)
{
    for (int j = 0; j < array2.GetLength(1); j++)
    {
        array2[i, j] = array2[i, j] * array[i, j]; 
        Console.Write(array2[i, j] + " ");
    }
    Console.WriteLine();
}

