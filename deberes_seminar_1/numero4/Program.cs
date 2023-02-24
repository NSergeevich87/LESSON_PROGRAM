// Задача 4: Напишите программу, которая принимает на вход 
// три числа и выдает максимальное из этих чисел.

Console.Write("Vvedite pervoe chislo: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Vvedite vtoroe chislo: ");
int b = int.Parse(Console.ReadLine());

Console.Write("Vvedite tretye chislo: ");
int c = int.Parse(Console.ReadLine());

int max = 0;

//if (a > b)
//{
//    if (a > c)
//    {
//        max = a;
//        Console.WriteLine($"max = {max}");
//    }
//    else
//    {
//    max = c;
//    Console.WriteLine($"max = {max}"); 
//    }
//    
//}
//else
//{
//    if (b > c)
//{
//    max = b;
//    Console.WriteLine($"max = {max}");
//}
//else
//{
//max = c;
//Console.WriteLine($"max = {max}");
//}
//}

if (a > b & a > c)
{
    max = a;
    Console.WriteLine($"max = {max}");
}
else 
{
    if (b > c)
    {
    max = b;
    Console.WriteLine($"max = {max}");  
    }
    else
    {
    max = c;
    Console.WriteLine($"max = {max}");
    }
}