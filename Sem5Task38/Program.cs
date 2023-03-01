// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76
// Отсортируйте массив методом вставки


// выводим на консоль
void PrintData(string text, double print)
{
    Console.WriteLine($"{text}:{print}");
}
// создаём массив
double[] GenArry(int min, int max, int indexcount)
{
    int buf;
    if (min > max)
    {
        buf = min;
        min = max;
        max = buf;
    }
    double[] binarray = new double[indexcount];
    System.Random numSintezator = new System.Random();
    for (int i = 0; i < indexcount; i++)
    {
        //генератор вещественного массива
        binarray[i] = Math.Round(-min + numSintezator.NextDouble()*(min+max),2);
    }
    return binarray;
}
//выводим массив в консоль
void PrintArr(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]};");
    }
    Console.WriteLine($"{array[array.Length - 1]}]");
}
//ищем пары чисел
(double min, double max) FindMinMaxArry(double[] array)
{
    double arrlen = array.Length;
    double min = array[0];
    double max = array[0];
    for (int i = 1; i < arrlen; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
        else
        {
            max = array[i];
        }

    }

    return (min, max);
}
//сортируем методом вставки
void SortInsertArr(double[] array)
{ 

    for (int i = 1; i < array.Length; i++)
    {
        double key = array[i];
        int j = i - 1;

        while (j >= 0 && array[j] > key)
        {
            array[j + 1] = array[j];
            j--;
        }
        array[j + 1] = key;
    }

}
//выводим исходный массив

double[] array = GenArry(1, 100, 15);
Console.Write("Исходный массив:");
PrintArr(array);
Console.Write("Сортировка методом вставки:");
SortInsertArr(array);
PrintArr(array);

(double min, double max) result = FindMinMaxArry(array);
PrintData("Минимальное значение", result.min);
PrintData("Максимальное значение", result.max);
PrintData("Разница max-min", result.max - result.min);