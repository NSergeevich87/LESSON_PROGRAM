
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

System.Console.Write("Vvedite cifru dnya nedely: ");
int number = int.Parse(Console.ReadLine());

if (number < 1 | number > 7)
{
    System.Console.WriteLine("V nashey vselennoy nedelya v diapazone 1 - 7");
}

if (number == 6 | number == 7)
{
    System.Console.WriteLine("Eto vijodnoy dyen!");
}

if (number > 0 & number < 6)
{
    System.Console.WriteLine("Rano rasslablyatsya, somoe vremya porabotat");
}

