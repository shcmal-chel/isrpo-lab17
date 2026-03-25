System.Console.WriteLine("Дан массив: { 5, 4, 5, 3, 4 }");
int[] numbers = { 5, 4, 5, 3, 4 };
int sum = 0;

for (int i = 0; i < numbers.Length; i++)
{
    sum = sum + numbers[i];
}
Console.WriteLine($"Сумма элементов: {sum}");