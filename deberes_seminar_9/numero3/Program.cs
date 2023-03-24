/* Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

    /* m = 0 -> n + 1; 
m > 0, n = 0 -> A(m - 1, 1); 
m > 0, n > 0 -> A(m - 1, A(m, n - 1)); */

int m = 2;
int n = 3;

int Akkerman(int m, int n, int res = 0)
{
    if (m == 0)
    {
        res = res + n + 1;
        return res;
    }

    if (m > 0 && n == 0)
    {
        Akkerman(m - 1,)
    }
}

int result = Akkerman(m, n);
System.Console.WriteLine(result);