// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


int[] array = new int[5];
Random Random = new Random();

double sumElem = 0;
double sumElem2 = 0;

Console.WriteLine();
Console.Write("[");

for (int i = 0; i < array.Length; i++)   // В примере указано так: [3, 7, 23, 12] -> 19      Если i = 1   [3, 7, 23, 12] -> 26 
{

    array[i] = Random.Next(-100, 101);
    Console.Write("  " + array[i] + "  ");

    if (i % 2 > 0)
    {
        sumElem = sumElem + array[i];
    }
 }

Console.WriteLine("]");
Console.WriteLine();

Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях: {sumElem}");