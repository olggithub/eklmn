// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//      6, 1, 33 -> [6, 1, 33]

int i = 0;
int n = 8;
int [] m = new int [n];

Console.Clear();
Console.WriteLine("Массив из восьми элементов:");
Console.Write("[");

for(i = 0; i < 8; i++)
                      {
                        if (i < n-1)
                                    {
                                      m[i] = new Random().Next(1,100);
                                      Console.Write($"{m[i]}, ");
                                    }
                        else         
                                    {
                                      m[i] = new Random().Next(1,100);
                                      Console.Write($"{m[i]}");
                                    }                                 
                      }
Console.Write("]");