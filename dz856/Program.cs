// Задача 56: 
// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();
int [,] CreateIntArray (int row, int col, int minZnach, int maxZnach)
{
    int [,] resArray = new int [row,col];
    for (int i=0; i< row; i++)
        {
            for (int j=0; j<col; j++)  resArray[i,j] = new Random().Next(minZnach, maxZnach);
        }
 return resArray;
}
Console.Write($"Введите кол-во строк массива: ");
int razmRow = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите кол-во столбцов массива: ");
int razmCol = Convert.ToInt32(Console.ReadLine());

if(razmRow>1 & razmCol>1)
{
int [,] myArray = new int [razmRow,razmCol];
myArray = CreateIntArray (razmRow,razmCol,1,10);
int minSumRow=0;
int sumRow = 0;
int minNumRow = 0;

for (int m=0; m<razmRow;m++)
{
    sumRow=0;
    for (int n=0; n<razmCol;n++)
        {
            Console.Write($"{myArray[m,n]} ");
            sumRow = sumRow + myArray[m,n];
        }
        Console.WriteLine();
        if (minSumRow > sumRow | m==0)
                {
                    minSumRow = sumRow;
                    minNumRow = m;
                }
}
 Console.WriteLine($"{minNumRow+1} строка ");
}
else  Console.WriteLine("Вне диапазона");