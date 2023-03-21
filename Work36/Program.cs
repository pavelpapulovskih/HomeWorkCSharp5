// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-100, 101);
}

void PrintArray(int[] array)
{
    foreach (int item in array)
        Console.Write($"{item} ");
    Console.WriteLine();
}

int SumNeChetnih(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 1 || array[i] % 2 == -1)
            count += array[i];
    }
return count;
}


Console.WriteLine("Введите количество элементов в массиве:");
int arrLenth = Convert.ToInt32(Console.ReadLine());
int[] array = new int[arrLenth];
FillArray(array);
PrintArray(array);
Console.WriteLine($"Сумма не четных элементов в массиве: {SumNeChetnih(array)}");