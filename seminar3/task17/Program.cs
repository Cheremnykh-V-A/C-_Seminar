
int ReadNumber (string messageToUser)
{
     Console.WriteLine(messageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}


int x = ReadNumber("Введите координаты Х");

int y = ReadNumber("Введите координаты Y");

if(x > 0 && y > 0)
{
    Console.WriteLine("Точка находится в первой координатной четверти");
}

else if(x < 0 && y > 0)
{
    Console.WriteLine("Точка находится во второй координатной четверти");
}

else if(x < 0 && y < 0)
{
    Console.WriteLine("Точка находится в третьей координатной четверти");
}

else if(x > 0 && y < 0)
{
    Console.WriteLine("Точка находится в четвёртой координатной четверти");
}

else
{
    Console.WriteLine("Невозможно определить координатную четверть");
}