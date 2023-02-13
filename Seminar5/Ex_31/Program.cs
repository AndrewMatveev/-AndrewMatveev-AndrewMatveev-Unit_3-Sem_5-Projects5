// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.


// // __________1. САМОСТОЯТЕЛЬНАЯ ВЕРСИЯ____________________
// int[] AutoFill(int[] array)
// {
//     for (int i = 0; i < 12; i++)
//     {
//         array[i] = new Random().Next(-9, 9);
//     }
//     return array;
// }
// int sumpositive(int[] array)
// {
//     int positive = 0;
//     for (int i = 0; i < 12; i++)
//     {
//         if (array[i] > 0)
//         {
//             positive = positive + array[i];
//         }
//     }
//     return positive;
// }
// int sumnegative(int[] array)
// {
//     int negative = 0;
//     for (int i = 0; i < 12; i++)
//     {
//         if (array[i] < 0)
//         {
//             negative = negative + array[i];
//         }
//     }
//     return negative;
// }

// int[] arr = new int[12];
// AutoFill(arr);
// System.Console.WriteLine(string.Join(";", arr));
// System.Console.WriteLine(sumpositive(arr));
// System.Console.WriteLine(sumnegative(arr));
// //______________________________________________________










//_________________2. ВЕРСИЯ ИЗ ЗАПИСИ СЕМИНАРА________________________________________________


int[] GenerateArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    var rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1); // -9, 9 + 1
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

int[] myArray = GenerateArray(6, -9, 9);
PrintArray(myArray);


// // _____________2.1 Версия с выводом суммы с двумя методами суммирования___________________

// int SumNegative(int[] array)
// {
//     int result = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] < 0)
//         {
//             result += array[i];
//         }
//     }
//     return result;
// }

// int SumPositive(int[] array)
// {
//     int result = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0)
//         {
//             result += array[i];
//         }
//     }
//     return result;
// }

// System.Console.WriteLine($"Cyммa отрицательныъ элементов равна {SumNegative(myArray)}");
// System.Console.WriteLine($"Cyммa положительных элементов равна {SumPositive(myArray)}");

// //___________________________________________________________________________________________



// // _____________2.2 Версия с выводом суммы с одним методами суммирования____________________


// // // __________2.2.1 вывод суммы через массив _____________________________________________

void SumNegativeAndPositive(int[] array, out int SumPositive, out int SumNegative)
{
    SumPositive = 0;
    SumNegative = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            SumNegative += array[i];
        }
        else
        {
            SumPositive += array[i];
        }
    }
}



SumNegativeAndPositive(myArray, out int SumPositive, out int SumNegative);
System.Console.WriteLine($"Cyммa отрицательных элементов равна {SumNegative}");
System.Console.WriteLine($"Cyммa положительных элементов равна {SumPositive}");

// // // ______________________________________________________________________________________

// // // __________2.2.2 вывод суммы через out int - переменные _______________________________
