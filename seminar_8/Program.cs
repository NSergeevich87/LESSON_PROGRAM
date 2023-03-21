// Задача 1: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

/*  int[,] CreateArray (int countRows, int countColumns)
{
    int[,] resultArray = new int[countRows, countColumns];
    Random rnd = new Random();
    for (int i = 0; i < resultArray.GetLength(0); i++)
    {
        for (int j = 0; j < resultArray.GetLength(1); j++)
        {
            resultArray[i,j] = rnd.Next(0, 10);
        }

    }

    return resultArray;
}

void PrintArray (int[,] array)
{
   
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i,j]}\t");
        }

    }
    System.Console.WriteLine();
}

int[,] ChangeFirstLastRows(int[,] array)
{
    int firstRaw = 0;
    int lastRaw = array.GetLength(0) - 1;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        (array[firstRaw, i], array[lastRaw, i]) = (array[lastRaw, i], array[firstRaw, i]);
    }
    return array;
}

int rows = 6;
int columns = 4;
int[,] matrix = CreateArray(rows, columns);
PrintArray(matrix);
int[,] newArray = ChangeFirstLastRows(matrix);
PrintArray(newArray);  */

/* Задача 2: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.*/

/* int rows = 4;
int columns = 4;
int[,] matrix = CreateArray(rows, columns);

int[,] CreateArray (int countRows, int countColumns)
{
    int[,] resultArray = new int[countRows, countColumns];
    Random rnd = new Random();
    for (int i = 0; i < resultArray.GetLength(0); i++)
    {
        for (int j = 0; j < resultArray.GetLength(1); j++)
        {
            resultArray[i,j] = rnd.Next(0, 10);
        }

    }

    return resultArray;
}

void PrintArray (int[,] array)
{
   
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i,j]}\t");
        }

    }
    System.Console.WriteLine();
}

bool ValidateMatrix (int[,] array)
{
    
    if(array.GetLength(0) == array.GetLength(1))
    {
        return true;
    }
    else
    {
        return false;
    }
}

int[,] TransponateMatrix (int[,] array)
{
    if(ValidateMatrix(array))
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = i; j < array.GetLength(1); j++)
            {
                (array[i,j], array[j,i]) = (array[j,i], array[i,j]);
            }
        }
        return array;
    }
    else
    {
        //System.Console.WriteLine("невозможно транспонировать матрицу!");
        throw new Exception ("невозможно транспонировать матрицу!");
    }
    
}

PrintArray(matrix);
ValidateMatrix(matrix);
int[,] newMatrix = TransponateMatrix(matrix); 
PrintArray(newMatrix); */

/* Задача 3: Составить частотный словарь элементов двумерного массива. 
Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных. Значения элементов массива 0..9 */

/* int[,] CreateArray (int countRows, int countColumns)
{
    int[,] resultArray = new int[countRows, countColumns];
    Random rnd = new Random();
    for (int i = 0; i < resultArray.GetLength(0); i++)
    {
        for (int j = 0; j < resultArray.GetLength(1); j++)
        {
            resultArray[i,j] = rnd.Next(0, 10);
        }

    }

    return resultArray;
}

void Print2dArray (int[,] array)
{
   
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i,j]}\t");
        }

    }
    System.Console.WriteLine();
}

void PrintArray(int[] array)
{
    System.Console.WriteLine();
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
}

int [] GetFrequincyArray (int[,] array)
{
    int[] resultArray = new int[10];
    foreach (int item in array)
    {
        resultArray[item]++;
    }

    return resultArray;
}

int rows = 2;
int columns = 2;
int[,] matrix = CreateArray(rows, columns);
Print2dArray(matrix);

int[] arrayFraquency = GetFrequincyArray(matrix);
PrintArray(arrayFraquency); */

/* Задача 4: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим 
следующий массив:
9 2 3
4 2 4
2 6 7 */

int[,] CreateArray (int countRows, int countColumns)
{
    int[,] resultArray = new int[countRows, countColumns];
    Random rnd = new Random();
    for (int i = 0; i < resultArray.GetLength(0); i++)
    {
        for (int j = 0; j < resultArray.GetLength(1); j++)
        {
            resultArray[i,j] = rnd.Next(0, 10);
        }

    }

    return resultArray;
}

void PrintArray (int[,] array)
{
   
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i,j]}\t");
        }

    }
    System.Console.WriteLine();
}

(int row, int column) GetIndecesOfMin(int[,] array)
{
    int minRow = 0;
    int minColumn = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < array[minRow, minColumn])
            {
                minRow = i;
                minColumn = j;
            }
        }
    }
    return (minRow, minColumn);
}

int[,] DeleteByIndexes(int[,] array, int row, int column)
{
    int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];

    int newI = 0;
    int newJ = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {

        if (i == row)
        {
            continue;
        }
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == column)
            {
                 continue;
            }
            newArray[newI, newJ] = array[i,j];
            newJ++;
        }
        newI++;
        newJ = 0;
    }

    return newArray;
}

int rows = 5;
int columns = 5;
int[,] matrix = CreateArray(rows, columns);
PrintArray(matrix);

(int row, int column) = GetIndecesOfMin(matrix);
int[,] newMenosArray = DeleteByIndexes(matrix, row, column);
PrintArray(newMenosArray);
