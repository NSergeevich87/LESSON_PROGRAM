/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int NewMessage (string message)
{
   Console.Write(message);                   // Отправляем сообщение оператору
   string ReadAnswer = Console.ReadLine();       // Считываем ответ оператора
   int result = int.Parse(ReadAnswer);           // Превращаем строку в число

   return result;                                // Возвращаем результат
}

void PrintMessage (int number)
{
   System.Console.WriteLine();
   Console.Write($"Количество четных чисел в заданном массиве: {number}");
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

int CountChetSum (int[] array)
{
   int result = 0;
   
   for (int i = 0; i < array.Length; i++)
   {
      if (array[i] %2 == 0)
      {
         result++;
      }
   }

   return result;
}

int size = NewMessage("Введите размер массива: ");
int min = NewMessage("Введите диапазон чисел ОТ: ");
int max = NewMessage("Введите диапазон чисел ДО: ");

int[] arr = NewGenerateArray(size, min, max);
PrintArray(arr);

int ChetSum = CountChetSum(arr);
PrintMessage(ChetSum);