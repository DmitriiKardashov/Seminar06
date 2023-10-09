
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите основание системы счисления:");
int baseNumber = Convert.ToInt32(Console.ReadLine());

int DecToBaseNum(int num, int baseNum) //Универсальный метод перевода в разные единицы счисления
{
    int result = 0;
    int mult = 1;
    while (num > 0)
    {
        result += num%baseNum * mult;
        num /= baseNum;
        mult *= 10;
    }
    return result;
}

int res = DecToBaseNum(number, baseNumber);
Console.WriteLine($"{number} в {baseNumber}ой системе счисления -> {res}");