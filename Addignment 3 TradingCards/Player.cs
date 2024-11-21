using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addignment_3_TradingCards
{
    public class Player
    {
        public string Name { get; set; }
        public string Team { get; set; }
        public int MatchesPlayed { get; set; }
        public int Goals { get; set; }
        public int Assists { get; set; }
        public int Cards { get; set; }
        public string PhotoPath { get; set; }
    }
}
