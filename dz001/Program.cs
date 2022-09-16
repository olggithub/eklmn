Console.Clear();
Console.Write("Введите число a : ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b : ");
int b = Convert.ToInt32(Console.ReadLine());
if (a == b)
           {
            Console.WriteLine("min = max = "+a);
           }
else
           {
            if(a<b)
                   {
                    Console.WriteLine("min = "+a);
                    Console.WriteLine("max = "+b);
                   }
             else
                   {
                    Console.WriteLine("min = "+b);
                    Console.WriteLine("max = "+a);
                   }
    
           }