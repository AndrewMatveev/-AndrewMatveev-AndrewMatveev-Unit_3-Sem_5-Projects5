// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, -3] -> да


int[] GenerateArray(out int ArraySize, out int StartDiapasone, out int FinishDiapasone)
{
    StartDiapasone = -100;
    FinishDiapasone = 100;
    ArraySize = new Random().Next(1, 51);

    int[] arr = new int[ArraySize];
    var i = 0;
    while (i < arr.Length)
    {
        var random = new Random().Next(StartDiapasone, FinishDiapasone + 1);
        arr[i] = random;
        i++;
    }
    return arr;
}

int FindingNumber(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void Find(int[] arr, int num, int ArraySize, out string Decision)
{
    Decision = "No desided";
    for (int i = 0; i < ArraySize; i++)
    {
        if (arr[i] == num)
        {
            Decision = "YES";
            break;
        }
        else
        {
            Decision = "NO";
        }
    }
}


int[] array = GenerateArray(out int ArraySize, out int StartDiapasone, out int FinishDiapasone);
System.Console.WriteLine($"Default generated array: [{string.Join(",", array)}]");

int number = FindingNumber($"Insert the finding number in gap between from {StartDiapasone} to {FinishDiapasone}: ");

Find(array, number, ArraySize, out string Decision);
System.Console.WriteLine("Number if finded: " + Decision);