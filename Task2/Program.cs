// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
int[] array = new int[10];
int a = 0;
int b = 0;
int c = 0;
int d = 0;
int e = 0;

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(1, 20);
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

int multi(int[] collection)
{
    for (int i = 0; i < 10; i++)
    {
        a = collection[0] * collection[9];
        b = collection[1] * collection[8];
        c = collection[2] * collection[7];
        d = collection[3] * collection[6];
        e = collection[4] * collection[5];
    }
    return a;
    return b;
    return c;
    return d;
    return e;
}

FillArray(array);
PrintArray(array);
Console.WriteLine($"Перемноженные пары: {multi(array)} {b} {c} {d} {e}");