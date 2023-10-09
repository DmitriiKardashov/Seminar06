
int[] FiboArreay(int num)
{
    int[] fibonacci = new int[num];
    fibonacci[1] = 1;
    for (int i = 2; i < num; i++)
    {
        fibonacci[i] = fibonacci[i-1] + fibonacci[i-2];
    }
    return fibonacci;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length -1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");

}

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
if (number <2) 
{
    Console.WriteLine("Введите число большее или равноее 2.");
    return;
}

int[] res = FiboArreay(number);
PrintArray(res);