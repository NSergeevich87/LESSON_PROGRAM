/*
Задача 21: Напишите программу, которая принимает 
на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
Формула: AB = √((x2 - x1)2 + (y2 - y1)2 + (z2 - z1)2)
*/

double ab3Dlength(double arg1, double arg2, double arg3, double arg4, double arg5, double arg6)
{
    double result = Math.Sqrt(Math.Pow(arg2 - arg1, 2) + Math.Pow(arg4 - arg3, 2) + Math.Pow(arg6 - arg5, 2));

    return result;
}

System.Console.Write("x1: ");
double x1 = double.Parse(Console.ReadLine());

System.Console.Write("y1: ");
double y1 = double.Parse(Console.ReadLine());

System.Console.Write("z1: ");
double z1 = double.Parse(Console.ReadLine());

System.Console.Write("x2: ");
double x2 = double.Parse(Console.ReadLine());

System.Console.Write("y2: ");
double y2 = double.Parse(Console.ReadLine());

System.Console.Write("z2: ");
double z2 = double.Parse(Console.ReadLine());

double length = ab3Dlength(x1, x2, y1, y2, z1, z2);

//ab3Dlength(x1, x2, y1, y2, z1, z2);

System.Console.WriteLine("Rasstoyaniye: " + Math.Round(length, 2));