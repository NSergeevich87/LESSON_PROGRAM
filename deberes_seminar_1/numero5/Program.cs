// Напишите программу, которая на вход принимает одно число (N), 
// а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

Console.Write("vvedite celoe naturalnoe chislo: ");
int N = int.Parse(Console.ReadLine());
int Count = -N-1;
int x = 0;
if (N>0)
{
    while (Count < N)
    {
        x = Count + 1;
        Console.Write($" {x}");
        Count++;
    }
    //Console.WriteLine(-N);
}
else
{
    Console.WriteLine("nekorrektnoe chislo");
}
