using System.Runtime.InteropServices;

System.Console.WriteLine("Подъем по лестнице");
System.Console.Write("На какой этаж нужно подняться?: ");
int targetFloor = Convert.ToInt32(Console.ReadLine());
int currentFloor = 1;
System.Console.WriteLine("Начинаем подъем!");
while (currentFloor < targetFloor)
{
    currentFloor++;
    System.Console.WriteLine($"Поднялись на {currentFloor}-й этаж");
}
System.Console.WriteLine($"Вы достигли {targetFloor}-го этажа!");
System.Console.WriteLine("Конец программы");