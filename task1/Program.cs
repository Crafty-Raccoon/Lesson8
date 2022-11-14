//Задайте двумерный массив. Напишите программу, которая упорядочивает по убыванию элементы каждой строки двумерного массива.

using MatrixOperations;

int[,] arr = new int[3, 3];
arr = Matrix.Fill(arr);

int[,] SortArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 1; j < arr.GetLength(1); j++)
        {
            int temp = arr[i, j];
            int flag = 0;
            for (int t = j-1; t >= 0 && flag != 1;)
            {
                if (temp < arr[i, t])
                {
                    arr[i,t+1] = arr[i,t];
                    t--;
                    arr[i,t+1] = temp;
                }
                else flag = 1;
            }
        }
    }
    return arr;
}


Matrix.Print(arr);
Console.WriteLine();
Matrix.Print(SortArray(arr));