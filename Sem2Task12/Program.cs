// Задача №12
// Напишите программу, которая будет принимать на вход два числа
// и выводить, является ли второе число кратным первому.
// Если второе число некратно первому,
// то программа выводит остаток от деления.

int firstNum = int.Parse(Console.ReadLine()??"0");
 int secondNum = int.Parse(Console.ReadLine()??"0");
if (firstNum%secondNum==0)
{
Console.WriteLine(secondNum + " кратно " + firstNum);
}
else
{
    Console.WriteLine("Второе число не кратно первому");

}