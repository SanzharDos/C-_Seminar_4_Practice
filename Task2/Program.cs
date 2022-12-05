// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Через строку решать нельзя.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Count(int A)
{
    int temp = A;
    int sum = 0;
    while (temp != 0)
    {
        sum = sum + temp % 10;
        temp = temp / 10;
    }
    Console.WriteLine($"Сумма цифр в числе {A} составляет = {sum}");
    return sum;
}

try
{
    Console.WriteLine("Введите число");
    int A = Convert.ToInt32(Console.ReadLine());
    Count(A);
}

catch
{
    Console.WriteLine("Надо ввести целое число!!!");
}