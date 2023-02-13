// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


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

int SumOdd(int[] arr, int size)
{
    int Sum = 0;
    for (int i = 1; i < size; i = i + 2)
    {
        Sum = Sum + arr[i];
    }
    return Sum;
}

InsertArrParametrs("Введите параметры автозаполнения массива по закону:\n[Размер массива;Начальное значения генерации автозаполнения;Конечное значение генерации автозаполнения] \nВвод: ", out int size, out int start, out int finish);

int[] array = FillArr(size, start, finish);
System.Console.WriteLine($"\n____\n{string.Join("\n", array)}\n____\n");

System.Console.WriteLine($"\nСумма чисел на нечетных позициях: {SumOdd(array, size)}\n\n");