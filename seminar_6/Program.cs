// массив вещественных чисел. найти разницу между максимальным и минимальным элементами в массиве.
/*
double[] array = new double[20];

for (int i = 0; i < array.Length; i++)
{
    array[i] = Math.Round((new Random().NextDouble() * 100), 3);
}

double maxManual = array[0];
double minManual = array[0];

double maxAuto = array.Max();
double minAuto = array.Min();

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > maxManual)
    {
       maxManual = array[i];   
    }
    
    if (array[i] < minManual)
    {
       minManual = array[i];   
    }

}
System.Console.WriteLine($"Разница между макс и мин: {maxManual - minManual}");
*/

// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]
/*
int[] array = new int[5] {1,2,3,4,5};

int[] tempArray = new int[array.Length];

for (int i = 0; i < array.Length; i++)
{
    tempArray[i] = array[(array.Length-1) -i];
}

array = tempArray;

for (int i = 0; i <= (array.Length/2) - 1; i++)
{
    int temp = array[i];
    array[i] = array[(array.Length - 1) - i];
    array[(array.Length - 1) - i] = temp;
}
*/

// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

/*
bool IsItTreangle(int a, int b, int c)
{
    bool result = false;

    int ab = a + b;
    int bc = b + c;
    int ca = c + a;

    if (ab > c && bc > a && ca > b)
    {
        result = true;
    }

    return result;
}

System.Console.Write("Vvedite length A");
int lengthA = int.Parse(Console.ReadLine());

System.Console.Write("Vvedite length B");
int lengthB = int.Parse(Console.ReadLine());

System.Console.Write("Vvedite length C");
int lengthC = int.Parse(Console.ReadLine());

bool result = IsItTreangle(a, b, c);
System.Console.WriteLine(result);
*/

// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
//  45 -> 101101
//  3  -> 11
//  2  -> 10
/*
string BinarNum(int num)
{
    int tempNum = num;
    string result = "";

    while (tempNum > 0)
    {
        int remainder = tempNum % 2;
        result = Convert.ToString(remainder) + result;
        tempNum /= 2;
    }
    
    return result;
}

System.Console.Write("Vvedite A: ");
int number = int.Parse(Console.ReadLine());

string result = BinarNum(number);
System.Console.WriteLine(result);
*/
// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

/* void ShowDoubleArray (double[] array)
{  
    //Вывод с помощью foreach
    foreach (var elem in array) 
    {
        Console.Write("{0} ", elem);
    }

    Console.WriteLine();
}

void PrintFib(int num)
{
   double[] array = new double[num];
   array[0] = 0;
   array[1] = 1;

   for (int i = 2; i < num; i++)
   {
       array[i] = array[i-1] + array[i-2];
   }
   
   ShowDoubleArray(array);
}

System.Console.Write("Vvedite A: ");
int number = int.Parse(Console.ReadLine());

PrintFib(number); */

// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

/* 
int[] getNewArray(int[] array)
{
    int length = array.Length;
    int[] newArray = new int[length];

    for (int i = 0; i < length; i++)
    {
        newArray[i] = array[i];
    }

    return newArray; 
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

int[] GenerArray(int length)
{
    int[] arr = new int[length];
    
    for (int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next(1, 10);
    }

    return arr;
}

System.Console.Write("length array: ");
int length = int.Parse(Console.ReadLine());

int[] array = GenerArray(length);
ShowArray(array);

int[] newArray = getNewArray(array);
ShowArray(newArray); */

// fibonacci y convert desetich v dvoich

/* int[] fibonacci(int num)
{
   int[] FiboArray = new int[num];
   FiboArray[0] = 0;
   FiboArray[1] = 1;

   for (int i = 2; i < FiboArray.Length; i++)
   {
      FiboArray[i] = FiboArray[i-1] + FiboArray[i-2];
      //System.Console.WriteLine($"{0} {1} + {FiboArray[i]}");
   }
   return FiboArray;
}

void printFibo(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
}

System.Console.WriteLine("Vvedite number: ");
int number = int.Parse(Console.ReadLine());


int[] newarray = fibonacci(number);
printFibo(newarray); */


/* string DeciBini(int num)
{
    int number = num; 
    string result = "";
    
    while (number > 0)
    {
        int x = number %2;
        result = Convert.ToString(x) + result;
        number /= 2;
    }

    return result;
}

System.Console.WriteLine("Введите число для перевода из 10ой в 2ую систему счисления: ");
int number = int.Parse(Console.ReadLine());

string answer = DeciBini(number);
System.Console.WriteLine(answer); */

