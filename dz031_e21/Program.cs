// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int [ ] a = new int[3];
int [ ] b = new int[3];
int i = 0;

Console.Clear();

Console.WriteLine("Введите координаты точки A:");
for (i=0;i<3;i++) a[i]= Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B:");
for (i=0;i<3;i++) b[i]= Convert.ToInt32(Console.ReadLine());

double l = Math.Round(Math.Sqrt((Math.Pow((b[0]-a[0]),2) + Math.Pow((b[1]-a[1]),2) + Math.Pow((b[2]-a[2]),2))) ,2);

Console.WriteLine($"Расстояние между точками равно {l}");