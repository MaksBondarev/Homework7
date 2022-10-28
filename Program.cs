// Задача 47. Задайте двумерный массив размером m × n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void InputMatrix(Double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(new Random().NextDouble() * 10, 2);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.WriteLine("Введите колличество строк: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов: ");
int b = Convert.ToInt32(Console.ReadLine());

double[,] matrix = new double [a, b];
InputMatrix(matrix);

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

Console.Clear();

Console.Write("Введите колличество строк: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите колличество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m, n];
Console.WriteLine();

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(1, 101);
        Console.Write($"{matrix[i, j]} \t");
    }
    Console.WriteLine();
}
Console.WriteLine();

Console.Write("Введите номер строки: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите номер столбца: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
int element = 0;

if (a > n)
    Console.Write("Такого элемента нет! ");
else if (b > m)
    Console.Write("Такого элемента нет! ");

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (i == a && j == b)
        {
            element = matrix[i, j];
            Console.Write($"Элемент в двумерном массиве: {element}");
        }
    }
}


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);

            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void FindNumberMatrix(int[,] matrix)
{
    Console.WriteLine("Cреднее арифметическое элементов: ");
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
        }
        Console.Write($"{sum / matrix.GetLength(0)}" + "     ");
    }
}

Console.Clear();

int[,] matrix = new int[5, 5];
InputMatrix(matrix);
FindNumberMatrix(matrix);