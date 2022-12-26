// Задача 50. Напишите программу, которая на вход принимает число, и возвращает индексы числа в двумерном массиве или же указание,
//  что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4



Console.Write("Введите количество строк: ");
int n = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите нужное число: ");
int searchNumber = int.Parse(Console.ReadLine());



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

int indexNumber1 = -1;
int indexNumber2 = -1;


for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {

        if (searchNumber == array[i, j])
        {
            indexNumber1 = i;
            indexNumber2 = j;
        }
    }
   
}
 Console.WriteLine();

if (indexNumber1 == -1 || indexNumber2 == -1)
{
    Console.WriteLine("Цифра отсутствует в массиве");
}

else
{
    Console.WriteLine(indexNumber1);
    Console.WriteLine(indexNumber2);
}

