
// int number = new Random(), Naxt, (100,1000)
// Console.WriteLine ($"Слуыайно число из отрезка 100и-1000 -> {number}");

int number = new Random().Next( 100,1000);
Console.WriteLine($" Случайное число из отрезка 100 -1000  -> { number}");


int SecondDigit = (number /10)%10 ;
Console.WriteLine($"Вторая цифра числа -> {SecondDigit}");

