﻿/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

using static System.Console;

Clear();

System.Console.Write("Введите чмисло --> ");
int num = Convert.ToInt32(ReadLine());

int i = 1;

while(i<=num)
{
Write($"{Math.Pow(i,3)},");
i++;
}