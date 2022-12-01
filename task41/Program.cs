// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int[] FillArray(int count)
{
    int[] array = new int[count];
    for (int i = 0; i < count; i++)
    {
        Console.Write("Введите число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int CountPositive (int[] array)
{
    int countOfPositive = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >0) countOfPositive ++;
    }
    return countOfPositive;
}

Console.WriteLine ("Введите число М");
int m = Convert.ToInt32(Console.ReadLine());

if (m > 1)
{
    int[] userArray = FillArray(m);
    PrintArray(userArray);
    Console.WriteLine($"Количество чисел больше 0 --> {CountPositive(userArray)}");
}
else Console.WriteLine("Число должно быть больше нуля");