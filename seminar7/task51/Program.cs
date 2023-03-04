// Задача 51: Задайте двумерный массив.
// Найдите сумму элементов, находящихся на главной
// диагонали (с индексами (0,0); (1;1) и т.д.

int ReadNumber (string messageToUser)
{
     Console.WriteLine(messageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int [,] GetRandomMatrix(int rows, int colums, int leftboarder = 0, int rightboarder = 10)
{
    int [,] matrix = new int [rows, colums];

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Random.Shared.Next(leftboarder, rightboarder +1 );
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int GetSumOfMainDiagonal(int[,] matrix)
{
    int sum = 0;
    for(int i = 0; i < matrix.GetLength(0) && i < matrix.GetLength (1); i++)
    {
        sum += matrix[i, i];
    }
    return sum;
}

int m = ReadNumber("Ввееедите количество строк");
int n = ReadNumber("Введите количество столбцов");

int[,] myMatrix = GetRandomMatrix(m, n);
PrintMatrix(myMatrix);

Console.WriteLine(GetSumOfMainDiagonal(myMatrix));
