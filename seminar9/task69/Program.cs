// Напишите программу, которая на вход принимает два
// числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int numberA = ReadNumber("Введите первое число");
int numberB = ReadNumber("Введите второе число");

int PowAtoB (int numberA, int numberB)
{
    if (numberB == 0) return 1;
    return numberA * PowAtoB(numberA, numberB - 1);
}

Console.WriteLine(PowAtoB(numberA, numberB));