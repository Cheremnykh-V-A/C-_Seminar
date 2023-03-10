// Задача 67: Напишите программу, которая будет принимать на вход число 
// и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int number = ReadNumber("Введите число");

int PrintSumOfDigits (int number)
{
    int sum = 0;
    sum += number % 10;
    if(number > 10) 
    {
       sum += PrintSumOfDigits(number / 10);
    }
    return sum;
}

int result = PrintSumOfDigits(number);
Console.WriteLine($"Сумма всех цифр этого числа = {result}");