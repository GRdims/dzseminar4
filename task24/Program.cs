// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Не использовать Math.Pow() и аналоги!

Console.WriteLine("Ввести число A: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ввести число B: ");
int b = Convert.ToInt32(Console.ReadLine());

int result = a;

for (int i = 1; i < b; i++)
{
    result = result * a;
}
Console.WriteLine($"{a} в степени {b} равно: {result}");

