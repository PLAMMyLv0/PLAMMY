int id, adult, child, adult1 = 0, child1 = 0, ac;
float money = 0;

while (true)
{
    Console.Write("Enter id (0-Exit):"); id = Convert.ToInt32(Console.ReadLine());
    if (id == 0) break;
    else
    {
        Console.Write("Amount of adult:"); adult = Convert.ToInt32(Console.ReadLine());
        Console.Write("Amount of child:"); child = Convert.ToInt32(Console.ReadLine());
    }
    money += (adult * 10000) + (child * 3000);
    adult1 += adult;
    child1 += child;
}
ac = adult1 + child1;
Console.Write($"\n\nAll adult:{adult1}\nAll child:{child1}\nAll person:{ac}\nAll money:{money:n2}");
