//Задача №16
//Напишите программу, которая принимает на вход два числа
// и проверяет, является ли одно число квадратом другого.

int num1 = int.Parse(Console.ReadLine()??"0");
int num2 = int.Parse(Console.ReadLine()??"0");

if (num1==num2*num2)
{
    Console.WriteLine($"Число{num1} квадрат числа{num2} ");
 }
else
    {
        Console.WriteLine($"Не является");
    }

