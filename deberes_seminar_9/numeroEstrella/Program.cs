/* Задача со звездочкой Найти второй максимум в массиве.
4, 4, 3, 0, 2 => 3 */

System.Console.Clear();

int NewMessage(string message)
{
    System.Console.Write(message);
    string answer = System.Console.ReadLine();
    int result = int.Parse(answer);
    return result;
}

int[] GenerArray(int size, int from, int to)
{
    int[] newArray = new int[size];

    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = new Random().Next(from, to + 1);
    }

    return newArray;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
}

void SecondMaxInArray(int[] array)
{
    System.Console.WriteLine();

    int fMax = 0;
    int sMax = 0;
    
    // Необходимо 2 раза пройти по массиву
    for (int i = 0; i < 2; i++)     
    {
        for (int j = 0; j < array.Length; j++)
        {
            if (array[j] > fMax) fMax = array[j];
            // Для второго максимума нужно прописать сложное условие с обязательной проверкой каждого
            if (array[j] > sMax & array[j] != fMax & array[j] < fMax & array[j] > sMax) sMax = array[j]; 
        }

    }


    System.Console.Write($"Первый максимум в массиве: {fMax}");
    System.Console.WriteLine();
    System.Console.Write($"Второй максимум в массиве: {sMax}");
}

int sizeArray = NewMessage("Введите размер массива: ");
int numberFrom = NewMessage("Введите диапазон чисел ОТ: ");
int numberTo = NewMessage("Введите диапазон чисел ДО: ");

int[] randomArray = GenerArray(sizeArray, numberFrom, numberTo);
PrintArray(randomArray);
SecondMaxInArray(randomArray);
