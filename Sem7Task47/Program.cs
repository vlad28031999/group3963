
// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
// * При выводе матрицы показывать каждую цифру разного цвета(цветов всего 16)


//Принимаем из консоли число
int ReadInputInt(string messeg)
{
    Console.Write(messeg);
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}

//Генерируем массив случайными числами
double[,] Gen2DArrRandom(int row, int colum, int bottom, int top)
{
    Random rnd = new Random();
    double[,] arr = new double[row, colum];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < colum; j++)
        {
            arr[i, j] = Math.Round(rnd.Next(bottom, top) + rnd.NextDouble(), 2);
        }
    }
    return arr;
}

// выводим двумерный массив на экран с разукрашиванием элемента если он равен тому что ввёл пользователь
void Print2DArr(double[,] arr)
{
    int colorIndex = 0;

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            char[] digitArray = arr[i, j].ToString().ToCharArray();

                for (int t = 0; t < digitArray.Length; t++)
                {
                    Console.ForegroundColor = (ConsoleColor)colorIndex;
                    Console.Write(digitArray[t]);
                    colorIndex = (colorIndex + 1) % 16;
                } 
            Console.Write("\t");
            
        }
        Console.WriteLine();
    }
    Console.ResetColor();
}


int countRow = ReadInputInt("Введите количество строк для двумерного массива: ");
int countColum = ReadInputInt("Введите количество столбцов для двумерного массива: ");
int min = ReadInputInt("Введите 1 границу последовательности: ");
int max = ReadInputInt("Введите 2 границу последовательности: ");
if (min > max) (min, max) = (max, min);

double[,] mas = Gen2DArrRandom(countRow, countColum, min, max);
Print2DArr(mas);
