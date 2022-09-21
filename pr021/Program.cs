int x = new Random().Next(10,99);
Console.WriteLine(x);
int ost = x % 10;
int des = (x-ost)/10;
if(des == ost)
                {
                 Console.WriteLine(ost);
                }
else if(des>ost)             
                {
                 Console.WriteLine(des);
                }
else
                {
                 Console.WriteLine(ost);
                }