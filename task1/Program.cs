Console.Write("Введите количество элементов массива: ");
int size = Convert.ToInt16(Console.ReadLine());
Random r = new Random();
int[] array = new int[size];
int sum = 0;
{
    for (int i = 0; i < size; i++)
    {
        array[i] = r.Next(-20, 20);
        Console.Write(array[i] + " ");
    }
    for (int i = 0; i < size; i++)
    {
        if (i % 2 != 0)
        sum += array[i];
    }
    Console.WriteLine();
    Console.Write($"Сумма нечетных элементов массива= {sum}");
}