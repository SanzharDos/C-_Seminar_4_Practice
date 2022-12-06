// Задача 30: - HARD необязательная 
// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// Далее надо посчитать количество нулей и единиц, если единиц больше чем нулей то вывести TRUE на экран, иначе вывести False.

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 2);
    }
}

void PrintArray(int[] arr)
{
    Console.Write("Сгенерированный массив = { ");
    int count = arr.Length;
    for (int i = 0; i < count; i++)
    {
        if (i < count - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]} ");
    }
    Console.Write("}");
    Console.WriteLine();
}

void CheckPrint(int[] arr)
{
    int size = arr.Length;
    int count0 = 0;
    int count1 = 0;
    for (int i = 0; i < size; i++)
    {
        if (arr[i] == 0) count0 = count0 + 1;
        else count1 = count1 + 1;
    }
    if (count0 > count1) Console.WriteLine("FALSE");
    else if (count0 == count1) Console.WriteLine("Количество единиц и нулей в массиве одинаковое");
    else Console.WriteLine("TRUE");
}

try
{
    Console.WriteLine("Введите количество элементов в массиве");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[size];
    FillArray(array);
    PrintArray(array);
    CheckPrint(array);
}

catch
{
    Console.WriteLine("Надо ввести число!!!");
}
