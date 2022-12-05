// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double Num(int A, int B)
{
    double result = Math.Pow(A, B);
    Console.WriteLine($"Число {A} возведенное в {B}-й степени составляет = {result}");
    return result;
}



try
{
    Console.WriteLine("Введите число A");
    int A = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число B");
    int B = Convert.ToInt32(Console.ReadLine());
    Num(A, B);
}

catch
{
    Console.WriteLine("Надо ввести целое число!!!");
}