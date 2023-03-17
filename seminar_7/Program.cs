/* Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
m = 3, n = 4.
1 4 8 19
5 -2 33 -2
77 3 8 1 */

/* Console.Write("Количество строк массива(m): ");
int countRow = int.Parse(Console.ReadLine());

Console.Write("Количество столбцов массива(n): ");
int countColumn = int.Parse(Console.ReadLine());

int [,] array = new int [countRow, countColumn];

int countElements = array.Length;
System.Console.WriteLine($"Количество эл-ов: {countElements}");

System.Console.WriteLine($"Кол-во строк: {array.GetLength(0)}");
System.Console.WriteLine($"Кол-во столбцов: {array.GetLength(1)}");

for (int i = 0; i < countRow; i++)
{
    for (int j = 0; j < countColumn; j++)
    {
        array[i,j] = new Random().Next(1, 10);

        Console.Write(array[i,j] + " ");
    }
    System.Console.WriteLine();
} */

/* Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5 */

/* int [,] newArray = new int[4,5];

for (int i = 0; i < newArray.GetLength(0); i++)
{
    for (int j = 0; j < newArray.GetLength(1); j++)
    {
        newArray[i,j] = new Random().Next(1, 10);
        System.Console.Write($"{newArray[i,j]} ");
    }
    System.Console.WriteLine();
}

System.Console.WriteLine();

for (int i = 0; i < newArray.GetLength(0); i++)
{
    newArray[i] = newArray[i] + newArray[j];
    
    for (int j = 0; j < newArray.GetLength(1); j++)
    {
        newArray[j] = newArray[i] + newArray[j];
        System.Console.Write($"{newArray[i,j]} ");
    }
    System.Console.WriteLine();
}
 */
/* Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
Например, изначально массив
выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4 */

/* int [,] newArray = new int[4,4];

for (int i = 0; i < newArray.GetLength(0); i++)
{
    for (int j = 0; j < newArray.GetLength(1); j++)
    {
        newArray[i,j] = new Random().Next(1, 10);
        System.Console.Write($"{newArray[i,j]} ");
    }
    System.Console.WriteLine();
}

System.Console.WriteLine();

for (int i = 1; i < newArray.GetLength(0); i+=2)
{
      
    for (int j = 1; j < newArray.GetLength(1); j+=2)
    {
        newArray[i,j] *= newArray[i,j]; //(int)Math.Pow(newArray[i,j],2);
        System.Console.Write($"{newArray[i,j]} ");
    }
    System.Console.WriteLine();

} */

/* Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12 */

/* int minLength = Math.Min(newArray.GetLength(0),newArray.GetLength(1));

for (int i = 0; i < minLength; i++)
{
    summDiag += newArray[i,i];
}

for (int i = 0; i < newArray.GetLength; i++)
{
    
} */

/* int[] array = new int[] {3,7,11,15,2};

int target = 9;


for (int i = 0; i < array.Length; i++)
{
    for (int j = i+1; j < array.Length; j++)
    {
        if (array[i] + array[j] == target)
        {
            System.Console.WriteLine($"{i},{j}");
            break;
        }
    }
} */

