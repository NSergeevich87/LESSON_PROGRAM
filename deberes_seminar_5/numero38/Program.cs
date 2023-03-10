/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
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
   Console.Write($"Разница между максимальным и минимальным элементами: {number}");
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

int MaxMenosMin (int[] array)
{
   int max = array[0];
   int min = array[0];
   int result = 0;

   for (int i = 0; i < array.Length; i++)
   {
      if (array[i] > max)
      {
        max = array[i];
      }
    else
    {
      if (array[i] < min)
      {
        min = array[i];
      }
    }
   }

   if (min < 0)
   {
    result = max + min;
   }
   else
   {
    result = max - min;
   }
   
   return result;

}

int size = NewMessage("Введите размер массива: ");
int min = NewMessage("Введите диапазон чисел ОТ: ");
int max = NewMessage("Введите диапазон чисел ДО: ");

int[] arr = NewGenerateArray(size, min, max);
PrintArray(arr);

int MaxMin = MaxMenosMin(arr);
PrintMessage(MaxMin);