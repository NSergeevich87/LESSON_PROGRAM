/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

int NewMessage(string message)
{
    System.Console.Write(message);
    string answer = Console.ReadLine();
    int numero = int.Parse(answer);
    return numero;
}

/* double NewMessageD(string message)
{
    System.Console.Write(message);
    string answer = Console.ReadLine();
    double numero = double.Parse(answer);
    return numero;
} */

double[,] Gen2DArray(int r, int c)
{
    double[,] array = new double[r, c];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(new Random().NextDouble() * 100, 2);
        }
    }

    return array;
}

void Print2DArray(double[,] array)
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

int row = NewMessage("Введите количество строк в массиве: ");
int column = NewMessage("Введите количество столбцов в массиве: ");
// double min = NewMessageD("Введите диапазон заполнения массива ОТ: ");
// double max = NewMessageD("Введите диапазон заполнения массива ДО: ");

double[,] newArray = Gen2DArray(row, column/* , min, max */);
Print2DArray(newArray);