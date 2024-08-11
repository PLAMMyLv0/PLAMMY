Console.Write("Go to number:"); int number = Convert.ToInt32(Console.ReadLine());
int id = number;
int subject = 3;
int test = 3;
double[,,] student = new double[id, subject, test];
double[] sum = new double[subject];
double total, net;
Random r = new Random();
Console.WriteLine("ID\tSubject\t\tTest1(50)\tTest2(50)\tTest3(50)\tTotal(150)\tNet(100%)");

for (int i = 0; i < number; i++)
{
    Console.Write(1 + i);
    for (int j = 0; j < subject; j++)
    {
        sum[j] = 0;
        Console.Write($"\t{1 + j}");

        for (int k = 0; k < test; k++)
        {
            student[i, j, k] = r.Next(0, 51);
            sum[j] += student[i, j, k];
            Console.Write($"\t\t{student[i, j, k]}");
        }

        total = sum[j];
        net = total / (test * 50) * 100;

        Console.Write($"\t\t{total}\t\t{net:F2}%\n");
    }
    Console.WriteLine();
}
