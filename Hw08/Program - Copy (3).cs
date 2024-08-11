Random r = new Random();
const int Row = 5;
const int Column = 5;
int[,] number = new int[Row, Column];
double max, sum = 0, avg;
Console.WriteLine($"\t\t\tColumn\nRow\t1\t2\t3\t4\t5\tMax\tSum\tAvg");
for (int i = 0; i < Row; i++)
{
    max = 0;
    sum = 0;
    Console.Write(1 + i);
    for (int j = 0; j < Column; j++)
    {
        number[i, j] = r.Next(1, 11);
        max = Math.Max(max, number[i, j]);
        sum += number[i, j];
        Console.Write($"\t{number[i, j]}");
    }
    avg = sum / Row;
    Console.Write($"\t{max}\t{sum}\t{avg}");
    Console.WriteLine();
}
