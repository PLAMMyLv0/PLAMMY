const int round = 5;
double[] value = new double[round];
double sum = 0, max = 0, index = 0, avg;
Random r = new Random();

for (int i = 0; i < 5; i++)
{
    value[i] = r.Next(5, 20);
    Console.Write($"Enter a value[{i}] : {value[i]}\n");
    sum += value[i];
    max = Math.Max(max, value[i]);
    if (value[i] == max) index = i;
}

avg = sum / round;
Console.WriteLine($"Sum\tis {sum}\nAvg\tis {avg}\nMax\tis {max} index = {index}");
