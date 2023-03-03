
// FOR

/*
for (int i = 0; i < length; i++)
{
    System.Console.WriteLine("Hello World!");
}

System.Console.WriteLine("Выход из цикла for");
*/

// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
/*
System.Console.WriteLine("Vvedite coordinatu X: ");
int x = int.Parse(Console.ReadLine());

System.Console.WriteLine("Vvedite coordinatu Y: ");
int y = int.Parse(Console.ReadLine());

if (x == 0 || y == 0)
{
    System.Console.WriteLine("Chetvert ne opredelena");
}

if (x > 0 & y > 0)
{
    System.Console.WriteLine("Pervaya chetvert");
}

if (x < 0 & y < 0)
{
    System.Console.WriteLine("Tretya chetvert");
}

if (x > 0 & y < 0)
{
    System.Console.WriteLine("Chetvertaya chetvert");
}

if (x < 0 & y > 0)
{
    System.Console.WriteLine("Vtoraya chetvert");
}
*/
// Задача №18. Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

/*
System.Console.WriteLine("Vvedite X chetverty: ");
int X = int.Parse(Console.ReadLine());

switch (X)
{
    case 1:
    System.Console.WriteLine("x > 0; y > 0");
    break;

    case 2:
    System.Console.WriteLine("x < 0; y > 0");
    break;

    case 3:
    System.Console.WriteLine("x > 0; y < 0");
    break;

    case 4:
    System.Console.WriteLine("x < 0; y < 0");
    break;

    default:
    System.Console.WriteLine("Nevernoe chislo");
    break;
}
*/
// Задача №21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21
// Формула вычисления расстояния между двумя точками A(xa, ya) и B(xb, yb) на плоскости: AB = √((xb - xa)2 + (yb - ya)2).
/*
System.Console.WriteLine("Vvesty xa");
double xa = double.Parse(Console.ReadLine());

System.Console.WriteLine("Vvesty ya");
double ya = double.Parse(Console.ReadLine());

System.Console.WriteLine("Vvesty xb");
double xb = double.Parse(Console.ReadLine());

System.Console.WriteLine("Vvesty yb");
double yb = double.Parse(Console.ReadLine());

double x = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2));

System.Console.WriteLine(Math.Round(x, 2, MidpointRounding.ToNegativeInfinity));
*/

// Задача №22. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
//от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

void quad (int x)
{
for (int i = 1; i <= x; i++)
{
    if (i == x)
    {
        System.Console.WriteLine(i * i);
        break;
    }
    System.Console.Write(i * i + ", ");
    
}
}

System.Console.Write("Vvedite chislo: ");
int number = int.Parse(Console.ReadLine());

System.Console.Write("Vvedite 2 chislo: ");
int number2 = int.Parse(Console.ReadLine());

quad(number);
quad(number2);
