﻿// Напишите программу, которая на вход принимает 
// число (N), а на входе показывает все четные числа 
// от 1 до N
// 8 => 2, 4, 6, 8

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

for(int i = 1; i <= number; i++)
{
    if(i % 2 == 0)
    {
        System.Console.Write(i + " ");
    }
}