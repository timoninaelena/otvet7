//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет



Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine()); 

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine()); 


int[,] GetArray(int m, int n, int minRandom, int maxRandom)
{

int[,] matrix = new int[m, n];
for (int i = 0; i < matrix.GetLength(0); i++) 
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
matrix[i, j] = new Random().Next(minRandom, maxRandom + 1);
}
}
return matrix;
}

int[,] resultMatrix = GetArray(rows, columns, 0, 10);
PrintArray(resultMatrix);
void PrintArray(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++) 
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
Console.Write(matrix[i, j] + "\t"); 
}
Console.WriteLine();
}


Console.WriteLine("Введите число, которое хотите найти в массиве:");
int number = Convert.ToInt32(Console.ReadLine());

int m = 0;
int n = 0;
bool f = false;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (number == matrix[i, j]) { m = i; n = j; f = true;};
    }
}
if (f)
    Console.WriteLine($"Число найдено. Строка {m + 1} Столбец {n + 1}");
else
    Console.WriteLine("такого числа в массиве нет");
}
        