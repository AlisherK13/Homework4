// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
int[] array = new int[123];

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(1, 200);
        index++;
    }
}

void PrintArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        Console.Write($"{collection[index]} ");
        index++;
    }
    Console.WriteLine();
}

int sum(int[] collection)
{
    int a = 0;
    for (int i = 0; i < collection.Length; i++)
    {
        if(collection[i] > 10 && collection[i] < 99)
        {
            a += 1; 
        }
    }
    return a;
}

FillArray(array);
PrintArray(array);
Console.WriteLine($"Количество элементов из отрезка [10, 99] = {sum(array)}");