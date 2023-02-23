//Задача №17
//Напишите программу, которая принимает 
//на вход координаты точки (X и Y),
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости,
// в которой находится эта точка.


//<тип> <имя метода> (<тип> <название переменной>)
// {
 //   return <тип>
//}
int ReadData(string msg) 
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??" 0");
}
void PrintQuterTest(int x, int y)
{
    if(x > 0 && y > 0) Console.WriteLine("Точка в 1 четверти");
    if(x > 0 && y > 0) Console.WriteLine("Точка в 2 четверти");
    if(x > 0 && y > 0) Console.WriteLine("Точка в 3 четверти");
    if(x > 0 && y > 0) Console.WriteLine("Точка в 4 четверти");
}
int  coodX = ReadData("Введите  координату Х");
int  coodY = ReadData("Введите  координату Y");
PrintQuterTest(coodX >coodY);
