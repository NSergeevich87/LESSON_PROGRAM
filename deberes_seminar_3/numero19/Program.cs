/*
Задача 19: Напишите программу, которая принимает 
на вход пятизначное число и проверяет, является ли 
оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да
*/

void palindrom(int x)
{
x = Math.Abs (x);

int a;
int b;

if (x < 10000 || x > 99999)
{
    System.Console.WriteLine("Prosili vvesti 5ti znachnoe chislo!");
}

else
{
    a = x / 1000;
    b = x % 100;

    if (a == b)
    {
        System.Console.WriteLine("PALINDROM");
    }
    
    if (a > b)
    {
        b = b + 9;
        if (a == b)
        {
            System.Console.WriteLine("PALINDROM");
        }
        else
        System.Console.WriteLine("NE PALINDROM");
    }

    if (a < b)
    {
        a = a + 9;
        if (a == b)
        {
            System.Console.WriteLine("PALINDROM");
        }
        else
        System.Console.WriteLine("NE PALINDROM");
    }
}
}

System.Console.Write("Vvedite 5ti znachnoe chislo: ");
int number = int.Parse(Console.ReadLine());

palindrom(number);