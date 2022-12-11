/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.Через строку решать нельзя.

645 -> 5

78 -> третьей цифры нет

32679 -> 6*/

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
if(num<100) Console.WriteLine($"третьей цифры нет");
else if (num>=1000)
  {while (num>=1000)

  { num = num/10 ;}
  int x=num%10;
Console.WriteLine($"третья цифра введенного числа - это {x}"); }
else
{int x=num%10;
Console.WriteLine($"третья цифра введенного числа - это {x}"); }
