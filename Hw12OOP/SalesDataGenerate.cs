using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw12OOP
{
    internal class SalesDataGenerator
    {
        private List<SalesData> SalesDataList;

        public SalesDataGenerator()
        {
            SalesDataList = new();
        }

        public void Create(int numberOfEntries = 10)
        {
            Random random = new();
            for (int i = 0; i < numberOfEntries; i++)
            {
                SalesDataList.Add(new SalesData { SalesAmount = random.Next(300000, 900000), PaymentType = random.Next(1, 3) });
            }
        }

        public void Display()
        {
            foreach (var item in SalesDataList)
            {
                item.ShowAll();
            }
        }
    }
}
