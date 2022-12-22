// // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


int[] array = new int[10];
Random Random = new Random();

int colElem = 0;

Console.WriteLine();
Console.Write("[");

for (int i = 0; i < array.Length; i++)
{

    array[i] = Random.Next(100, 1000);
    Console.Write("  " + array[i] + "  ");

    if (array[i] % 2 == 0)
    {
        colElem = colElem + 1;
    }
}
Console.WriteLine("]");
Console.WriteLine();
Console.WriteLine($"Кколичество чётных чисел в массиве: {colElem}");