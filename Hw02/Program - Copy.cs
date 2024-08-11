double tax, bonus, result, Jobposition, year;
Console.Write("[1]Owner[2]Employee:"); Jobposition = Convert.ToDouble(Console.ReadLine());
Console.Write("Input Salary(year):"); year = Convert.ToDouble(Console.ReadLine());
if (Jobposition == 1)
{
    bonus = year * 0.05;
    tax = (bonus + year) * 0.04;
    result = (year + bonus) - tax;
}
if (Jobposition == 2)
{
    bonus = year * 0.04;
    tax = (year + bonus) * 0.02;
    result = (year + bonus) - tax;
}
Console.Write($"+Bonus{bonus}\nSalary(year)+Bonus:{year + bonus}\n-Tax:{tax}\nSalary(year):{result}");
