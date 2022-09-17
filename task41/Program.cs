// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Введите числа через пробел и нажмите Enter");
string numbers = Console.ReadLine()!;
string[] numbersSplit = numbers.Split(' ');


int[] array = new int[numbersSplit.Length];
for (int i = 0; i < numbersSplit.Length; i++)
{
    array[i] = int.Parse(numbersSplit[i]);
    //Console.Write($"{array[i]}{' '}");
}
Console.WriteLine();