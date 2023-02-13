// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


void InsertArrParametrs(string txt, out double size, out double start, out double finish)
{
    System.Console.Write(txt);
    double[] param = Console.ReadLine()!.Split(";").Select(double.Parse).ToArray();
    size = Convert.ToInt32(param[0]);
    start = param[1];
    finish = param[2];
}


double[] FillArr(double size, double start, double finish)
{
    double[] Arr = new double[Convert.ToInt32(size)];
    for (int i = 0; i < size; i++)
    {
        var random = new Random().NextDouble() * (finish - start) + start; // рекомендуемый метод генерации чисел с плавающей точкой в выбранном диапазоне
        Arr[i] = random;
    }
    return Arr;
}

void FindMinMax(double[] arr, double size, out double Min, out double Max)
{
    Min = 0;
    Max = 0;
    for (int i = 0; i < size - 1; i++)
    {
        if (arr[i] < arr[i + 1]) Min = arr[i];
        else Min = arr[i + 1];
    }
    for (int i = 0; i < size - 1; i++)
    {
        if (arr[i] > arr[i + 1]) Max = arr[i];
        else Max = arr[i + 1];
    }
}


InsertArrParametrs("Введите параметры автозаполнения массива по закону:\n[Размер массива;Начальное значения (трехзначное) генерации автозаполнения;Конечное значение (трехзначное) генерации автозаполнения] \nВвод: ", out double size, out double start, out double finish);

double[] array = FillArr(size, start, finish);

System.Console.WriteLine($"\n____________________\n\n{string.Join("\n", array)}\n____________________\n");

FindMinMax(array, size, out double Min, out double Max);

System.Console.WriteLine($"Разница между минимальным и максимальным: {Max - Min}\n\n");