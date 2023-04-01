// Console.WriteLine("Введите количество чисел :");
// int M = Convert.ToInt32(Console.ReadLine());

// int Prompt(string message);

int[] InputArray(int Length)
{
    int[]array = new int [Length];
    for (int i = 0; i < array.Length; i++)
    {
       array[i] = Prompt ($"Введите {i+1}-й элемент");
    } 
    return array;
}

void PrintArray (int[]array)
{
    for (int i = 0; i < array.Length; i++)
    {
      Console.WriteLine($" a({i})= array{i}");  
    }
}

int CountPositiveNumber(int[]array)
{

    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
     if(array[i] >0)
     count++;
    }
    return count;
}

int[] inputArray =  InputArray(int  Length);
PrintArray(array);
int countPositiveNumber(=  CountPositiveNumber(int[]array)
Console.WriteLine($" Количество чмсел больеш 0 -> {countPositiveNumber}";)

    
    