
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

// number = number/10 ;
// int ThirdDigit = number%10;

if( number > 100 )
 {
    int ThirdDigit = number%10;
    Console.WriteLine($"Третья цифра -> {ThirdDigit}");
 }       
    

else
{
    Console.WriteLine("Третьей цифры нет");
}




   
