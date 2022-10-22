//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
int vivod_summi(int min, int max)
{ 
    int itog = new int();
     if ((((max - min ) + 1)) % 2 == 0)
    {
        itog = (((max - min ) + 1)) / 2 * (min + max);
    }
    else if ((((max - min ) + 1)) % 2 != 0)
    {
        itog = ((((max - min ) + 1)) / 2 * (min + max)) + (max - (((max - min ) + 1) / 2));
    }
    return itog;
}
Console.WriteLine("Введите 2 числа");
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(vivod_summi(n,m));