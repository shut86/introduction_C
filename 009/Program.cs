﻿//9. Вывести на экран четные числа от 1 до N

int n=Convert.ToInt32(Console.ReadLine());
int i=2;
while(i<=n)
{
    System.Console.Write($"{i} ");
    i=i+2;
}