/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int[] arr = new int[8];

void fillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
}

void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($" {array[i]}");
    }
}

System.Console.WriteLine("ВНИМАНИЕ! После нажатия на кнопку ввода, программа создаст массив из случайных 8ми цифр в диапазоне 0-99!");
Console.ReadLine();

fillArray(arr);
printArray(arr);
