/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

int newMensaje(string mensaje)
{
   System.Console.Write(mensaje);
   int result = int.Parse(Console.ReadLine());
   return result;
}

int[] arrayNumbers(int len)
{
   int[] array = new int[len];

   for (int i = 0; i < array.Length; i++)
   {
       array[i] = newMensaje($"Введите {i + 1}й элемент: ");
   }

   return array;
}

void SumPositive(int[] array)
{
   int result = 0;

   for (int i = 0; i < array.Length; i++)
   {
      if (array[i] > 0)
      {
         result++;
      }
   }

   System.Console.WriteLine($"Чесел больше 0: {result}");
}

int length = newMensaje("Введите количество чисел желаемое ко вводу: ");
int[] newArray = arrayNumbers(length);
SumPositive(newArray);


