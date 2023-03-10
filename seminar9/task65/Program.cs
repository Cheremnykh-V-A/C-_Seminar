// Задача 65: Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

int end = 8;
int start = 4;

void Print1toN (int n, int m)
{
    if (n < m) return;
    Print1toN(n - 1, m);
    Console.Write($"{n} ");
}
Print1toN(end, start);