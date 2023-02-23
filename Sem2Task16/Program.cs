//Задача №16
//Напишите программу, которая принимает на вход два числа
// и проверяет, является ли одно число квадратом другого.

int num1 = int.Parst(Console.ReadLine()??"0");
int num2 = int.Parst(Console.ReadLine()??"0");

void SqeaTest(int num1,int num2);
if (num1==num2*num2)
{
    Console.WriteLine($"Число{num1} квадрат числа{num2} ");
else
    {
        Console.WriteLine($"");
    }

}