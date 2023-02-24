// Задача 2: Напишите программу, которая на вход принимает 
// два числа и выдает, какое число большее, а какое меньшее.

Console.Write("Vvedite pervoe naturalnoe chislo: ");
int x = int.Parse(Console.ReadLine());

Console.Write("Vvedite vtoroe naturalnoe chislo: ");
int y = int.Parse(Console.ReadLine());

int max = 0;

if (x > y)
{
    max = x;
    Console.WriteLine($"{max} Bolshe");
}
else
{
    max = y;
    Console.WriteLine($"{max} Bolshe");
}