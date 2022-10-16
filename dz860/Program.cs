// Задача 60. 
// ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();
int [, ,] myArray = new int [2,2,2];
int [] verifyArray = new int [8];
int count = 0;
int element;
int m=0;
int ind=0;

verifyArray[count] = new Random().Next(10,99);
count++;
   while(count<8)
            {
                element = new Random().Next(10,99);
                for(m=0;m<count;m++)
                {
                     if(verifyArray[m] == element) ind = 0;
                     else ind =  1;
                }      
                         if (ind == 1)
                        {
                        verifyArray[count] = element;    
                        count++;
                        }
            }

Console.WriteLine("массив: ");
count = 0;

for (int i=0; i<2;i++)
{
    for (int j=0; j<2;j++)
        {
            for (int k=0; k<2;k++)
        {   
            myArray[i,j,k]=verifyArray[count];
            Console.Write($"{myArray[i,j,k]}({i},{j},{k}) ");
            count++;         
        }
        Console.WriteLine();
        }
}

