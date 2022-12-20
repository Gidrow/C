Console.Write("Введите первое число: ");
Double FN = Double.Parse(Console.ReadLine()!);

Console.Write("Введите второе число: ");
Double SN = Double.Parse(Console.ReadLine()!);


 if ( FN % SN == 0 )
   {
       Console.Write("Первое число кратно второму");
   }
   else
   {
    Console.Write("Вывод остатка: ");
    Console.WriteLine(FN % SN);
  }


Console.WriteLine("Введите число: ");
var entNumber = Convert.ToInt32(Console.ReadLine());
var firstPer = 7;
var secondPer = 23;
if (entNumber % firstPer == 0 && entNumber % secondPer == 0)
{
    Console.Write("Введенное число кратно числам: ");
    Console.WriteLine(firstPer);
    Console.Write(" и ");
    Console.WriteLine(secondPer);
}
else
{
   Console.WriteLine("Введенное число не кратно заданным числам.");
}


Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine()!);

int N1 = (N) * (-1);

while (N1 <= N)
{
    Console.WriteLine(N1);
    N1++;

}
