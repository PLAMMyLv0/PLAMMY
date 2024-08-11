using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw12OOP
{
    internal class SalesData
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public double SalesAmount { get; set; }
        public int PaymentType { get; set; }

        private double CommissionRate => GetCommissionRate();
        private double Bonus => GetBonus();

        private double GetCommissionRate()
        {
            return SalesAmount switch
            {
                >= 700000 => PaymentType == 1 ? 0.3 : 0.25,
                >= 500000 => PaymentType == 1 ? 0.2 : 0.15,
                _ => 0.1,
            };
        }

        private double GetBonus()
        {
            return SalesAmount switch
            {
                >= 700000 => PaymentType == 1 ? 3000 : 2500,
                >= 500000 => PaymentType == 1 ? 2000 : 1500,
                _ => 1000,
            };
        }

        public double NetCommission => (SalesAmount * CommissionRate) + Bonus;

        public void ShowAll()
        {
            Console.WriteLine($"ID: {Id}\tSalesAmount: {SalesAmount:n0}\tPaymentType: {PaymentType}\tCommissionRate: {CommissionRate:p}\tBonus: {Bonus:n0}\tNetCommission: {NetCommission:n2}");
        }
    }
}
