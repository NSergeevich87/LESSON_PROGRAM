/*
Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27 
5 -> 1, 8, 27, 64, 125
*/

double cubo(double arg)
{
    arg = Math.Abs(arg);
    
    double count = 0;
    double x = 1;

    while (x <= arg)
    {

        if (x == arg)
        {
            count = Math.Pow(x, 3);

            System.Console.Write(count);

            break;
        }

        count = Math.Pow(x, 3);

        System.Console.Write($"{count}, ");

        x++;
    }
    return count;
}

System.Console.Write("Vvedite chislo N: ");
double n = double.Parse(Console.ReadLine());

cubo(n);