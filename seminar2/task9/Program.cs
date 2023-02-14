
int number = Random.Shared.Next(10, 100);
Console.WriteLine(number);
int lastDigit = number % 10;

int firstDigit = number / 10;
if (firstDigit > lastDigit)
{
    // Вместо нескольких строк Console.WriteLine()
    Console.WriteLine($"max {firstDigit}, min {lastDigit}");
}
else
{
    Console.WriteLine($"max {lastDigit}, min {firstDigit}");
}