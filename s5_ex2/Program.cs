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
    int sum = 0;
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(-100, 101);
        if (i % 2 != 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}

int summa = NewArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Сумма чисел, стоящих под нечетными индексами, равна {summa}");
