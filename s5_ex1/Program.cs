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

void FillArray(int[] array)
{
    int n = array.Length;
    int i = 0;
    while (i < n)
    {
        array[i] = new Random().Next(100, 1000);
        i++;
    }
}

Console.WriteLine("Введите количество элементов массива ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];

int NewArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < n; i++)
    {
        if (array[i] % 2 == 0) count = count + 1;

        if (array[i] % 2 != 0 && count == 0) count = 0;
    }
    return count;
}

FillArray(array);
PrintArray(array);
Console.WriteLine();
int col = NewArray(array);
Console.WriteLine($"Количество четных чисел в массиве равно {col}");
