// Задача 34: 
// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
Console.Write("Введите размер массива: ");
int razm = Convert.ToInt32(Console.ReadLine());

 int MasKolChet(int razmer)
{
    int[] m = new int [razmer];
    int i = 0;
    int kolchet = 0;
    for (i=0;i<razmer;i++) 
    {
    m[i] = new Random().Next(100,1000);
    if (m[i]%2 == 0) kolchet++;
    Console.Write(m[i]+", ");
    }
    return kolchet;
}

 Console.WriteLine($"Кол-во четных {MasKolChet(razm)}");