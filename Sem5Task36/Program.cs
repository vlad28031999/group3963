// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// * Найдите все пары в массиве и выведите пользователю


//создаём массив
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
// вывод массива в консоль
void PrintArry(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]},");
    }
    Console.WriteLine($"{array[array.Length - 1]}]");
}
//ищем пары чисел
void FindPairsOfNumArry(int[] array)
{
    int arrlen = array.Length;
    for (int j = 0; j < arrlen; j++)
    {
        for (int i = 1; i < arrlen; i++)
        {//исключаем превышение 
            if (array[j] == array[i] && j != i && j < i)
            {
                //печатает найденые пары на консоль
                Console.WriteLine($"Найдены пары: {array[j]} позиция {j+1} и {array[i]} позиция {i+1}");
            }
        }
    }
}
//вывод исходного массива
int[] array = GenArry(-100, 100, 15);
Console.Write("Исходный массив:");
PrintArry(array);
FindPairsOfNumArry(array);