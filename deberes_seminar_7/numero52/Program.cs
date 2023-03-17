/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */



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

void AverageSum(int[,] array)
{
   double result = 0;

   for (int i = 0; i < array.GetLength(1); i++)
   {
      for (int j = 0; j < array.GetLength(0); j++)
      {
        result = result + array[j,i];
        if (j == (array.GetLength(0) - 1))
        {
            result = Math.Round(result / array.GetLength(0), 2);
        }
        //System.Console.Write($"{result} ");
      }
      System.Console.WriteLine($"Среднее арифметическое {i + 1} столбца = {result} ");
      result = 0;
   }
}

int row = NewMessage("Введите количество строк в массиве: ");
int column = NewMessage("Введите количество столбцов в массиве: ");
int min = NewMessage("Введите диапазон заполнения массива ОТ: ");
int max = NewMessage("Введите диапазон заполнения массива ДО: ");

int[,] newArray = Gen2DArray(row, column, min, max);
Print2DArray(newArray);

AverageSum(newArray);