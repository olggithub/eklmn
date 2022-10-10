// Задача 50.
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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
Console.Write($"Введите номер строки массива: ");
int nRow = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите номер столбца массива: ");
int nCol = Convert.ToInt32(Console.ReadLine());
if(nRow<=razmRow & nCol<=razmCol)
{
int [,] myArray = new int [razmRow,razmCol];
myArray = CreateIntArray (razmRow,razmCol,1,99);
for (int m=0; m<razmRow;m++)
{
    for (int n=0; n<razmCol;n++)
        {
            Console.Write($"{myArray[m,n]} ");
        }
        Console.WriteLine();
}
Console.WriteLine($"Значение равно: {myArray[nRow-1,nCol-1]} ");
}
else  Console.WriteLine("Вне диапазона");


