
Console.WriteLine("Введите количество элементов массива:");
int size = Convert.ToInt32(Console.ReadLine());

int Array(int num)
{
    int[] arr = new int[num];
    int count = 0;
    for (int i = 0; i < num; i++)
    {
        Console.WriteLine($"Введите элемент массива №{i}:");
        arr[i] = Convert.ToInt32(Console.ReadLine());
        if (arr[i] > 0) count ++;
    }
    return count;
}

int res = Array(size);
Console.WriteLine($"Количество положительных элементов массива равно {res}");