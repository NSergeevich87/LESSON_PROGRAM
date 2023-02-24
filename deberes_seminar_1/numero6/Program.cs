// Задача 6: Напишите программу, которая на вход принимает число и выдает, 
// является ли число четным (делится ли оно на два без остатка).

Console.Write("Vvedite chislo y poluchite otvet delitsya li ono na 2: ");
int N = int.Parse(Console.ReadLine());

if (N % 2 == 0)
{
    Console.WriteLine("Chislo delitsya na 2, a znachit ono chetnoe");
}
else
{
    Console.WriteLine("Chislo ne delitsya na 2, a znachit ono NE chetnoe");
}