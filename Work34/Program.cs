// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 301);
}

void PrintArray(int[] array)
{
    foreach (int item in array)
        Console.Write($"{item} ");
    Console.WriteLine();
}

int SumChetnih(int[] array)
{
    int count = 0;
    foreach (int item in array)
    {
        if (item %2 == 0)
            count++;
    }
    return count;
}




Console.WriteLine("Введите количество элементов в массиве");
int arrLenth = Convert.ToInt32(Console.ReadLine());
int[] array = new int[arrLenth];
FillArray(array);
PrintArray(array);
Console.WriteLine($"Сумма четных элементов в массиве: {SumChetnih(array)}");
