const int Row = 4;
const int Column = 4;
int[,] Score = new int[Row, Column];

double[] ColumnSum = new double[Column];
double RowSum, RowAvg, ColumnAvg;

double[] ColumnMax = new double[Column];
double[] ColumnMin = new double[Column];

Random rnd = new Random();

for (int j = 0; j < Column; j++)//j=column
{
    ColumnMax[j] = double.MinValue;
    ColumnMin[j] = double.MaxValue;
}

for (int i = 0; i < Row; i++)
{
    RowSum = 0;
    Console.Write(1 + i);

    for (int j = 0; j < Column; j++)
    {
        Score[i, j] = rnd.Next(1, 101);
        Console.Write($"\t{Score[i, j]} ");
        RowSum += Score[i, j];
        ColumnSum[j] += Score[i, j];

        ColumnMax[j] = Math.Max(ColumnMax[j], Score[i, j]);
        ColumnMin[j] = Math.Min(ColumnMin[j], Score[i, j]);
    }

    RowAvg = RowSum / Column;
    Console.Write($"\t{RowSum}\t{RowAvg}\n");
}


Console.Write("\nAvg");
for (int i = 0; i < Column; i++)
{
    ColumnAvg = ColumnSum[i] / Row;
    Console.Write($"\t{ColumnAvg}");
}

Console.Write("\nMax");
for (int i = 0; i < Column; i++)
{
    Console.Write($"\t{ColumnMax[i]}");
}

Console.Write("\nMin");
for (int i = 0; i < Column; i++)
{
    Console.Write($"\t{ColumnMin[i]}");
}
