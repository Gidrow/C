// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка





Console.Write("Введите количество строк: ");
int n = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int m = int.Parse(Console.ReadLine());

int count = 0;

int summ = 0;
int summMin = 999999;
int nMin = 0;



int[,] array = new int[n, m];



for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(0, 10);
        Console.Write(array[i, j] + " ");

    }
    Console.WriteLine();
}



for (int i = 0; i < array.GetLength(0); i++)
{

    for (int j = 0; j < array.GetLength(1); j++)
    {
        summ = summ + array[i, j];

    }
    if (summ < summMin)
    {
        summMin = summ;
        nMin = i;
    }
    summ = 0;
    Console.WriteLine();

}

Console.WriteLine($"Cтрока с наименьшей суммой элементов: {nMin}");  
Console.WriteLine($"Cумма элементов в строке: {summMin}");