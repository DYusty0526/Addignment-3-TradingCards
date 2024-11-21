using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Addignment_3_TradingCards
{
    internal class SportsDatabase
    {
        public List<Team> Teams { get; private set; }

        public SportsDatabase()
        {
            // Initialize the teams and players
            Teams = new List<Team>
            {
                new Team
                {
                    Name = "Liverpool",
                    Players = new List<Player>
                    {
                        new Player { Name = "Luis Diaz", Team = "Liverpool", MatchesPlayed = 28, Goals = 10, Assists = 5, Cards = 1, PhotoPath = "photos/luis_diaz.jpg" },
                        new Player { Name = "Darwin Nuñez", Team = "Liverpool", MatchesPlayed = 25, Goals = 12, Assists = 4, Cards = 2, PhotoPath = "photos/darwin_nunez.jpg" },
                        new Player { Name = "Virgil Van Dijk", Team = "Liverpool", MatchesPlayed = 30, Goals = 2, Assists = 1, Cards = 3, PhotoPath = "photos/van_dijk.jpg" }
                    }
                },
                new Team
                {
                    Name = "Arsenal",
                    Players = new List<Player>
                    {
                        new Player { Name = "William Saliba", Team = "Arsenal", MatchesPlayed = 29, Goals = 1, Assists = 2, Cards = 2, PhotoPath = "photos/saliba.jpg" },
                        new Player { Name = "Declan Rice", Team = "Arsenal", MatchesPlayed = 32, Goals = 4, Assists = 3, Cards = 2, PhotoPath = "photos/rice.jpg" },
                        new Player { Name = "Martin Odegaard", Team = "Arsenal", MatchesPlayed = 28, Goals = 8, Assists = 7, Cards = 1, PhotoPath = "photos/odegaard.jpg" }
                    }
                },
                new Team
                {
                    Name = "Manchester United",
                    Players = new List<Player>
                    {
                        new Player { Name = "Bruno Fernandez", Team = "Manchester United", MatchesPlayed = 30, Goals = 9, Assists = 10, Cards = 2, PhotoPath = "photos/fernandez.jpg" },
                        new Player { Name = "Antony dos Santos", Team = "Manchester United", MatchesPlayed = 27, Goals = 5, Assists = 6, Cards = 3, PhotoPath = "photos/antony.jpg" },
                        new Player { Name = "Matthijs de Ligt", Team = "Manchester United", MatchesPlayed = 25, Goals = 3, Assists = 2, Cards = 1, PhotoPath = "photos/de_ligt.jpg" }
                    }
                },
                new Team
                {
                    Name = "Manchester City",
                    Players = new List<Player>
                    {
                        new Player { Name = "Erling Haaland", Team = "Manchester City", MatchesPlayed = 28, Goals = 27, Assists = 6, Cards = 0, PhotoPath = "photos/haaland.jpg" },
                        new Player { Name = "Ruben Dias", Team = "Manchester City", MatchesPlayed = 29, Goals = 2, Assists = 1, Cards = 1, PhotoPath = "photos/dias.jpg" },
                        new Player { Name = "Kevin De Bruyne", Team = "Manchester City", MatchesPlayed = 26, Goals = 7, Assists = 15, Cards = 1, PhotoPath = "photos/de_bruyne.jpg" }
                    }
                }
            };
        }

        // Query Methods
        public List<Player> GetPlayersByTeam(string teamName)
        {
            return Teams.FirstOrDefault(t => t.Name == teamName)?.Players ?? new List<Player>();
        }

        public List<Player> GetTopScorers(int minGoals)
        {
            return Teams.SelectMany(t => t.Players).Where(p => p.Goals >= minGoals).ToList();
        }
    }
}
