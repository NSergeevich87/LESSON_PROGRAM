
/*
bool isPalindrome(int number)
{
    int revers = 0;
    int sourceNumber = number;
    
    while (sourceNumber != 0)
    {
        int pop = sourceNumber % 10;
        sourceNumber = sourceNumber / 10;
        
        // формирования нового числа, обратного от исходного
        revers = (revers * 10) + pop;
    }

    bool isResult = revers == number;

    return isResult;
}

bool result = isPalindrome(134431);
System.Console.WriteLine(result);
*/

// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28 4 -> 10 8 -> 36

/*
System.Console.WriteLine("vvedite chislo: ");
int a = int.Parse(Console.ReadLine());

int GetSum(int number)
{
    int sum = 0;
    for (int i = 1; i <= number; i++)
    {
        sum = sum + i;
    }
    return sum;
}

int sum = GetSum(a);
System.Console.WriteLine(sum);
*/
/*
Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/
/*
System.Console.WriteLine("Vvedite chislo: ");
int number = int.Parse(Console.ReadLine());

int numbers(int a)
{
    int b = 0;

    while (a != 0)
    {
        a = a / 10;
        b = b + 1;
    }
    
    return b;
}

int x = numbers(number);
System.Console.WriteLine(x);
*/
/*
Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24 
5 -> 120
*/
/*
System.Console.WriteLine("vvedite chislo N: ");
int number = int.Parse(Console.ReadLine());

int mult(int x)
{
    int y = 1;
    for (int i = 1; i <= x; i++)
    {
        y = y * i;
    }

    return y;
}

int result = mult(number);
System.Console.WriteLine(result);
*/
/*
Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
*/
/*
void arr(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(0,2);
        index++;
    }
}

void printarr(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        System.Console.Write(array[index]);
        index++;
    }
}

int[] array = new int[8];
arr(array);
printarr(array);
*/
// реализовать метод принимает на вход массив и целое число массив целочисленный, вернуть тру или фолс 

int[] array = {1,2,3,4,5,6,7,8};

void printarray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i]);
    }
}

int serch(int[] arr, int x)
{
    int result = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        
        if (x == arr[i])
        {
            result = 1;
        }
               
    }

     return result;
}

System.Console.Write("vvedite chislo ot 1 do 9: ");
int number = int.Parse(Console.ReadLine());

printarray(array);
int y = serch(array, number);
System.Console.WriteLine(" " + y);

/*
int getPositionArray(int num, int[] nums)
{
    int pos1 = 0;
    int pos2 = nums.Length-1;
    while (pos1 != pos2)
    {
        int midPos = (pos1 + pos2)/2;
        if (nums[midPos] == num)
        {
            return midPos;
        }
        if(nums[midPos] < num)
        {
           pos1 = midPos;
        }
        else
        {
            pos2 = midPos;
        }
    }

    return -1;
}

int[] nums = new int[8] {1,3,4,5,6,8,9,10};
Array.Sort(nums);
Console.Write("Введите число :");
int num = int.Parse(Console.ReadLine());
int position = getPositionArray(num, nums);
Console.WriteLine(position+1);
*/