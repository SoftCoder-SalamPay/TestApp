namespace TestApp;

public class MultiDimensionalArrays
{
    public static void NotMain()
    {
        string[,,] names = new string[5, 5, 5]
        {
            {
                {"*", "*", "*", "*", "*"},
                {"*", "*", "*", "*", "*"},
                {"*", "*", "*", "*", "*"},
                {"*", "*", "*", "*", "*"},
                {"*", "*", "*", "*", "*"}
            },
            {
                {"*", "*", "*", "*", "*"},
                {"*", "*", "*", "*", "*"},
                {"*", "*", "*", "*", "*"},
                {"*", "*", "*", "*", "*"},
                {"*", "*", "*", "*", "*"}
            },
            {
                {"*", "*", "*", "*", "*"},
                {"*", "*", "*", "*", "*"},
                {"*", "*", "*", "*", "*"},
                {"*", "*", "*", "*", "*"},
                {"*", "*", "*", "*", "*"}
            },
            {
                {"*", "*", "*", "*", "*"},
                {"*", "*", "*", "*", "*"},
                {"*", "*", "*", "*", "*"},
                {"*", "*", "*", "*", "*"},
                {"*", "*", "*", "*", "*"}
            },
            {
                {"*", "*", "*", "*", "*"},
                {"*", "*", "*", "*", "*"},
                {"*", "*", "*", "*", "*"},
                {"*", "*", "*", "*", "*"},
                {"*", "*", "*", "*", "*"}
            }
        };
    }

    public static void Get3DimensionalArrayValues(string[,,] array)
    {
        for (int d1 = 0; d1 < array.GetLength(0); d1++)
        {
            for (int d2 = 0; d2 < array.GetLength(1); d2++)
            {
                for (int d3 = 0; d3 < array.GetLength(2); d3++)
                {
                    Console.WriteLine($"Names in 3DArray[{d1}, {d2}, {d3}] {array[d1, d2, d3]}");
                }
                Console.WriteLine();
            }
        }
    }

    public static void Set2DimensionalArrayValues(int[,] array, int rows, int cols)
    {
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                Console.Write("Enter value for lane[{0}, {1}]=> ", row, col);
                array[row, col] = int.Parse(Console.ReadLine()!);
            }
        }
    }

    public static void Set2DimensionalArrayValues(char[,] array, int rows, int cols)
    {
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                Console.Write("Enter value for lane[{0}, {1}]=> ", row, col);
                array[row, col] = char.Parse(Console.ReadLine()!);
            }
        }
    }

    public static void Get2DimensionalArrayValueResult(int[,] array)
    {
        for (int row = 0; row < array.GetLength(0); row++)
        {
            for (int column = 0; column < array.GetLength(1); column++)
            {
                Console.WriteLine($"2DArray[{row}, {column}] => {array[row, column]}");
            }
        }
    }

    public static void Get2DimensionalArrayValueResult(char[,] array)
    {
        for (int row = 0; row < array.GetLength(0); row++)
        {
            for (int column = 0; column < array.GetLength(1); column++)
            {
                Console.Write($"{array[row, column]} ");
            }
            Console.WriteLine();
        }
    }
}
