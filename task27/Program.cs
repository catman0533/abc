Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int sumdigit = SumDigit(number);
Console.WriteLine($" Сумма цифр в числе = {sumdigit}");

int SumDigit(int num)
{
    int sum = 0;
    while (number > 0)
    {
        sum += number % 10;
        number/=10;
    }
    return sum;
}