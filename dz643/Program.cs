// SЗадача 43: 
// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
double [,] masKoef = new double[2,2];
double [] tochka = new double [2];
Console.Write ("Введите К1: ");
masKoef[0,0] = Convert.ToDouble(Console.ReadLine());
Console.Write ("Введите B1: ");
masKoef[0,1] = Convert.ToDouble(Console.ReadLine());
Console.Write ("Введите К2: ");
masKoef[1,0] = Convert.ToDouble(Console.ReadLine());
Console.Write ("Введите B2: ");
masKoef[1,1] = Convert.ToDouble(Console.ReadLine());


    double [] XYPoint(double [,] Koef)
{
    double [] XY = new double [2];
    XY[0] = (Koef[1,1] - Koef[0,1])/(Koef[0,0]-Koef[1,0]);   // x = (b2-b1)/(k1-k2)
    XY[1] = XY[0]*Koef[1,0]+Koef[1,1];                       // y = k2*x+b2
    return XY;
}

tochka = XYPoint (masKoef);
Console.WriteLine($"Координаты точки пересечения: ({tochka[0]} ; {tochka[1]})");