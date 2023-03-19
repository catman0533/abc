Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());

TableCube(number);
void TableCube(int num)
{
    int i = 1;
    while (i <= num)
    {
       Console.WriteLine($"{i, 4} -> {i*i*i, 4}");
       i++; 
    }
}