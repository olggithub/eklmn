// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
//  82 -> 10
//9012 -> 12

Console.Clear();
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int i=0;
int j=1;
int ch=0;
int sum=0;
for(i=0;i<10;i++)
{
 if (i>0)ch = Convert.ToInt32(((num % (Math.Pow(10,i+1))) - (num % (Math.Pow(10,i)))) /(Math.Pow(10,i)));
 else ch = Convert.ToInt32((num % (Math.Pow(10,i+1))) /(Math.Pow(10,i)));
 sum = sum + ch;
 j=Convert.ToInt32(num % (Math.Pow(10,i+1)));
 if (num-j == 0) break;
}
Console.WriteLine($"Сумма = {sum}");