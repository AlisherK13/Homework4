// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
double[] array = new double[5];

void PrintArray(double[] array)
{
    int length = array.Length;
    int index = 0;
    while(index < length)
    {
        Console.Write($"{array[index]} ");
        index++;
    }
    Console.WriteLine();
}

void FillArray(double[] array)
{
    int length = array.Length;
    int index = 0;
    while(index < length)
    {
        array[index] = new Random().Next(1, 200) / 10.0;
        index++;
    }
}

double Max(double[] array)
{
    double max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

double Min(double[] array)
{
    double min = 20;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

FillArray(array);
PrintArray(array);
Console.WriteLine($"Максимальное вещественное число = {Max(array)}");
Console.WriteLine($"Минимальное вещественное число = {Min(array)}");
Console.WriteLine($"Разница между максимальным и минимальным = {Max(array) - Min(array)}");