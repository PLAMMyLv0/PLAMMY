using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLAMMYCinema
{
    internal class Movie
    {
        //สร้างคลาส Movie ที่มีข้อมูลต่อไปนี้:

        //Title(ชื่อภาพยนตร์)
        public string Title { get; set; }
        //Duration(ความยาวของภาพยนตร์)
        public int Duration { get; set; }
        //Rating(ระดับการรับชม เช่น G, PG, PG - 13)
        public string Rating { get; set; }
        public Movie(string title,int duration,string rating)
        {
            this.Title = title;
            this.Duration = duration;
            this.Rating = rating;
        }
    }
}
