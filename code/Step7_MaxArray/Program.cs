System.Console.WriteLine("Дан массив: { 5, 4, 5, 3, 4 }");
int[] numbers = { 5, 4, 5, 3, 4 };
int max = numbers[0];

for (int i = 1; i < numbers.Length; i++)
{
    if (numbers[i] > max)
    {
        max = numbers[i];
    }
}
Console.WriteLine($"Максимальный элемент: {max}");