/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

System.Console.Clear();

int NewMessage(string mensaje)
{
    System.Console.Write(mensaje);
    string answer = Console.ReadLine();
    int result = int.Parse(answer);
    return result;
}

int[,] GenerMatrix(int row, int column)
{
    int[,] matrix = new int[row, column];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = j + i + 1;

        }
    }

    for (int i = matrix.GetLength(0) - 1; i > 0; i--)
    {
        for (int j = matrix.GetLength(1) - 1; j > 0; j--)
        {
            matrix[i, j - 1] = 4 * row - (i + j) - 2;
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

int rows = NewMessage("Введите количество строк в матрице: ");
int columns = NewMessage("Введите количество столбцов в матрице: ");

int[,] new2dArray = GenerMatrix(rows, columns);
PrintMatrix(new2dArray);

System.Console.WriteLine();

/*    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            int switcher = (j - i + row) / row;
            int Ic = Math.Abs(i - row / 2 - 1) + (i - 1) / (row / 2) * ((row - 1) % 2);
            int Jc = Math.Abs(j - row / 2 - 1) + (j - 1) / (row / 2) * ((row - 1) % 2);
            int Ring = row / 2 - (Math.Abs(Ic - Jc) + Ic + Jc) / 2;
            int Xs = i - Ring + j - Ring - 1;
            int Coef = 4 * Ring * (row - Ring);
            matrix[i, j] = Coef + switcher * Xs + Math.Abs(switcher - 1) * (4 * (row - 2 * Ring) - 2 - Xs);
        }
    } */