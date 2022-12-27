// Задача 1:
// Напишите программу, которая принимает на вход число N и выдаёт сумму чисел от 1 до N.
// 7 -> 28
// 4 -> 10
// 8 -> 36


// Console.Write("Введите число N ");
// int N = int.Parse(Console.ReadLine());
// int sum = 0;

// for (int count = 0; count < N; count++)
// {
//     sum = sum + count;
// }
// Console.WriteLine(sum);


// int[] array = new int[8];
// for (int i = 0; i<array.Length;i++)
// {
//     array[i] = new Random().Next(0, 2);
//     Console.WriteLine(" "+array[i]);
// }



// int[] Array =new int[8];
// for (int i=0; i<Array.Length; i++) 
// {
    
// Array[i] = new Random().Next(0,2);
// Console.Write(","+Array[i]);

// }



Console.Write("Введите число N ");
int N = int.Parse(Console.ReadLine());

int G (int a)
{
      int sum = 1;  
         for (int i=1; i<=a; i++) sum=sum*i;
         
return sum;
}

Console.Write(G(N));
