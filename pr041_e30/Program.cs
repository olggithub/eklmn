// Задача 30
// Напишите программу, которая заполняет массив из восьми элементов 0 и 1 в случайнм порядке

int [] m = new int [8];
int i= 0;

Console.Clear();
for (i = 0; i < 8; i++) 
{
m[i] = new Random().Next(0,2);
Console.WriteLine($"m{i+1} = {m[i]}");
}