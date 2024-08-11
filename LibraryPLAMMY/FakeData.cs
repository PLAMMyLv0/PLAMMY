using System;
using System.Collections.Generic;

namespace PLAMMYLibrary
{
    internal class FakeData
    {
        // Title (ชื่อหนังสือ)
        public List<string> Names_ { get; set; }
        // Author (ผู้เขียน)
        public List<string> Authors_ { get; set; }
        //ISBN(รหัส ISBN)
        public List<int> ISBN_ { get; set; }
        //YearPublished(ปีที่พิมพ์)
        public List<int> Years_ { get; set; }
        public FakeData()
        {
            Names_ = new List<string>()
            {
                "YEE",
                "TAE AND WATER:MELON",
                "RabbitC_Blood",
                "She Never Back Cuz She's White",
                "ERROR:D{KIDDING}"
            };

            Authors_ = new List<string>()
            {
                "PLAMMY",
                "TAE",
                "CHING",
                "POY",
                "OIL"
            };
        }
    }
}