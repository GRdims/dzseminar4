// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.WriteLine("Ввести число");
int number = Convert.ToInt32(Console.ReadLine()); // конвертации присвоили переменную number

int sum = 0;

while (number > 0)
{
sum = sum + number%10;
number = number / 10;
}
Console.WriteLine($"сумма всех цифр в числе равна {sum}");