// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


Console.Write("Введите количество элементов массива: ");
int arrLenth = Convert.ToInt32(Console.ReadLine());
double[] array = new double[arrLenth];
FillAndPrintArray(arrLenth);
Console.WriteLine();
Console.WriteLine($"Разница между минимальным и максимальным = {Raznica(array):F2} ");





void FillAndPrintArray(int arrLenth)
{
    Random rand = new Random();
    for (int i = 0; i < arrLenth; i++)
    {
        array[i] = rand.NextDouble();
        Console.Write($"{array[i]:F2} ");
    }

}

double Raznica(double[] array)
{
    double min = array[0];
    double max = array[0];
    double raz = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (max < array[i])
            max = array[i];
        if (min > array[i])
            min = array[i];
    }
    raz = max - min;
    return raz;
}




