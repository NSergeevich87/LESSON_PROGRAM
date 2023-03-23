/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

System.Console.Clear();

int[,] GenerMatrix(int row, int column)
{
    int[,] matrix = new int[row, column];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = (j + i) + 1;

        }
    }

    for (int i = matrix.GetLength(0) - 1; i > 0; i--)
    {
        for (int j = matrix.GetLength(1) - 1; j > 0; j--)
        {
            matrix[i, j - 1] = 4 * row - (i + j) - 2;
        }
    }

    for (int i = 1; i < matrix.GetLength(0) - 1; i++)
    {
        for (int j = 1; j < matrix.GetLength(1) - 1; j++)
        {
            matrix[i, j] = 3 * row + j;
        }
    }

     for (int i = matrix.GetLength(0) - 2; i >= 2; i--)
    {
        for (int j = matrix.GetLength(1) - 1; j > 1; j--)
        {
            matrix[i, j - 1] = 5 * row - i - j;
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

int rows = 4;
int columns = 4;

int[,] new2dArray = GenerMatrix(rows, columns);
PrintMatrix(new2dArray);
