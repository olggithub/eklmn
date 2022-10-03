// Задача 38: 
// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();
Console.Write("Введите размер массива: ");
int razm = Convert.ToInt32(Console.ReadLine());

 int RaznMaxMin(int razmer)
{
    int[] m = new int [razmer];
    int i = 0;
    int min = m[i] = new Random().Next(1,100);
    Console.Write(m[i]+", ");
    int max = min;
    int razn=0;
    for (i=1;i<razmer;i++) 
    {
    m[i] = new Random().Next(1,100);
    if (min > m[i]) min = m[i]; 
    if (max < m[i]) max = m[i];
    Console.Write(m[i]+", ");
    }
  
    razn = max - min;
    return razn;
}
Console.WriteLine($"max - min = {RaznMaxMin(razm)}");