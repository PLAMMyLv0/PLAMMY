﻿using System;
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
            List<string> Movie = new List<string>
            {
                "Rabbit and Turtle",
                "BlackAdam",
                "Sleep N Rich",
                "Shadowfall",
                "Loneblade",
                "Ember",
                "Thunderstrike",
                "Midnight City",
                "Dreamshade",
                "Stormbound",
                "Ironclad",
                "Nightshade",
                "Pathfinder"
            };
            List<int> SeatNumber = new List<int>();
            List<double> Price = new List<double>();
        }
    }
}