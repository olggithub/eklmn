// Задача № 10
// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1 

Console.Clear();
Console.Write("Введите трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n>99 & n<1000 | n>-1000 & n<-99)
                                    {
                                     int res=Math.Abs(Convert.ToInt32(n % 100)/10);
                                     Console.WriteLine("Второе число равно "+res);
                                    }
else
                                    {
                                     Console.WriteLine("Число не является трехзначным");
                                    } 