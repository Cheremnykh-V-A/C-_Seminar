uint number = 4;
// uint - неотрицательное число
uint Factorial (uint n)
{
    if (n == 0) return 1;
    if (n == 1) return 1;
    uint result = n * Factorial(n - 1);
    return result;
}
Console.WriteLine(Factorial(number));