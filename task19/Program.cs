Console.WriteLine(" ВВедите пятизначное чичло");
int number = Convert.ToInt32(Console.ReadLine());

int firstDigit = number/10000;
int secondDigit = (number/1000)%10;
int fourthDigit = (number/10)%10;
int fifthDigit =  number%10;

if(firstDigit == fifthDigit && secondDigit == fourthDigit )
{
    Console.WriteLine( $"{number} -это число полиндром");
}
else
{
    Console.WriteLine($"{number}- не полиндром");
}

