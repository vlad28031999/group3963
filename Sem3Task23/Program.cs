//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
//* Вывести таблицу с границами и значениями друг над другом


// Функция для чтения ввода с консоли, принимает сообщение в качестве аргумента, выводит его и возвращает введенное число.
int ReadInput(string mess)
{
    Console.Write(mess);
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}

// Функция для построения таблицы значений и кубов чисел.
// Принимает на вход число end, которое определяет конечное число, до которого строится таблица.
void LineBuilder(int end)
{
    // Вывод верхней границы таблицы.
    Console.Write("|───────────");
    for (int i = 1; i <= end; i++)
    {
        Console.Write("|───────────");
    }
    Console.WriteLine("┐");

    // Вывод заголовков столбцов.
    Console.Write("|     Value ");
    for (int i = 1; i <= end; i++)
    {
        Console.Write("| {0,-10}", i);
    }
    Console.WriteLine("|");

    // Вывод разделительной линии между заголовками и значениями.
    Console.Write("├───────────");
    for (int i = 1; i <= end; i++)
    {
        Console.Write("┼───────────");
    }
    Console.WriteLine("┤");

    // Вывод значений кубов чисел.
    Console.Write("|     Cube  ");
    for (int i = 1; i <= end; i++)
    {
        Console.Write("| {0,-10}", i * i * i);
    }
    Console.WriteLine("|");

    // Вывод нижней границы таблицы.
    Console.Write("└───────────");
    for (int i = 1; i <= end; i++)
    {
        Console.Write("┴───────────");
    }
    Console.WriteLine("┘");
}

// Получение конечного числа от пользователя и построение таблицы.
int N = ReadInput("Введите конечное число: ");
LineBuilder(N);