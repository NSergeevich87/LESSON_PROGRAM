/* 
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, 
b2 = 4, k2 = 9
-> (-0,5; -0,5) 
*/

void CoordPrint(double[] array)
{
    System.Console.WriteLine($"Точка пересечения: Координата X: {array[0]}, Координата Y: {array[1]}");
}

double NewMessage(string mensaje)
{
   System.Console.Write(mensaje);
   string read = Console.ReadLine();
   double number = double.Parse(read);
   return number;
}

double[] FindCoord(double b1, double k1, double b2, double k2)
{
    double[] cord = new double[2];

    double x = (b2 - b1) / (k1 - k2);
    double y1 = (k1 * x) + b1;
    double y2 = (k2 * x) + b2;   

    if (b1 == b2)
    {
        if (k1 == k2) System.Console.WriteLine("Прямые имеют одинаковые координаты!");
        else System.Console.WriteLine("Прямые параллельны!");
    
    }

    cord[0] = x;
    cord[1] = y1;
    
    return cord;
}

double lineB1 = NewMessage("Введите b1: ");
double lineK1 = NewMessage("Введите k1: ");
double lineB2 = NewMessage("Введите b2: ");
double lineK2 = NewMessage("Введите k2: ");

double[] FindXY = FindCoord(lineB1, lineK1, lineB2, lineK2);
CoordPrint(FindXY);

