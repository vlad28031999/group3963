// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2
// * Отсортировать массив методом пузырька
// * Отсортируйте массив методом подсчета
// * Сравнить скорость работы метода пузырька и вставки


void PrintData(string text, string print)
{
    Console.WriteLine($"{text}:{print}");
}
// теперь нужно сгенерировать наш массив
int[] GenArry(int min, int max, int indexcount)
{
    int buf;
    if (min > max)
    {
        buf = min;
        min = max;
        max = buf;
    }
    int[] binarray = new int[indexcount];
    System.Random numSintezator = new System.Random();
    for (int i = 0; i < indexcount; i++)
    {
        binarray[i] = numSintezator.Next(min, max);
    }
    return binarray;
}
//Вывод массива в консоль
void PrintArry(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]},");
    }
    Console.WriteLine($"{array[array.Length - 1]}]");
}
// делаем пузырьковый метод
int[] SortArrayBubles(int[] array)
{
    int[] result = array;
    int arrlen = result.Length;
    int buf = result[0];
    for (int j = 0; j < arrlen; j++)
    {
        for (int i = 0; i < arrlen - 1 - j; i++)
        {
            if (result[i] > result[i + 1])
            {
                buf = result[i + 1];
                result[i + 1] = result[i];
                result[i] = buf;
            }
        }
    }
    return result;
}
// метод подсчёта
int[] SortArrayCounts(int[] array)
{
    int[] result = new int[array.Length];
    int arrlght = array.Length;
    int CountInRow;

    for (int j = 0; j < arrlght; j++)
    {
        CountInRow = 0;
        for (int i = 0; i < arrlght; i++)
        {
            if (array[j] > array[i])
            {
                CountInRow++;
            }

        }
        result[CountInRow] = array[j];
    }
    return result;
}
//выводим исходный массив
int[] array = GenArry(99, 1000, 15);
Console.Write("Исходный массив:");
PrintArry(array);
// первый пузырьковый метод
DateTime d1 = DateTime.Now;
int[] resB = SortArrayBubles(array);
TimeSpan interval1 = DateTime.Now - d1;
PrintData("Пузырьковый метод", interval1.ToString());
PrintArry(resB);
//метод сортировки
DateTime d2 = DateTime.Now;
int[] resC = SortArrayCounts(array);
TimeSpan interval2 = DateTime.Now - d2;
PrintData("Метод подсчета", interval2.ToString());
PrintArry(resC);