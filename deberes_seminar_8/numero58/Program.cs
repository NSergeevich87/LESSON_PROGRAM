/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

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

int[,] MultiplicationMatrix(int[,] firstArray, int[,] secondArray)
{
    int[,] newArray = new int[firstArray.GetLength(0), secondArray.GetLength(1)];

    if ((firstArray.GetLength(0) * firstArray.GetLength(1)) == (secondArray.GetLength(0) * secondArray.GetLength(1)))
    {
        for (int i = 0; i < firstArray.GetLength(0); i++)
        {
            for (int j = 0; j < secondArray.GetLength(1); j++)
            {
                for (int k = 0; k < secondArray.GetLength(0); k++)
                {
                    newArray[i, j] += firstArray[i, k] * secondArray[k, j];
                }
            }
        }
    }
    else
    {
        System.Console.WriteLine();
        System.Console.Write("Данные матрицы невозможно перемножить!");
    }
    return newArray;
}

int rowsFM = NewMessage("Введите количество строк в 1й матрице: ");
int columnsFM = NewMessage("Введите количество столбцов в 1й матрице: ");
int minNumberFM = NewMessage("Введите диапазон чисел ОТ: ");
int maxNumberFM = NewMessage("Введите диапазон чисел ДО: ");

int rowsSM = NewMessage("Введите количество строк во 2й матрице: ");
int columnsSM = NewMessage("Введите количество столбцов во 2й матрице: ");
int minNumberSM = NewMessage("Введите диапазон чисел ОТ: ");
int maxNumberSM = NewMessage("Введите диапазон чисел ДО: ");

int[,] firstMatrix = GenerMatrix(rowsFM, columnsFM, minNumberFM, maxNumberFM);
PrintMatrix(firstMatrix);
System.Console.WriteLine();
int[,] secondMatrix = GenerMatrix(rowsSM, columnsSM, minNumberSM, maxNumberSM);
PrintMatrix(secondMatrix);
System.Console.WriteLine();
int[,] newMultMatrix = MultiplicationMatrix(firstMatrix, secondMatrix);
PrintMatrix(newMultMatrix);
