// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int InputArrSize(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(System.Console.ReadLine());
}

int[] InputArrDiapasoneGenetation(string text)
{
    System.Console.Write(text);
    return Console.ReadLine().Split(",").Select(int.Parse).ToArray();
}

int[] GetArr(int ArrSize, int[] ArrDiapasoneGenetation)
{
    int[] arr = new int[ArrSize];
    for (int i = 0; i < ArrSize; i++)
    {
        int Random = new Random().Next(ArrDiapasoneGenetation[0], ArrDiapasoneGenetation[1] + 1);
        arr[i] = Random;
    }
    return arr;
}

int[] ProdPairNum(int[] arr, int ArrSize)
{
    int[] ProdPairArr = new int[ArrSize / 2];
    int Count = 0;
    int BackCount = arr.Length - 1;

    for (int i = 0; i < ProdPairArr.Length; i++)
    {
        ProdPairArr[i] = arr[Count] * arr[BackCount];
        Count++;
        BackCount--;
    }
    return ProdPairArr;
}

void PrintArr(int[] arr)
{
    System.Console.WriteLine("Результат расчета: [" + string.Join(",", arr) + "]\n");
}


// ____________________________________________________________________________________________


var ArraySize = InputArrSize("Введите размер массива: ");

var ArrayDiapasoneGenetation = InputArrDiapasoneGenetation("Введите диапазон генерации чисел в массиве через запятую: ");

int[] array = GetArr(ArraySize, ArrayDiapasoneGenetation);

PrintArr(array);

int[] array2 = ProdPairNum(array, ArraySize);

PrintArr(array2);

