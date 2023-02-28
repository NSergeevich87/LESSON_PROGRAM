
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

System.Console.Write("Vvedite trej znachnoe chislo: ");
int number = int.Parse(Console.ReadLine());

if (number < 0)
{
    number = number * (-1);
}

if (number < 100 | number > 999)
{
    System.Console.WriteLine("Eto ne trej znachnoe chislo!");
}
else
{
    number /= 10;
    number %= 10;
    System.Console.WriteLine(number);
}
