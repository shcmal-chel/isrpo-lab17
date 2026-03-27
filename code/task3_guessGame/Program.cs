Random random = new Random();
int n = random.Next(1, 101);
int chance = 0;
Console.WriteLine("Угадай число от 1 до 100");
int ch = 0;
while (ch != n)
{
    Console.Write("Введите число: ");
    ch = Convert.ToInt32(Console.ReadLine());
    chance++;
    if (ch > n)
    {
        Console.WriteLine("Больше");
    }
    else if (ch < n)
    {
        Console.WriteLine("Меньше");
    }

}
Console.WriteLine("Вы угадали!");
Console.WriteLine("Попыток: " + chance);