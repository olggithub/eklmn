// Задача 52. 
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

if(razmRow>0 & razmCol>0)
{
int [,] myArray = new int [razmRow,razmCol];
myArray = CreateIntArray (razmRow,razmCol,1,99);

double [] sredArray = new double [razmRow];

for (int m=0; m<razmRow;m++)
{
    for (int n=0; n<razmCol;n++)
        {
            Console.Write($"{myArray[m,n]} ");
            sredArray[n] = sredArray[n] + myArray[m,n];
            if (m == (razmRow-1)) sredArray[n] = Math.Round (sredArray[n] / razmRow,1);
           //  Console.Write($"{sredArray[n]} ");

        }
        Console.WriteLine(); 
}

 Console.WriteLine("Среднее арифметическое: ");
 for (int s = 0 ; s < razmRow; s++) Console.Write($"{sredArray[s]} ");
// Console.WriteLine($"Значение равно: {myArray[nRow-1,nCol-1]} ");
}
else  Console.WriteLine("Вне диапазона");