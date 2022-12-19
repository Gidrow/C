// Console.WriteLine("Введите число: ");
// int a = int.Parse(Console.ReadLine()!);
// String b = a.ToString();


//    if (b[0] == b[4] && b[1] == b[3])
//     {
//         Console.Write("Число является палиндромом. ");
//     }
//     else
//     {
//         Console.Write("Число не является палиндромом. ");
//     }


Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
String b = a.ToString();


 if (b.Length == 5)
 {

   if (b[0] == b[4] && b[1] == b[3])
    {
        Console.Write("Число является палиндромом. ");
    }
    else
    {
        Console.Write("Число не является палиндромом. ");
    }
 }
 else
 {
   Console.Write("Введено неверное число. "); 
 }