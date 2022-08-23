//int a = Convert.ToInt32(Console.ReadLine());
//int b = Convert.ToInt32(Console.ReadLine());
//int result = b * b;
//if (result == a)
//{
  //  Console.WriteLine("да");
//}
//else
//{
//    Console.WriteLine("нет");
//}

/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8



Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int a = 1;
while ( a <= N )
{
    if ( a % 2 == 0)
    {
        Console.Write("Чётное: ");
        Console.WriteLine(a);
    }
    a++;
}
Console.WriteLine("END");   
*/


Random random = new Random();
int randomNumber = random.Next(1,100);
Console.WriteLine(randomNumber);
int lastNumber = randomNumber % 10;
int firstNumber = randomNumber / 10;

if(lastNumber > firstNumber)
{
  Console.WriteLine($"Максимальное число равно {lastNumber}");
}
else
{
  Console.WriteLine($"Максимальное число равно {firstNumber}");
}