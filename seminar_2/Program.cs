// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

/* 
   Напишите программу, которая будет принимать на вход два числа и выводить, 
   является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
*/

// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

//Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

/*
int number = new Random().Next (100, 1000);
Console.WriteLine(number);

int firstDigit = number / 100;
firstDigit *= 10;

int secondDigit = number % 10;

int result = firstDigit + secondDigit;

Console.WriteLine(result);
*/
/*
System.Console.Write("Введите число 1: ");
int number1 = int.Parse(Console.ReadLine());

System.Console.Write("Введите число 2: ");
int number2 = int.Parse(Console.ReadLine());

int rest = number1 % number2;
//46 % 10 запишется 6

if (rest == 0)
{
    System.Console.WriteLine("Число 2 кратно чилу 1");
}
else
{
    System.Console.WriteLine("Остаток от деления: " + rest);
}
*/
/*
System.Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

if (number % 7 == 0 & number % 23 == 0)
{
    System.Console.WriteLine("Да");
}
else
{
    System.Console.WriteLine("Нет");
}
*/
/*
System.Console.Write("Введите число 1: ");
int number1 = int.Parse(Console.ReadLine());

System.Console.Write("Введите число 2: ");
int number2 = int.Parse(Console.ReadLine());

if (number1 > number2)
{
    number2 *= number2;
}
else
{
    number1 *= number1;
}

if (number1 == number2)
{
    System.Console.WriteLine("одно число является квадратом другого");
}
else
{
    System.Console.WriteLine("ни одно число не является квадратом другого");
}
*/

int X = new Random().Next(10, 100);
System.Console.WriteLine(X);

int a = X / 10;
int b = X  % 10;

if (a > b)
{
    System.Console.WriteLine(a);
}
else
{
    System.Console.WriteLine(b);
}