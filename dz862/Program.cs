// Задача 62. 
// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();
int [,] matrixSpiral = new int [4,4];
int maxRow=4;
int maxCol=4;

int m=1;

for (int i=0;i<maxCol;i++)
{
    matrixSpiral[0,i]=m;
    m++;
}   


for (int i=1;i<maxRow;i++)
{
    matrixSpiral[i,maxCol-1]=m;
    m++;
}

for (int i=maxCol-2;i>=0;i--)
{
    matrixSpiral[maxRow-1,i] = m;
    m++;
}

for (int i=maxRow-2;i>=1;i--)
{
    matrixSpiral[i,0] = m;
    m++;
}

for (int i=1;i<=maxRow-2;i++)
{
    matrixSpiral[1,i] = m;
    m++;
}

for (int i=maxCol-2;i>=maxRow-3;i--)
{
    matrixSpiral[maxRow-2,i] = m;
    m++;
}

for(int i=0;i<maxRow;i++)
{
    for (int j=0;j<maxCol;j++) Console.Write($"{matrixSpiral[i,j]} ");
    Console.WriteLine();
}