// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.






int[,] array =
{
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4}
};

int[] arraySumm = { 0, 0, 0, 0 };

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i, j] + " ");

    }
    Console.WriteLine();
}

    int count = 0;

for (int i = 0; i < 4; i++)
{
    double summ = 0;


    double SummMeth()
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {

            for (int j = 0; j < array.GetLength(1); j++)
            {

                if (count == j) summ = summ + array[i, j];

            }

        }
        return summ;
    }

    double ys = SummMeth();
    count++;
    Console.Write($"            {Math.Round(ys/3, 2)}   ");
    

}












// double[,] array =
// {
//     {1, 4, 7, 2},
//     {5, 9, 2, 3},
//     {8, 4, 2, 4}
// };

// int count = 0;

// double summ = 0;

// double summ1 = 0;
// int Position1 = 0;

// double summ2 = 0;
// int Position2 = 1;

// double summ3 = 0;
// int Position3 = 2;

// double summ4 = 0;
// int Position4 = 3;



// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         Console.Write(array[i, j] + " ");

//     }
//     Console.WriteLine();
// }




// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         if (j == Position1) summ1 = summ1 + array[i, j];
//         if (j == Position2) summ2 = summ2 + array[i, j];
//         if (j == Position3) summ3 = summ3 + array[i, j];
//         if (j == Position4) summ4 = summ4 + array[i, j];
//     }
//     Console.WriteLine();
// }


// Console.WriteLine($"{Math.Round(summ1/3, 2)} {Math.Round(summ2/3, 2)} {Math.Round(summ3/3, 2)} {Math.Round(summ4/3, 2)}"); 

// Console.WriteLine();
