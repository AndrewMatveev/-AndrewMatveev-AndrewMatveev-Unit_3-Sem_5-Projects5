// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

int[] DefaultArrayGenerate()
{
    int size = new Random().Next(1, 11);
    int[] DefaultArray = new int[size];
    for (int i = 0; i < DefaultArray.Length; i++)
    {
        int gap = new Random().Next(-10, 11);
        DefaultArray[i] = gap;
    }
    return DefaultArray;
}

int[] ReplaceArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = -array[i];
    }
    return array;
}


int[] array1 = DefaultArrayGenerate();
System.Console.WriteLine($"Default array: [ {string.Join(", ", array1)} ]");

int[] array2 = ReplaceArray(array1);
System.Console.WriteLine($"Replaced array: [ {string.Join(", ", array2)} ]");
