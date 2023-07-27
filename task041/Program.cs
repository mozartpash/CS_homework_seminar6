// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.Clear();

int[] array = GetArray();
// Console.WriteLine(String.Join(",",array));
Console.WriteLine("Колличество введённых положительных чисел:  " + Result(array));

int[] GetArray()
{
    Console.WriteLine("Введите числа через запятую");
    int[] array = Array.ConvertAll(Console.ReadLine()!.Split(","), int.Parse);// Конвертация в массив, Разделител запятая, 
    return array;                                                              //int.Parse - конвертация каждого элемента
}

int Result(int[]array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}