// Задача 25: 
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int result;

Console.Clear();

Console.WriteLine("Введите число A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int b = Convert.ToInt32(Console.ReadLine());

if(b>0)
{
int stepen(int number, int pokaz)
{
 int stepen=1;
 int i = 0;
  for (i=0;i<pokaz;i++)
 { 
  stepen=stepen*number;
 }  
 if (number == 0) stepen = 1;
 return stepen;
}
result = stepen(a,b);
Console.WriteLine($"Результат равен : {result}");
}
else Console.WriteLine("Показатель степени должен быть > 0");