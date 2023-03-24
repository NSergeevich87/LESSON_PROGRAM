/* Задача 1: Задайте значение N. Напишите программу, которая выведет все четные натуральные числа в промежутке от m до N . Выполнить с помощью рекурсии.
M, N = 5, 8 -> "6, 8"
M, N = 2, 4 -> "2, 4" */

int NuevoMensaje(string mensaje)
{
    System.Console.Write(mensaje);
    string respuesta = System.Console.ReadLine();
    int numero = int.Parse(respuesta);
    return numero;
}

void IntervaloNumerosPares(int de, int a)
{
    int desde = de;
    int hasta = a;

    if (desde > hasta)
    {
        return;
    }

    if (desde % 2 == 0)
    {
        System.Console.Write($"{desde} ");
    }

    IntervaloNumerosPares(de + 1, a);
}

int hastaNumero = NuevoMensaje("Введите число N: ");
int desdeNumero = NuevoMensaje("Введите число M меньшее чем N: ");

IntervaloNumerosPares(desdeNumero, hastaNumero);