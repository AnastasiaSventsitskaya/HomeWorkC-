﻿// Принимает одно число и проверяет четное ли оно.


Console.WriteLine("Write first number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine("Это число четное");
}
else 
{
    Console.WriteLine("Это число нечетное");
}