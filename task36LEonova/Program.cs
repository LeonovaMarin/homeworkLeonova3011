// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0

int[] NewArrayXXX(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0, 99);
    }
    return arr;
}
 void PrintArray(int[] arr)
{
       for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
            Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
}

Console.Write("Новый массив: ");
int[] array = NewArrayXXX(10);
PrintArray(array);

int OddElements(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 1)
        if (i % 2 == 1)
    result += arr[i];
    }
    return result;
}

Console.WriteLine();
int oddNumber = OddElements(array);
Console.WriteLine($" Cумма элементов массива, стоящих на нечётных позициях равна {oddNumber}");