//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

using MatrixOperations;

int[,] arr = new int[3, 3];
arr = Matrix.Fill(arr);

int LowestRowSum(int[,] arr)
{
    int[] temp = new int[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum+=arr[i,j];
            
        }
        temp[i] = sum;
    }
    int row = Array.IndexOf(temp, temp.Min())+1;
    return row;
}

Matrix.Print(arr);
Console.WriteLine();
Console.WriteLine($"Строка с наименьше суммой элементов = {LowestRowSum(arr)}");