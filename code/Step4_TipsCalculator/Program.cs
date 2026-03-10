
Console.WriteLine("Калькулятор чаевых");
System.Console.Write("Введите сумму счета (руб): ");
double bill = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите процент чаевых (например, 10): ");
double tipPercent = Convert.ToDouble(Console.ReadLine());
double tipAmount = bill * (tipPercent / 100);
double totalAmount = bill + tipAmount;
Console.WriteLine("\nРезультат:");
Console.WriteLine($"Сумма счёта: {bill} руб");
Console.WriteLine($"Чаевые ({tipPercent}%): {tipAmount} py6");
Console.WriteLine($"Итого к оплате: {totalAmount} руб");
Console.WriteLine("Спасибо за использование калькулятора!");