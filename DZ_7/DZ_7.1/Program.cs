// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами от -10,0 до 10,0.

// m = 3, n = 4.

// 0,5 7,0 -2,0 -0,2

// 1,0 -3,3 8,0 -9,9

// 8,0 7,8 -7,1 9,0



Console.Write("Введите число N ");
int n = int.Parse(Console.ReadLine());

Console.Write("Введите число N ");
int m = int.Parse(Console.ReadLine());


double[,] array = new double[n, m];   




for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double number = new Random().Next(-10, 11) + new Random().NextDouble();
        array[i, j] = Math.Round(number, 1);

        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}