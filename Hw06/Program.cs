Random rnd = new Random();
int CountID = 1, ID = 0, Number = 0, Section, Age = 0;
int Asection1 = 0, Asection2 = 0, Asection3 = 0, Asection4 = 0, Asection5 = 0;
int Bsection1 = 0, Bsection2 = 0, Bsection3 = 0, Bsection4 = 0, Bsection5 = 0;
int Csection1 = 0, Csection2 = 0, Csection3 = 0, Csection4 = 0, Csection5 = 0;
int Dsection1 = 0, Dsection2 = 0, Dsection3 = 0, Dsection4 = 0, Dsection5 = 0;

Console.Write("Go to number : "); Number = Convert.ToInt32(Console.ReadLine());
do
{
    Age = rnd.Next(25, 61);
    Section = rnd.Next(1, 6);
    Console.WriteLine($"ID : {CountID}\t Age : {Age}\t Section : {Section} ");
    if (Age >= 25 && 30 >= Age)
    {
        switch (Section)
        {
            case 1: Asection1++; break;
            case 2: Asection2++; break;
            case 3: Asection3++; break;
            case 4: Asection4++; break;
            case 5: Asection5++; break;
        }
    }
    else if (Age >= 31 && 40 >= Age)
    {
        switch (Section)
        {
            case 1: Bsection1++; break;
            case 2: Bsection2++; break;
            case 3: Bsection3++; break;
            case 4: Bsection4++; break;
            case 5: Bsection5++; break;
        }
    }
    else if (Age >= 41 && 50 >= Age)
    {
        switch (Section)
        {
            case 1: Csection1++; break;
            case 2: Csection2++; break;
            case 3: Csection3++; break;
            case 4: Csection4++; break;
            case 5: Csection5++; break;
        }
    }
    else if (Age >= 51 && 60 >= Age)
    {
        switch (Section)
        {
            case 1: Dsection1++; break;
            case 2: Dsection2++; break;
            case 3: Dsection3++; break;
            case 4: Dsection4++; break;
            case 5: Dsection5++; break;
        }
    }
    CountID++;
}
while (CountID <= Number);
Console.WriteLine("===========================================");
Console.WriteLine($"Age\t1\t2\t3\t4\t5\n" +
    $"25-30\t{Asection1}\t{Asection2}\t{Asection3}\t{Asection4}\t{Asection5}\n" +
    $"31-40\t{Bsection1}\t{Bsection2}\t{Bsection3}\t{Bsection4}\t{Bsection5}\n" +
    $"41-50\t{Csection1}\t{Csection2}\t{Csection3}\t{Csection4}\t{Csection5}\n" +
    $"51-60\t{Dsection1}\t{Dsection2}\t{Dsection3}\t{Dsection4}\t{Dsection5}");
Console.WriteLine("===========================================");
