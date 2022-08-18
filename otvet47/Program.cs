// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine()); 

double[,] GetArray(int m, int n, int minRandom, int maxRandom)
{

double[,] matrix = new double[m, n];
for (int i = 0; i < matrix.GetLength(0); i++) 
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
matrix[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10; 
}
}
return matrix;
}

double[,] resultMatrix = GetArray(rows, columns, -10, 10);
PrintArray(resultMatrix);
void PrintArray(double[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++) 
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
Console.Write(matrix[i, j] + "\t"); 
}
Console.WriteLine();
}
}