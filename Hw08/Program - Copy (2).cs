const int round = 5;
double[] price = { 10.50, 20.75, 50.25, 80.75, 65.25 };
double[] unit = new double[round];
double[] amount = new double[round];
double sumUnit = 0, sumAmount = 0;
Random r = new Random();
Console.WriteLine($"Price\tUnit\tAmount");
for (int i = 0; i < round; i++)
{
    unit[i] = r.Next(1, 6);
    amount[i] = price[i] * unit[i];
    Console.Write($"{price[i]}\t{unit[i]}\t{amount[i]}\n");
}
for (int i = 0; i < round; i++)
{
    sumUnit += unit[i];
    sumAmount += amount[i];
}
Console.WriteLine($"Sum\t{sumUnit}\t{sumAmount}");
