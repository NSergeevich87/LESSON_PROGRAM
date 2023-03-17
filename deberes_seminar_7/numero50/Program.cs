/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

int NewMessage(string message)
{
    System.Console.Write(message);
    string answer = Console.ReadLine();
    int numero = int.Parse(answer);
    return numero;
}

int[,] Gen2DArray(int r, int c, int mi, int ma)
{
    int[,] array = new int[r, c];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(mi, ma + 1);
        }
    }

    return array;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

void FindElement(int[,] array, int r, int c)
{
    if (r <= array.GetLength(0) && c <= array.GetLength(1) && r > 0 && c > 0)
    {
    for (int i = r - 1; i < array.GetLength(0); i++)
    {
        for (int j = c - 1; j < array.GetLength(1); j++)
        {
            Console.WriteLine($"Элемент поиска равен: {array[i,j]}");
            break;
        }
        break;
    }
    }
    else
    {
        Console.WriteLine("Элемент не может быть найден т.к. он находится вне заданного диапазона массива!");
    }
}

int row = NewMessage("Введите количество строк в массиве: ");
int column = NewMessage("Введите количество столбцов в массиве: ");
int min = NewMessage("Введите диапазон заполнения массива ОТ: ");
int max = NewMessage("Введите диапазон заполнения массива ДО: ");

int[,] newArray = Gen2DArray(row, column, min, max);
Print2DArray(newArray);

int findRowElem = NewMessage("Введите НОМЕР! строки для поиска элемента: ");
int findColElem = NewMessage("Введите НОМЕР! столбца для поиска элемента: ");

FindElement(newArray, findRowElem, findColElem);