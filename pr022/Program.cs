int x = new Random().Next(100,999);
Console.WriteLine(x);
int ost = x % 10;
Console.WriteLine(ost);
int des = (x-ost) % 100;
Console.WriteLine(des);
int res = (x-des-ost)/10+ost;
Console.WriteLine(res);
 
