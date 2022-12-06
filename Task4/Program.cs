// Задача 26. - HARD необязательная Напишите программу, которая принимает на вход целое или дробное число и выдаёт количество цифр в числе.
// 452 -> 3
// 82 -> 2
// 9,012 -> 4

Console.WriteLine($"Введите число");

double num = Convert.ToDouble(Console.ReadLine());
double temp = num;
if (temp < 0) temp = -temp;
int count = 0;
if (temp < 1) count = 1;
while (temp % 1 / 10 != 0)
{
    temp = temp * 10;
}

int num1 = Convert.ToInt32(temp);

while (num1 != 0)
{
    num1 = num1 / 10;
    count++;
}

Console.WriteLine($"Количество цифр в числе {num} = {count}");
