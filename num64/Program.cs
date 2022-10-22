//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
void vivod_chisel(int schet)
{
    if (schet != 0)
    {
    Console.WriteLine(schet);
    schet--;
    vivod_chisel(schet);
    }
}
Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
vivod_chisel(n);