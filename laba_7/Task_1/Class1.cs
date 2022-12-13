using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.ComponentModel;

namespace Task_1
{
    class Currency : ICloneable
    {
        public int currencyCodeA { get; set; }
        public int currencyCodeB { get; set; }
        public int date { get; set; }
        public double rateBuy { get; set; }
        public double rateSell { get; set; }
        public double rateCross { get; set; }

        public Currency(int a, int b, int d, double buy, double sell, double cross)
        {
            currencyCodeA = a;
            currencyCodeB = b;
            date = d;
            rateBuy = buy;
            rateSell = sell;
            rateCross = cross;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

    }

}
