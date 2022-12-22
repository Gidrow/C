// Доп.Задача Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

// [1 2 3 4 5] -> 5 8 3

// [6 7 3 6] -> 36 21


int[] array = new int[6];
Random Random = new Random();

int count = 0;

Console.WriteLine();
Console.Write("[");

for (int i = 0; i < array.Length; i++)
{

    array[i] = Random.Next(100, 1000);
    Console.Write("  " + array[i] + "  ");

}

Console.WriteLine("]");

Console.Write("[");

int j = 0; // Индекс значения массива

int k = 1; // Для движения влево по массиву  array[array.Length - k])  k += 1;

while (j < array.Length / 2)

{
    Console.Write("  " + array[j] * (array[array.Length - k]) + "  ");
    j = j + 1;
    k += 1;
}


Console.WriteLine("]");
Console.WriteLine();
