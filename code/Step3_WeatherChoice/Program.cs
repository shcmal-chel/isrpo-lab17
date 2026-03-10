// See https://aka.ms/new-console-template for more information
Console.WriteLine("Выбор одежды по погоде");
System.Console.WriteLine("Введите текущую температуру (°C): ");
int temperature = Convert.ToInt32(Console.ReadLine());
if (temperature >= 20)
{
    System.Console.WriteLine("Наденьте легкую одежду");
}
else
{
    System.Console.WriteLine("Наденьте теплую одежду");
}
System.Console.WriteLine("Хорошего дня!");