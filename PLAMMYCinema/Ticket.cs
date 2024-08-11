using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLAMMYCinema
{
    internal class Ticket
    {
        //สร้างคลาส Ticket ที่มีข้อมูลต่อไปนี้:

        //Movie(ข้อมูลภาพยนตร์ที่จอง)
        public List<string> Movie { get; set; }
        //SeatNumber(หมายเลขที่นั่ง)
        public List<int> SeatNumber { get; set; }
        //Price(ราคาตั๋ว)
        public List<double> Price { get; set; }
        public Ticket()
        {
            Movie = new List<string>()
            SeatNumber = new List<int>();
            Price = new List<double>();
        }
    }
}
