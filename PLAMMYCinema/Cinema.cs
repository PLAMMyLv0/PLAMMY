using System;
using System.Collections.Generic;

namespace PLAMMYCinema
{
    internal class Cinema
    {
        //จากนั้นสร้างคลาส Cinema ที่สามารถ:
        List<Ticket> CinemaList;

        public Cinema()
        {
            CinemaList = new List<Ticket>();
        }

        //แสดงรายการภาพยนตร์ที่มีให้จอง
        public void ShowMovie()
        {
            Console.Write("HELLO");
        }

        //จองตั๋วสำหรับภาพยนตร์
        //แสดงรายละเอียดการจองตั๋ว
    }
}
