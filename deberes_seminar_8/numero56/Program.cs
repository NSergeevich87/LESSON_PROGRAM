/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

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

int SumElemRows(int[,] array)
{
    int sum = 0;
    int tempSum = 0;
    int minRow = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
            if (i == 0)
            {
                tempSum = sum;
                minRow = i + 1;                
            }
        }
        
        if (sum < tempSum)
        {
            tempSum = sum;
            minRow = i + 1;
        }
        sum = 0;
    }

    return minRow;
}

int rows = NewMessage("Введите количество строк в матрице: ");
int columns = NewMessage("Введите количество столбцов в матрице: ");
int minNumber = NewMessage("Введите диапазон чисел ОТ: ");
int maxNumber = NewMessage("Введите диапазон чисел ДО: ");

int[,] new2dArray = GenerMatrix(rows, columns, minNumber, maxNumber);
PrintMatrix(new2dArray);

int rowSumMin = SumElemRows(new2dArray);
NewMessage($"Наименьшая сумма чисел в строке: {rowSumMin}");

