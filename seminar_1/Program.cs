//Console.Write("Введите целое число: ");
//int number = int.Parse(Console.ReadLine());
//int result = number * number;
//Console.WriteLine ($"Квадрат входного числа = {result}");

//Console.Write("Введите первое число: ");
//int a = int.Parse(Console.ReadLine());
//Console.Write("Введите второе число: ");
//int b = int.Parse(Console.ReadLine());
//if (b == a * a) 
//{
//Console.WriteLine ("Первое чило является квадратом второго");
//}
//else
//{
//    Console.WriteLine("Превое чило не является квадратом второго");
//}

//Console.Write ("Введите трехзначное число: ");
//int number = int.Parse(Console.ReadLine());
//int result = number % 10;
//Console.WriteLine($"Последняя цифра = {result}");

//Console.Write("Введите номер дня недели от 1 до 7: ");
//int day = int.Parse(Console.ReadLine());

//if (day == 1)
//{
//Console.WriteLine("lunes");
//}
//if (day == 2)
//{
//Console.WriteLine("martes");
//}
//if (day == 3)
//{
//Console.WriteLine("miercoles");
//}
//if (day == 4)
//{
//Console.WriteLine("jueves");
//}
//if (day == 5)
//{
//Console.WriteLine("viernes");
//}
//if (day == 6)
//{
//Console.WriteLine("sabado");
//}
//if (day == 7)
//{
//Console.WriteLine("domingo");
//}
//if (day < 1 || day > 7)
//{
//Console.WriteLine("numero es falso");
//}

Console.Write("escriba el numero del semana: ");
int day = int.Parse(Console.ReadLine());

switch (day)
{
    case 1:
    Console.WriteLine("lunes");
    break;
    case 2:
    Console.WriteLine("martes");
    break;
    case 3:
    Console.WriteLine("miercoles");
    break;
    case 4:
    Console.WriteLine("jueves");
    break;
    case 5:
    Console.WriteLine("viernes");
    break;
    case 6:
    Console.WriteLine("sabado");
    break;
    case 7:
    Console.WriteLine("domingo");
    break;
    default:
    Console.WriteLine("este numeto es falso");
    break;
}