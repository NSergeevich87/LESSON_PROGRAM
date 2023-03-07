/*
Задача 25: Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

double step(double a, double b)
{
    double result = Math.Pow(a, b);
    return result;
}

System.Console.Write("Vvedite chislo A: ");
double a = double.Parse(Console.ReadLine());

System.Console.Write("Vvedite chislo B: ");
double b = double.Parse(Console.ReadLine());

double number = step(a, b);
System.Console.WriteLine($"{a} v stepeni {b} = {number}");