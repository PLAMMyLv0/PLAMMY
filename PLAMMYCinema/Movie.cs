using System;
using System.Collections.Generic;

namespace PLAMMYCinema
{
    internal class Movie
    {
        //สร้างคลาส Movie ที่มีข้อมูลต่อไปนี้:

        //Title(ชื่อภาพยนตร์)
        public List<string> Title { get; set; }
        //Duration(ความยาวของภาพยนตร์)
        public int Duration { get; set; }
        //Rating(ระดับการรับชม เช่น G, PG, PG - 13, R, NC15, R18)
        public List<string> Rating { get; set; }
        public Movie(int duration,string rating)
        {
            Title = new List<string>
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
            this.Duration = duration;
            Rating = new List<string>
            {
                "G", 
                "PG", 
                "PG-13", 
                "NC15", 
                "R18"
            };
        }
    }
}