/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int NewMessage (string message)
{
   Console.Write(message);
   string answer = Console.ReadLine();
   int ReadAnswer = int.Parse(answer);

   return ReadAnswer;
}

void PrintMessage (int number)
{
   System.Console.WriteLine();
   Console.Write($"Сумма элементов, стоящих на нечетных позициях: {number}");
}

void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
}

int[] NewGenerateArray (int length, int desde, int hasta)
{
   int[] NewArray = new int[length];

   for (int i = 0; i < length; i++)
   {
      NewArray[i] = new Random().Next(desde, hasta + 1);
   }

   return NewArray;
}

int SumNegativePosition (int[] array)
{
   int result = 0;

   for (int i = 0; i < array.Length; i++)
   {
      if (i %2 != 0)
      {
        result = result + array[i];
      }
   }

   return result;
}

int size = NewMessage("Введите размер массива: ");
int min = NewMessage("Введите диапазон чисел ОТ: ");
int max = NewMessage("Введите диапазон чисел ДО: ");

int[] arr = NewGenerateArray(size, min, max);
PrintArray(arr);

int SumNeg = SumNegativePosition(arr);
PrintMessage(SumNeg);