using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Addignment_3_TradingCards
{
    public class Card
    {
        public string Name { get; set; }
        public string Team { get; set; }
        public int MatchesPlayed { get; set; }
        public int Goals { get; set; }
        public int Assists { get; set; }
        public int Cards { get; set; }
        public string PhotoPath { get; set; }

        public Color BorderColor
        {
            get
            {
                return Team switch
                {
                    "Liverpool" => Color.Red,
                    "Arsenal" => Color.Gold,
                    "Manchester United" => Color.Black,
                    "Manchester City" => Color.Blue,
                    _ => Color.Gray,
                };
            }
        }
        public string PerformanceLevel
        {
            get
            {
                int totalImpact = Goals + Assists - Cards; 
                return totalImpact switch
                {
                    >= 20 => "High",
                    >= 10 => "Moderate",
                    _ => "Low",
                };
            }
        }
        public Color StatColor(int value)
        {
            if (value > 10)
                return Color.Green;
            else if (value > 5)
                return Color.Orange;
            else
                return Color.Red;
        }

    }
}
