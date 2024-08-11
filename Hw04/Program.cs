double section, year, salary = 0, bonus = 0;
Console.Write("Section[1-5]:"); section = Convert.ToDouble(Console.ReadLine());
Console.Write("Year:"); year = Convert.ToDouble(Console.ReadLine());
Console.Write("Salary:"); salary = Convert.ToDouble(Console.ReadLine());
switch (section)
{
    case 1:
        if (year >= 2) bonus = salary * 3;
        else bonus = salary * 2;
        break;
    case 2:
        if (year >= 2) bonus = salary * 4;
        else bonus = salary * 3;
        break;
    case 3:
        if (year >= 3) bonus = salary * 3;
        else bonus = salary * 2;
        break;
    case 4:
        if (year >= 3) bonus = salary * 3.5;
        else bonus = salary * 2.5;
        break;
    case 5:
        if (year >= 4) bonus = salary * 4;
        else bonus = salary * 3.5;
        break;
}
double tax = bonus * 0.05;
double salaryTotal = bonus - tax;
Console.Write($"\n\n\nSection:{section}\nYear:{year}\nSalary:{salary}\n+Bonus:{bonus - salary}\n={bonus}\n-Tax:{tax}\nSalary Total:{salaryTotal}");
