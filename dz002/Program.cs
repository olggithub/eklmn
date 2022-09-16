// Задача 4
int i=0;
Console.Clear();
Console.Write("Введите число a : ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b : ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число с : ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

while (i<3)
           {
             if(max < b)
                        {
                          max = b;
                        }
             if(max < c)
                        {
                          max = c;
                        }      
            i++;              
           }

Console.WriteLine("max = "+max);