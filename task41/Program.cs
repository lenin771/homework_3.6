// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Введите числа через пробел и нажмите Enter");
string elementsArray = Console.ReadLine();
string[] elementsSplit = elementsArray.Split(' ');

int[] array = new int[elementsArray.Length];

int rezult=0;
for (int i = 0; i < elementsSplit.Length; i++)
{
    array[i] = int.Parse(elementsSplit[i]);
    Console.Write($"{array[i]}{' '}");
    
    if (array[i] > 0)
    {
        rezult++; 
    }
}
Console.WriteLine($"\n Количество положительных чисел = {rezult}");


