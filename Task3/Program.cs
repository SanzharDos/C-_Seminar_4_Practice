// Задача 29: Напишите программу, которая задаёт массив из 8 элементов с клавиатуры и выводит массив на экран.

void PrintArray(int[] arr)
{
    Console.Write("Введенный массив = { ");
    int count = arr.Length;
    for (int i = 0; i < count; i++)
    {
        if (i < count - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]} ");
    }
    Console.Write("}");
    Console.WriteLine();
}

void FillArray(int[] arr)
{
    int count1 = arr.Length;
    for (int i = 0; i < count1; i++)
    {
        Console.WriteLine($"Введите {i + 1}-е число массива Array");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
}

try
{
int size = 8;
int[] array = new int[size];
FillArray(array);
PrintArray(array);
}

catch
{
    Console.WriteLine("Надо ввести число!!!");
}

