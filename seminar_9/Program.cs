/* 
System.Console.Clear();

int NewMessage(string mensaje)
{
    System.Console.Write(mensaje);
    string answer = Console.ReadLine();
    int result = int.Parse(answer);
    return result;
}

int[,] GenerMatrix(int row, int column, int min, int max)
{
    int[,] matrix = new int[row, column];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int count = 0;
        while (count != 3)
        {
            System.Console.WriteLine();
            count++;
        }

        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
    }
}

int rowsFM = NewMessage("Введите количество строк в 1й матрице: ");
int columnsFM = NewMessage("Введите количество столбцов в 1й матрице: ");
int minNumberFM = NewMessage("Введите диапазон чисел ОТ: ");
int maxNumberFM = NewMessage("Введите диапазон чисел ДО: ");

int[,] firstMatrix = GenerMatrix(rowsFM, columnsFM, minNumberFM, maxNumberFM);
PrintMatrix(firstMatrix); */

/* Задача 1: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N при помощи рекурсии.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6" */

/* void PrintNumber (int num)
{
    if (num == 0)
    {
        return;
    }

    System.Console.WriteLine($"{num} ");
    PrintNumber (num - 1);
}

int number = 10;
PrintNumber(number); */

/* Задача 2: Задайте значения M и N. Напишите программу, которая рекурсивно выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 5, 6, 7, 8" */

/* int leftRange = 8;
int rigthRange = 65;

void PrintNumbers(int leftRange, int rigthRange)
{
    if (leftRange > rigthRange)
    {
        return;
    }
    System.Console.WriteLine($"{leftRange}");
    leftRange++;
    PrintNumbers(leftRange, rigthRange);
}

PrintNumbers(leftRange, rigthRange); */

/* Задача 3: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр. Использовать рекурсию.
453 -> 12
45 -> 9 */

/* int number = 123;
System.Console.WriteLine($"{SumNumber(number)}");
int SumNumber(int number)
{
    if (number == 0)
    {
        return 0;
    }

    return number %10 + SumNumber(number / 10);
}

SumNumber(number); */

/* Задача 4: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8 */

/* int A = 2;
int B = 3;

int MyPower(int number, int exp)
{


    if (exp == 0)
    {
        return 1;
    }

    return MyPower(number, exp - 1) * number;



}

System.Console.WriteLine(MyPower(A, B)); */

/* Задача 5: Определите, является ли число степенью двойки:
N = 16 -> "Является степень двойки"
N = 12 -> “Не является степенью двойки” */

/* int number = 36;

bool Is2Power (int num)
{
    if (num == 1)
    {
        return true;
    }

    if (num %2 == 1)
    {
        return false;
    }

    
    
    return Is2Power(num / 2);
    
}

System.Console.WriteLine(Is2Power(number)); */

/* Задача 6: Проверка на простое число: 
N = 13 -> "Это простое число"
N = 12 -> “Это не простое число” */

int number = 13;

bool IsPrime (int number, int divider = 0)
{
    if (divider == 0)
    {
        divider = number / 2;
    }

    

    if (divider == 1)
    {
        return true;
    }

    if (number % divider == 0)
    {
        return false;
    }

    

    return IsPrime(number, divider - 1);



}

System.Console.WriteLine(IsPrime(number));