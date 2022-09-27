// Задача 24
// Написать программу, которая принимает на вход число А и выдает сумму чисел от 1 до А

Console.Clear();
Console.WriteLine("Введите число А");
int a = Convert.ToInt32(Console.ReadLine());
int result;

int summa_a(int number)
{
 int summa_a = 0;
 int i=1;
 while (i<=number)
 { 
    summa_a=summa_a+i;
    i++;
 }  
 return summa_a;
}

result = summa_a(a);
Console.WriteLine($"Сумма чисел равна : {result}");