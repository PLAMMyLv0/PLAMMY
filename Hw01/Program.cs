string id;
float year, salary, bonus = 0;

Console.Write("ID = "); id = Convert.ToString(Console.ReadLine());
Console.Write("Year = "); year = Convert.ToInt64(Console.ReadLine());
Console.Write("Salary = "); salary = Convert.ToInt64(Console.ReadLine());
if (year >= 3) { bonus = salary * 2; Console.Write($"Input Data :  ID:{id}  Year:{year}  Salary:{salary}\nProcess : {bonus}"); }
else { Console.Write($"Input Data :  ID:{id}  Year:{year}  Salary:{salary}\nProcess : {salary}"); }
