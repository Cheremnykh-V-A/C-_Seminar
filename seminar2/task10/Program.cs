// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = Random.Shared.Next(100, 1000);
Console.WriteLine(number);

int numberA = number / 100;
Console.WriteLine(numberA);

int numberB = number % 10;
Console.WriteLine(numberB);

int numberC = numberA * 10;
int sum = numberC + numberB;
Console.WriteLine(sum);