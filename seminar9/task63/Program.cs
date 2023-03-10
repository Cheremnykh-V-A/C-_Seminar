// Задача 63: Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

int number = 5;

void Print1toN (int n)
{
    if (n < 1) return;
    Print1toN(n - 1);
    Console.Write($"{n} ");
}
Print1toN(number);