//Задача 3: Задайте произвольный массив. 
//Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

Random random = new Random();

int[] FillRandomMas(int size)
{
    int [] mas = new int[size];
    FillMas(mas, size - 1);
    return mas;
}

void FillMas (int[] mas, int i)
{
    if (i < 0)
    {return;}
    mas[i] = random.Next(0, 1000);
    FillMas(mas, i - 1);
}

void PrintMasReversed(int[] mas, int i)
{
    if (i < 0)
    {return;}
    Console.Write(mas[i] + " ");
    PrintMasReversed(mas, i - 1);
}

Console.WriteLine("Введите размерность: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] mas = FillRandomMas(length);
Console.WriteLine("Реверсивный массив: ");
PrintMasReversed(mas, length - 1);