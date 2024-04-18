//Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.

Console.WriteLine("Введите значение m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение n: ");
int n = Convert.ToInt32(Console.ReadLine());

int res = AkkermanFunction(m, n);
Console.WriteLine($"Результат функции для m={m} и n={n} равен {res}");

int AkkermanFunction(int m, int n)
{
    if (m == 0)
    {return n + 1;}
    else if (n == 0)
    {return AkkermanFunction (m - 1, 1);}
    else
    {return AkkermanFunction (m - 1, AkkermanFunction (m, n - 1));}
}