// Задача 15: 
// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите число дня недели: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n>0 & n<8)
              {
                if (n==6 | n==7)
                              {
                                Console.WriteLine("Этот день выходной! Урааа!!!");
                              }
                else
                              {
                                Console.WriteLine("Этот день рабочий. :-(((((((");
                              }
              }

else          
              {
               Console.WriteLine("Error : Число должно быть от одного до 7");
              }            