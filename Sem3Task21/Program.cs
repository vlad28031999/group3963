int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Метод выводит данные пользователю в консоль
void PrintData(string msg, double val)
{
    Console.WriteLine(msg + val);
}

//Метод находит расстояние между точками в 3D пространстве
double CalcLen3D(int x1, int x2, int y1, int y2, int z1, int z2)
{
    return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
}

int x1 = ReadData("Введите координату x точки A: ");
int y1 = ReadData("Введите координату y точки A: ");
int z1 = ReadData("Введите координату z точки A: ");
int x2 = ReadData("Введите координату x точки B: ");
int y2 = ReadData("Введите координату y точки B: ");
int z2 = ReadData("Введите координату z точки B: ");

double res = CalcLen3D(x1, x2, y1, y2, z1, z2);

PrintData("Растояние между точками A и B: ", res);