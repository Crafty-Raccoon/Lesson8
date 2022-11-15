//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

using MatrixOperations;

int[,] array1 = new int[2, 3];
int[,] array2 = new int[3, 3];

Matrix.Fill(array1);
Matrix.Fill(array2);

int[,] MatrixMult(int[,] arr1, int[,] arr2)
{
    if (arr1.GetLength(1) != arr2.GetLength(0)) throw new Exception("Матрицы нельзя перемножить");

    int[,] result = new int[arr1.GetLength(0), arr2.GetLength(1)];
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            for (int k = 0; k < arr2.GetLength(0); k++)
            {
                result[i, j] += arr1[i, k] * arr2[k, j];
            }
        }
    }
    return result;
}

Matrix.Print(array1);
Console.WriteLine();

Matrix.Print(array2);
Console.WriteLine();

Console.WriteLine("Результат умножения матриц:");
Matrix.Print(MatrixMult(array1, array2));
