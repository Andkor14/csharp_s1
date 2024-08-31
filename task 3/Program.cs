Console.WriteLine("Введите число");
int value = Convert.ToInt32(Console.ReadLine());
if (value % 2 == 0)
{
    Console.WriteLine($"Число четное {value}");
}
else
{
    Console.WriteLine($" число нечетное {value}");
}
