// Задача 13: 
Console.Clear();
Console.Write("Введите число от 3 до 9 знаков: ");
int n = Convert.ToInt32(Console.ReadLine());
int ot=100;
int kon=1000;
int i=0;
int res=0;
int otn=0;
if (n>99 & n>1000000000) 
          {
            Console.WriteLine("Число не соответствует допустимому диапазону");
          }
else      {
            for (i=0;i<10;i++) 
                              {                                                       
                                if (n>(ot-1) & n<kon)
                                                      {
                                                        if(i==0)
                                                                 { 
                                                                  res=Convert.ToInt32(n % (ot/10));
                                                                 }
                                                        else
                                                                 { 
                                                                  res=Convert.ToInt32(n % (ot/10));
                                                                  otn = Convert.ToInt32(res % (Math.Pow(10,i)));
                                                                  res=Convert.ToInt32((res-otn)/(Math.Pow(10,i)));
                                                                  Console.WriteLine("Третье число равно "+res);
                                                                  break;
                                                                 }
                                                      }          
                          else
                               {
                                ot=ot*10;
                                kon=kon*10;
                                }
                                                        }
          }