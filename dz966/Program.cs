﻿// Задача 66: 
// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
Console.Write("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n>0 & m>0 & n>=m)
{
int SumChis(int x,int y)
{
    
    if (y == m) return m;
    return y + SumChis(x, y-1);
}

Console.WriteLine($"{SumChis(m,n)}");
}

else Console.WriteLine("Числа n и m должны быть больше 0 и n>=m"); 
