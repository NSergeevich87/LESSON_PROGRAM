/* Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

System.Console.Clear();

int NuevoMensaje(string mensaje)
{
    System.Console.Write(mensaje);
    string respuesta = System.Console.ReadLine();
    int numero = int.Parse(respuesta);
    return numero;
}

int IntervaloNumerosPares(int de, int a, int sum = 0)
{
    if (de > a)
    {
        return sum;
    }
    
    sum = sum + de;
    return IntervaloNumerosPares(de + 1, a, sum);
}

int desdeNumero = NuevoMensaje("Введите диапазон ОТ: ");
int hastaNumero = NuevoMensaje("Введите диапазон ДО: ");

int numberSum = IntervaloNumerosPares(desdeNumero, hastaNumero);
System.Console.WriteLine($"В заданном диапазоне, сумма натуральных элементов равна: {numberSum}");