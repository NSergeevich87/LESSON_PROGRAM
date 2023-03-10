/* 
   Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
   Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.
*/

// Метод генерации массива
/*
int[] MainArray(int length, int min, int max)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}
*/
// Метод печати массива в консоль
/*
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
}
*/
// Нахождение сумму положительных и отрицательных чисел
/*
int SumNeg(int[] array)
{
    int neg = 0;
    
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            neg = neg + array[i];
        }
    }
    
    return neg; 
}

int SumPos(int[] array)
{
    int pos = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            pos = pos + array[i];
        }
    }
    
    return pos;
}
*/
// Замена положительных чисел в массиве на отрицательные и наоборот
/*
int[] ReversoArray(int[] array)
{
   for (int i = 0; i < array.Length; i++)
   {
      array[i] = array[i] * -1;
   }
   return array;
}
*/
// Поиск числа в массиве
/*
bool FindN(int[] array, int number)
{
   bool result = false;
   for (int i = 0; i < array.Length; i++)
   {
      if (array[i] == number)
      {
         result = true;
      }
   }
   return result;
}
*/
// Поиск количества элементов в массиве из заданного диапазона
/*
int SumElem(int[] array, int desde, int hasta)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= desde && array[i] <= hasta)
        {
            result += 1; 
        }
    }
    return result;
}
*/
// Произведение крайних чисел массива смещающихся к центру
/*
int[] NewArrayMulti(int[] array)
{
    int[] MultiBackArray = new int[(array.Length + 1)/2];
    
    if (array.Length %2 == 0)
    {
        for (int i = 0; i < array.Length/2; i++)
        {
            MultiBackArray[i] = array[i] * array[array.Length -1 -i];
        } 
    }
    else
    {
     
        for (int i = array.Length/2; i >= 0; i--)
        {
            if (i == array.Length/2) MultiBackArray[i] = array[i];
            else
            MultiBackArray[i] = array[i] * array[array.Length -1 -i];
        } 
        
    }

    return MultiBackArray;
}

System.Console.Write("Задайте размер массива: ");
int ArrayLength = int.Parse(Console.ReadLine());

System.Console.Write("Задайте диапазон чисел в массиве. От: ");
int ArrayMinNumber = int.Parse(Console.ReadLine());

System.Console.Write("Задайте диапазон чисел в массиве. До: ");
int ArrayMaxNumber = int.Parse(Console.ReadLine());

int[] arr = MainArray(ArrayLength, ArrayMinNumber, ArrayMaxNumber);
PrintArray(arr);

System.Console.WriteLine();

int[] NewArr = NewArrayMulti(arr);
PrintArray(NewArr);
*/

//System.Console.Write("Ищем количество элементов в диапазоне ОТ: ");
//int de = int.Parse(Console.ReadLine());
//System.Console.Write("Ищем количество элементов в диапазоне ДО: ");
//int a = int.Parse(Console.ReadLine());
//int result = SumElem(arr, de, a);
//System.Console.WriteLine($"Количество элементов в данном диапазоне: {result}");

//System.Console.WriteLine("Введите число которое будем искать в массиве: ");
//int NumberFind = int.Parse(Console.ReadLine());

//bool find = FindN(arr, NumberFind);
//System.Console.WriteLine(find);

//int[] Reverso = ReversoArray(arr);
//PrintArray(Reverso);

//int NegativeSum = SumNeg(arr);
//int PositiveSum = SumPos(arr);
//System.Console.WriteLine();
//System.Console.WriteLine($"Сумма отрицательных чисел: {NegativeSum}, а сумма положительных чисел: {PositiveSum}");



/*
int GetSumPositiv (int[] array)
{
   int sum = 0;

   for (int i = 0; i < array.Length; i++)
   {
        if (array[i] > 0)
        {
            sum += array[i];
        }
   }

   return sum;
}

int GetSumNegative (int[] array)
{
int sum = 0;

   for (int i = 0; i < array.Length; i++)
   {
        if (array[i] < 0)
        {
            sum += array[i];
        }
   }

   return sum;
}

void printArray (int[] array)
{
   for (int i = 0; i < array.Length; i++)
   {
      System.Console.Write(array[i] + " ");
   }
}

int[] myarray = new int[12];
for (int i = 0; i < myarray.Length; i++)
{
    myarray[i] = new Random().Next(-9, 10);
}

printArray(myarray);

int sumPositive = GetSumPositiv(myarray);
int sumNegative = GetSumNegative(myarray);

System.Console.WriteLine($"semma pologitelnih: {sumPositive}");
System.Console.WriteLine($"semma otrizatelnih: {sumNegative}");
*/
// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

/*
void printArray (int[] array)
{
   for (int i = 0; i < array.Length; i++)
   {
      System.Console.Write(array[i] + " ");
   }
}

int[] myarray = new int[12];
for (int i = 0; i < myarray.Length; i++)
{
    myarray[i] = new Random().Next(-9, 10);
}

void changeArray (int[] array)
{
   for (int i = 0; i < array.Length; i++)
   {
       array[i] = array[i] * -1;    
   }
   }
} 
*/

/*
Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
*/
/*
void printArray (int[] array)
{
   for (int i = 0; i < array.Length; i++)
   {
      System.Console.Write(array[i] + " ");
   }
}

int[] myarray = new int[12];
for (int i = 0; i < myarray.Length; i++)
{
    myarray[i] = new Random().Next(-9, 10);
}

bool FindElem(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num)
        {
            return true;
        }

    }
    return false;
}

bool IsPresent = FindElem(array, num);
*/
/*
Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/

/*
void printArray (int[] array)
{
   for (int i = 0; i < array.Length; i++)
   {
      System.Console.Write(array[i] + " ");
   }
}

int GetCountInRange(int[] array, int start, int finish)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (start <= array[i] && array[i] <= finish)
        {
            count++;
        }
    }

    return count;
}

System.Console.WriteLine("dlina massiva: ");
int Length = int.Parse(Console.ReadLine());
int [] arrray = GenerArray(Length);
printArray(array);
System.Console.WriteLine();

int start = int.Parse(Console.ReadLine());
int finish = int.Parse(Console.ReadLine());


int countInRange = GetCountInRange(array, start, finish);
*/


/*
Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/
/*
void showdualsum (int [] array)
{
    int length = array.Length;
    int halfLength = length/2;

    for (int i = 0; i < halfLength; i++)
    {
        int secondIndex = length - i - 1;
        int sum = array[i] * array[secondIndex];
        System.Console.Write("");
        System.Console.WriteLine($"{sum}");
    }
}
*/
/*
int[] array = new int[10] {1,2,3,4,5,6,7,8,9,10};
for (int i = 0; i < array.Length; i++)
{
    System.Console.WriteLine($"{array[i]} ");
}

int[] array = new int[10] {1,2,3,4,5,6,7,8,9,10};
for (int i = array.Length - 1; i < array.Length; i++)
{
    System.Console.WriteLine($"{array[i]} ");
}
*/

