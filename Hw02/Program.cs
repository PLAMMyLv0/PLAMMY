double price, num, total, discount = 0.1, tax = 0.07, member, memberY, memberN, memberTax, result;
Console.Write("Price:"); price = Convert.ToDouble(Console.ReadLine());
Console.Write("Num:"); num = Convert.ToDouble(Console.ReadLine());
total = price * num;

memberN = total * tax;
result = total + memberN;

memberY = total * discount;
memberTax = (total - memberY) * tax;

Console.Write("Member[1:YES,2:NO]:"); member = Convert.ToDouble(Console.ReadLine());
if (member == 1) result = total + memberTax;
Console.Write($"\n\nPrice:{price}\nNum:{num}\nCost:{total}\nTotal:{result}");