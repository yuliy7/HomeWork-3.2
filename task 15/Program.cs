﻿/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/

Console.WriteLine("Введите цифру, обозначающую день недели");
int num = Convert.ToInt32(Console.ReadLine());
if(num>7)  Console.WriteLine($"Вы ввели неверное число");
else if (num<1) Console.WriteLine($"Вы ввели неверное число");
else if (num<5) Console.WriteLine($"нет");
else Console.WriteLine($"да");
