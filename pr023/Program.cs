Console.WriteLine("Введите число 1: ");

int ch1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2: ");
int ch2 = Convert.ToInt32(Console.ReadLine());


if (ch1 % ch2 == 0)
                  {
                    Console.WriteLine("числа кратны");
                  }
else
                  {
                    Console.WriteLine("числа не кратны");
                    Console.WriteLine("остаток от деления равен "+ch1 % ch2);
                  }                  