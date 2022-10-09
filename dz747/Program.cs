// Задача 47. 
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();
double [,] mnMassiv = new double [3,4];

 double GetRandomeNumber(double minimum, double maximum, int kolvoZnakov)
{
    Random random = new Random();
    return Math.Round ((random.NextDouble() * (maximum - minimum) + minimum), kolvoZnakov);
}

for(int i=0;i<3;i++)
{
                    for(int j=0; j<4; j++)
                    {
                            mnMassiv [i,j] = GetRandomeNumber(-10.00, 10.00,1);
                            Console.Write($"{mnMassiv [i,j]} ");
                    }
Console.WriteLine();
}
