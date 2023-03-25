/* Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

/* m = 0 -> n + 1; 
m > 0, n = 0 -> A(m - 1, 1); 
m > 0, n > 0 -> A(m - 1, A(m, n - 1)); */

int NuevoMensaje(string mensaje)
{
    System.Console.Write(mensaje);
    string answer = System.Console.ReadLine();
    int number = int.Parse(answer);
    return number;
}

int Akkerman(int x, int y)
{
    if (x == 0) return y + 1;
    else
    {
        if (x > 0 && y == 0) return Akkerman(x - 1, 1);
        else return Akkerman(x - 1, Akkerman(x, y - 1));
    }
}

int m = NuevoMensaje("Введите первое целое неотрицательное число: ");
int n = NuevoMensaje("Введите второе целое неотрицательное число: ");

int result = Akkerman(m, n);
NuevoMensaje($"Значение функции Аккермана: {result}");