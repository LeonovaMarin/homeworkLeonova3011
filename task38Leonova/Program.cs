// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.
// [3 7 22 2 78] -> 76

int[] NewArrayXXX(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
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
int[] array = NewArrayXXX(10, 10, 99);
PrintArray(array);


int MaxDifference(int[] arr)
{
    int maxNumber =arr[0];
    for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > maxNumber) maxNumber = arr[i];
        }   
    return maxNumber;
    
}

int MinDifference(int[] arr)
{
    int minNumber = arr[0];
    for (int i = 0; i < arr.Length; i++)
        {
             if (arr[i] < minNumber) minNumber = arr[i];
        }
    return minNumber;
}
Console.WriteLine();
int differenceMax = MaxDifference(array);
int differenceMin = MinDifference(array);
int result = differenceMax - differenceMin;

Console.Write(@$"В заданном массиве чисел разница между максимальным и минимальным элементом массива равна {result}");