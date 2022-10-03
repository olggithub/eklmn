// Задача 36: 
// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
Console.Write("Введите размер массива: ");
int razm = Convert.ToInt32(Console.ReadLine());

 int SumNeChet(int razmer)
{
    int[] m = new int [razmer];
    int i = 0;
    int sum = 0;
    for (i=0;i<razmer;i++) 
    {
    m[i] = new Random().Next(1,100);
    if (i %2 == 0) sum += m[i]; //Индекс должен быть четным, т.к. в задаче поставлено условие нечетная позиция, а не индекс.
    Console.Write(m[i]+", ");
    }
    return sum;
}

 Console.WriteLine($"Sum = {SumNeChet(razm)}");