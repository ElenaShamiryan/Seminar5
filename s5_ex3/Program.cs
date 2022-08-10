void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]} ");
        position++;
    }
}

Console.WriteLine("Введите количество элементов массива");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];

int NewArray(int[] array)
{
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(-100, 100);
    }
    int max = array[0];
    int min = array[0];
    int dif = 0;
    for (int i = 0; i < n; i++)
    {
        if (max < array[i]) max = array[i];
        if (min > array[i]) min = array[i];
    }
    dif = max - min;
    return dif;
}

int difference = NewArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {difference}");
