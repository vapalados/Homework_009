//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
int Akker(int n, int m)
{ 
    if (n == 0)
    {
        return m + 1;
    }
    else if (n > 0 && m == 0)
    {
        return Akker(n - 1, 1);
    }
    else if (n > 0 && m > 0)
    {
        return Akker(n - 1, Akker(n, m - 1));
    }
    else
    {
        Console.WriteLine("Неверное значение");
        return 0;
    }
}
Console.WriteLine("Введите число и аргумент:");
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Akker(n,m));