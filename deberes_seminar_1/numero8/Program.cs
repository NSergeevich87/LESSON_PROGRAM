// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

Console.Write("Vvedite naturalnoe chislo: ");
int N = int.Parse(Console.ReadLine());

int count = 0;

if (N < 0)
{
    while (count > N+1)
   {
    count -= 2;    
    Console.Write($" {count}");
   }
}
else
{
    while (count < N-1)
   {
    count += 2;    
    Console.Write($" {count}");
   }
}
