Console.WriteLine("Введите число A");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B:");
int numberB = Convert.ToInt32(Console.ReadLine());

int todegree = ToDegree (numberA, numberB);
Console.WriteLine($"Число A в степени B = {todegree} ");

int ToDegree(int a, int b)
{
    int res = 1;
    for (int i = 1; i <= numberB; i++)

        res *= numberA;
    return res;
}  




