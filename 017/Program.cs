﻿//17. Дано число обозначающее день недели. Выяснить является номер дня недели выходным

System.Console.WriteLine("Введите число от 1 до 7: ");
int a=Convert.ToInt32(Console.ReadLine());
if (a == 6 || a == 7) 
{
    System.Console.WriteLine("Сегодня выходной");
}
else 
{
    System.Console.WriteLine("Сегодня рабочий день");
}