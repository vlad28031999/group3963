// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



//Принимаем из консоли число
int ReadInputInt(string messag)
{
    Console.Write(messag);
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}

//Генерируем массив случайными числами
int[,] Gen2DArrRandom(int row, int colum, int bottom, int top)
{
    Random rnd = new Random();
    int[,] arr = new int[row, colum];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < colum; j++)
        {
            arr[i, j] = rnd.Next(bottom, top);
        }
    }
    return arr;
}

//Вывод двумерного массива на экран 
void Print2DArr(int[,] arr)
{
     for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

//Поиск среднее арифметического элемента в каждом столбце 
double[] ArithmeticMid(int[,] arr)
{
    double[] res = new double[arr.GetLength(1)];
    
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            res[j] = res[j] + arr[i, j];
        }
         res[j] = Math.Round(res[j]/ arr.GetLength(0),5);
    }

    return res;
}

//Вывод массива на экран в 1 строчку
void Print1DArrLine(double[] arr)
{

    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]};\t");
    }
    Console.Write($"{arr[arr.Length - 1]}.");
}


int countRow = ReadInputInt("Введите количество строк для двумерного массива: ");
int countColum = ReadInputInt("Введите количество столбцов для двумерного массива: ");
int min = ReadInputInt("Введите 1 границу последовательности: ");
int max = ReadInputInt("Введите 2 границу последовательности: ");
if (min > max) (min, max) = (max, min);

int[,] mas = Gen2DArrRandom(countRow, countColum, min, max);
Print2DArr(mas);
Console.WriteLine();
Print1DArrLine(ArithmeticMid(mas));