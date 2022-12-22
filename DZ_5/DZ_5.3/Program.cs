// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76



int[] array = new int[10];
Random Random = new Random();

int Max = 1;
int Min = 100;

Console.WriteLine();
Console.Write("[");

for (int i = 0; i < array.Length; i++)
{

    array[i] = Random.Next(1, 101);
    Console.Write("  " + array[i] + "  ");

    if (array[i] > Max)
    {
        Max = array[i];
    }

    if (array[i] < Min)
    {
        Min = array[i];
    }

}
Console.WriteLine("]");
Console.WriteLine();
Console.WriteLine($"Элемент массива с  минимальным  значением: {Min}");
Console.WriteLine($"Элемент массива с максимальным  значением: {Max}");

Console.WriteLine($"Разница между максимальным  {Max} и минимальным {Min} элементов массива.");
Console.WriteLine();

Console.WriteLine($"{Max} - {Min} = {Max -Min}"); 
Console.WriteLine();

