// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5


int[] GetArr()
{
    int[] arr = new int[125];
    for (int i = 0; i < arr.Length; i++)
    {
        int Random = new Random().Next(-50, 150);
        arr[i] = Random;
    }
    return arr;
}

void FindDiaNum(int[] arr, out int count) // обязательно нужно задавать начальное значение out int переменной в теле метода
{
    count = 0; // вот тут, но без указания типа переменной т.к. он указан в шапке
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= 10 && arr[i] <= 99) count++;
    }
}

int[] array = GetArr();
Console.WriteLine($"\n\nDefault generated array: \n[{string.Join(",", array)}]");

FindDiaNum(array, out int count);
System.Console.WriteLine($"\nAmount nubers from array between 10 and 99: {count}\n\n");