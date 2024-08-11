string id;
double department, year, salary, bonus;
Console.Write("Input ID:"); id = Convert.ToString(Console.ReadLine());
Console.Write("Input Sales[1]Accountant[2]:"); department =
Convert.ToDouble(Console.ReadLine());
Console.Write("Input Year:"); year = Convert.ToDouble(Console.ReadLine());
Console.Write("Input Salary:"); salary = Convert.ToDouble(Console.ReadLine());
if (department == 1)
{
    if (year > 5) bonus = salary * 3;
    else bonus = salary * 2;
}
else
{
    if (year > 10) bonus = salary * 4;
    else bonus = salary * 3;
}
Console.Write($"\n\nID:{id}\nYear:{year}\nSalary:{salary}\nNet:{bonus}");
