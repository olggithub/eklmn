// Задача 6
Console.Clear();
Console.Write("Введите число : ");
int a = Convert.ToInt32(Console.ReadLine());
int ost = a%2;
if(ost == 0)
            {
             Console.WriteLine("Число является четным"); 
            }
else        
            {
             Console.WriteLine("Число является нечетным");
            }    