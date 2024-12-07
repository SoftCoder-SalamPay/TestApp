
using TestApp;

DiceRoll.DiceEngine();


Console.Write("Enter number for rows: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Enter number for columns: ");
int cols = int.Parse(Console.ReadLine()!);

int[,] integerArrays = new int[rows, cols];

MultiDimensionalArrays.Set2DimensionalArrayValues(integerArrays, rows, cols);

MultiDimensionalArrays.Get2DimensionalArrayValueResult(integerArrays);

char[,] symbols = new char[rows, cols];

MultiDimensionalArrays.Set2DimensionalArrayValues(symbols, rows, cols);

MultiDimensionalArrays.Get2DimensionalArrayValueResult(symbols);

