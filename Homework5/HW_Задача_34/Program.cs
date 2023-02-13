// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

void InsertArrParametrs(string txt, out int size, out int start, out int finish)
{
    System.Console.Write(txt);
    int[] param = Console.ReadLine()!.Split(";").Select(int.Parse).ToArray();
    size = Convert.ToInt32(param[0]);
    start = param[1];
    finish = param[2];
}

int[] FillArr(int size, int start, int finish)
{
    int[] Arr = new int[Convert.ToInt32(size)];
    for (int i = 0; i < size; i++)
    {
        var random = new Random().Next(start, finish);
        Arr[i] = random;
    }
    return Arr;
}

int FindEven(int[] arr, int size)
{
    int Count = 0;
    for (int i = 0; i < size; i++)
    {
       if ((arr[i]%2) == 0) Count = Count + 1;
    }
    return Count;
}

InsertArrParametrs("Введите параметры автозаполнения массива по закону:\n[Размер массива;Начальное значения (трехзначное) генерации автозаполнения;Конечное значение (трехзначное) генерации автозаполнения] \nВвод: ", out int size, out int start, out int finish);

int[] array = FillArr(size, start, finish);
System.Console.WriteLine($"\n____\n{string.Join("\n", array)}\n____\n");

System.Console.WriteLine($"\nКоличесво четных в массиве: {FindEven(array, size)}\n\n");