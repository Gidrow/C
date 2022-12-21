// Задача 29: Напишите программу, которая задаёт массив из 8 случайных чисел (-10, 10) и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]



int[] array = new int[8];
Random Random = new Random();

Console.WriteLine();
Console.Write("[");

for (int i = 0; i < array.Length; i++)
{

    if (array[i] <= 8)
    {
    array[i] = Random.Next(-10, 10);
    
    Console.Write("  " + array[i] + "  ");
    }

}

Console.WriteLine("]");
Console.WriteLine();