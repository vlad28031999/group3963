﻿//Задача №14
//Напишите программу, которая принимает на вход число
// и проверяет, кратно ли оно одновременно 7 и 23.

int num = new Random().Next(100,1000);
if((num%23==0)&&(num%7==0))
{
Console.WriteLine($"Кратно {num}");
}
else
{
    Console.WriteLine("Не кратно");

}