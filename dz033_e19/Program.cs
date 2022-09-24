// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

//Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());

if(n>9999 & n<100000)
                     {
                        int n1 =Convert.ToInt32(((n % 100000)-(n % 10000))/10000);
                        int n2 =Convert.ToInt32(((n % 10000)-(n % 1000))/1000);
                        int n4 = Convert.ToInt32(((n % 100)-(n % 10))/10);
                        int n5 = Convert.ToInt32(n % 10);
                              
                        if (n1==n5 & n2==n4)   Console.WriteLine("Число является палиндромом"); 
                        else                   Console.WriteLine("Число не является палиндромом");
                     }                                         
else Console.WriteLine("Число не является пятизначным");