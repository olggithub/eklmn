// Задача 41: 
// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();
Console.Write("Введите количество чисел: ");
int m = Convert.ToInt32(Console.ReadLine());

int numMoreZero (int kolNum)
{
    int sum=0;
    int [] numMas = new int [kolNum];
    for(int i = 0; i<kolNum; i++)
    {
        Console.Write($"Введите число {i+1}: ");
        numMas[i] = Convert.ToInt32(Console.ReadLine());
        if (numMas[i] > 0) sum++ ;
    }
     
     return sum;
}

Console.WriteLine($"Количество положительных чисел: {numMoreZero(m)}");