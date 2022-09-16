// Задача 8
int i = 1;
Console.Clear();
Console.Write("Введите число : ");
int a = Convert.ToInt32(Console.ReadLine());
if(a>0)
           {
            
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
           }
 else
      {
        Console.Write("Число должно быть больше 0");
      }          