// Напишите программу, которая принимает на
// вход три числа и проверяет, может ли существовать
// треугольник со сторонами такой длины.
// 
// (Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.)


int ReadNumber (string messageToUser)
{
    Console.WriteLine(messageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int number1 = ReadNumber("Введите первое число:");
int number2 = ReadNumber("Введите второе число:");
int number3 = ReadNumber("Введите третье число:");
    
if(number1 < number2 + number3)
{
    if(number2 < number1 + number3)
    {
        if(number3 < number1 + number2)
        {}
    }
    Console.WriteLine("Треугольник с такимим сторонами может существовать");
}
else
{
    Console.WriteLine("Треугольник с такими сторнами не может существовать");
}
