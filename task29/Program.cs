// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Данные вводятся с консоли пользователем

int[] array = SetArray(8);
Console.WriteLine($"{String.Join(",", array)} -> [{String.Join(",", array)}]");

int[] SetArray(int size){
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(-100, 100);
    }

    return result;
}