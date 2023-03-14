using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace knowledge_check_2
{
    internal class seat
    {
        public string seatType { get; set; }
        public int legs { get; set; }
        public string softness { get; set; }
        public string color { get; set; }

        public seat(string seatType, int legs, string softness, string color)
        {
            this.seatType = seatType;
            this.legs = legs;
            this.softness = softness;
            this.color = color;
        }

    }
}
