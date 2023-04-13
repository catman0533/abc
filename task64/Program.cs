
 

/*Задача 64: Задайте значение N. Напишите программу, которая выведет все
натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N
 = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

Console.WriteLine("Введите натуральное число больше 1:");
int number = Convert.ToInt32(Console.ReadLine());


void NumberCounter (int num)
{   
   
    if (num < 0) Console.Write($"{number} не натуральное число");
    if (num == 0) return;
    Console.Write("{0,4 }" , num  );
    NumberCounter (num - 1);
}      

NumberCounter (number);