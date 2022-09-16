// Задача 8
int i = 0;
Console.Clear();
Console.Write("Введите число : ");
int a = Convert.ToInt32(Console.ReadLine());
if(a<0)
           {
            i=a;
            a=0;
           }

Console.Write("Результат : ");
while(i<=a)
           {
int ost = i%2;
if(ost == 0)
            {
             Console.Write(i+", "); 
             i++;
            }
else        
            {
             i++;
            }    
           }