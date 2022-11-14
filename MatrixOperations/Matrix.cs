namespace MatrixOperations
{
    public static class Matrix
    {
        private static double GenerateDouble(double min, double max)
        {
            Random rnd = new Random();
            double number = rnd.NextDouble();
            double rndDouble = number * (max - min) + min;
            return rndDouble;
        }
        public static int[,] Fill(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = new Random().Next(0, 10);
                }
            }
            return arr;
        }
        public static double[,] Fill(double[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = GenerateDouble(-10, 10);
                }
            }
            return arr;
        }

        public static void Print(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        public static void Print(double[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{Math.Round(arr[i, j], 2)} ");
                }
                Console.WriteLine();
            }
        }
    }
}