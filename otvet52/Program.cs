//  Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив: 1 4 7 2     5 9 2 3    8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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



for (int j = 0; j < matrix.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum = sum + matrix[i, j];
    }
    Console.Write($"среднее арифметическое: { sum / matrix.GetLength(0)}; ");
}

}


