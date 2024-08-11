using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    internal class Product// Properties
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public int Psale { get; set; }
        public int Rate { get; set; }
    }

    internal class Production
    {
        private List<Product> products;

        public Production() // Constructor
        {
            products = new List<Product>(); //Products list
        }

        public void Create(int num = 5) // Default parameter
        {
            Random rnd = new Random();

            for (int i = 0; i < num; i++)
            {
                products.Add(new Product
                {
                    Id = i + 1,
                    Name = "PLAMMY" + i,
                    Salary = rnd.Next(17500, 35000) + rnd.NextDouble(),
                    Psale = rnd.Next(12000, 35000),
                    Rate = rnd.Next(1, 30)
                });
            }
        }

        public void Display()//เรียงช่องให้สวยโดยใช้GPT
        {
            Console.WriteLine("{0,-5}{1,-10}{2,-15}{3,-10}{4,-10}{5,-15}{6,-15}{7,-15}",
                              "ID", "Name", "Salary", "Psale", "Rate", "Commission", "Tax(5%)", "Net");

            foreach (var item in products)
            {
                double commission = (item.Psale * item.Rate) / 100.0;
                double totalIncome = item.Salary + commission;
                double tax = totalIncome * 0.05;
                double net = totalIncome - tax;

                Console.WriteLine("{0,-5}{1,-10}{2,-15:n2}{3,-10}{4,-10:n2}{5,-15:n2}{6,-15:n2}{7,-15:n2}",
                                                  item.Id, item.Name, item.Salary, item.Psale, item.Rate, commission, tax, net);
            }
        }
    }
}
