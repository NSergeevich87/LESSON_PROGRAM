/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int sumnumbers(int x)
{
    int result = 0;
    int y = 0;

    while (x != 0)
    {
        y = x % 10;
        x = x / 10;
        result = result + y;
    }

    return result;
}

System.Console.Write("Vvedite chislo: ");
int n = int.Parse(Console.ReadLine());

int answer = sumnumbers(n);
System.Console.WriteLine($"Summa cifr v chisle: {answer}");