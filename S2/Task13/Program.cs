// Решение задачи № 13

// метод выделения 3 цифры
void DecimalView(int num)
{
    if (Math.Abs(num) < 100)
    {
        Console.WriteLine ("В Вашем числе нет третьей цифры");
    }
    else
    {
        Console.Write("Третья цифра в вашем числе: ");
        Console.WriteLine(Math.Abs((num % 1000 - num % 100) / 100));
    }
}

// ввод данных
Console.Write("Ведите целое число: ");
//вызываю метод
DecimalView(Convert.ToInt32(Console.ReadLine()));
