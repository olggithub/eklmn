// Задача 64: 
// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


Console.Clear();
Console.Write("Введите значение N: ");
int x = Convert.ToInt32(Console.ReadLine());

if (x>0)
{
int Chisla(int n)
{
    if (n == 1) 
    {  
        Console.Write($"{n}");
        return 1;
    }

    Console.Write($"{n}, ");
    return Chisla(n-1);
}

Chisla(x);
}
 else Console.WriteLine("Число должно быть больше 0");