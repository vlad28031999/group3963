// Задача 13: Напишите программу,
// которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

// Ввод числа
Console.WriteLine("Введите число");
string? num = Console.ReadLine();
string? numA =1;
char[] array = num.ToCharArray();
   if (array[1]+numA)
{
   Console.WriteLine($"Последния цифра числа{num}"  +array [2]);
}
else 
{
    Console.WriteLine("Третьей цифры нет");
}