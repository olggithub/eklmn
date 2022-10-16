// Задача 54: 
// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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
myArray = CreateIntArray (razmRow,razmCol,1,99);

Console.WriteLine("массив: ");
for (int m=0; m<razmRow;m++)
{
    for (int n=0; n<razmCol;n++)
        {
            Console.Write($"{myArray[m,n]} ");
        }
        Console.WriteLine();
}
Console.WriteLine("new массив: ");
int index = 0;
int max=0;

for (int m=0; m<razmRow;m++)
{
     for (int n=0; n<razmCol;n++)
        {
            max = myArray[m,n];
            index = n;
           for(int k = n; k<razmCol;k++)
           {
            if(myArray[m,k]>=max)
             {
                index = k;
                max = myArray[m,k];
             }
                
           }
                myArray[m,index]=myArray[m,n];
                myArray[m,n]=max;

           Console.Write($"{myArray[m,n]} ");
           
        }
        Console.WriteLine();
}
}
else  Console.WriteLine("Вне диапазона");