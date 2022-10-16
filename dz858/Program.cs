// Задача 58: 
// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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
Console.Write($"Введите размерность матриц: ");
int razmMatr = Convert.ToInt32(Console.ReadLine());


if(razmMatr>1)
{
int [,] matrixA = new int [razmMatr,razmMatr];
matrixA = CreateIntArray (razmMatr,razmMatr,1,10);

int [,] matrixB = new int [razmMatr,razmMatr];
matrixB = CreateIntArray (razmMatr,razmMatr,1,10);

int [,] matrixC = new int [razmMatr,razmMatr];

Console.WriteLine("Матрица А");
for (int m=0; m<razmMatr;m++)
{
    
    for (int n=0; n<razmMatr;n++)
        {
            Console.Write($"{matrixA[m,n]} ");
        }
        Console.WriteLine();
       
}

 Console.WriteLine();

Console.WriteLine("Матрица B");
for (int m=0; m<razmMatr;m++)
{
    
    for (int n=0; n<razmMatr;n++)
        {
            Console.Write($"{matrixB[m,n]} ");
        }
        Console.WriteLine();
       
}

 Console.WriteLine();

Console.WriteLine("Результирующая матрица: ");
for (int m=0; m<razmMatr;m++)
{
    
    for (int n=0; n<razmMatr;n++)
        {
            for (int k=0;k<razmMatr;k++) matrixC[m,n] += matrixA[m,k]*matrixB[k,n];                
             Console.Write($"{matrixC[m,n]} ");
        }
        Console.WriteLine();
       
}


}
else  Console.WriteLine("Вне диапазона");