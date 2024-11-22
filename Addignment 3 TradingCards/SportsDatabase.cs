using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Addignment_3_TradingCards
{
    public class SportsDatabase
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
                        new Player { Name = "Luis Diaz", Team = "Liverpool", MatchesPlayed = 28, Goals = 10, Assists = 5, Cards = 1, PhotoPath = @"Images\Luis_diaz.jpeg" },
                        new Player { Name = "Darwin Nuñez", Team = "Liverpool", MatchesPlayed = 25, Goals = 12, Assists = 4, Cards = 2, PhotoPath = @"Images\Darwin_Nunez.jpeg" },
                        new Player { Name = "Virgil Van Dijk", Team = "Liverpool", MatchesPlayed = 30, Goals = 2, Assists = 1, Cards = 3, PhotoPath = @"Images\Virgil_Van_Djik.jpeg" }
                    }
                },
                new Team
                {
                    Name = "Arsenal",
                    Players = new List<Player>
                    {
                        new Player { Name = "William Saliba", Team = "Arsenal", MatchesPlayed = 29, Goals = 1, Assists = 2, Cards = 2, PhotoPath = @"Images\William_Saliba.jpeg" },
                        new Player { Name = "Declan Rice", Team = "Arsenal", MatchesPlayed = 32, Goals = 4, Assists = 3, Cards = 2, PhotoPath = @"C:\Users\david\source\repos\Addignment 3 TradingCards\Addignment 3 TradingCards\Images\Declan_Rice.jpeg" },
                        new Player { Name = "Martin Odegaard", Team = "Arsenal", MatchesPlayed = 28, Goals = 8, Assists = 7, Cards = 1, PhotoPath = @"Images\Martin_Odegaard.jpeg" }
                    }
                },
                new Team
                {
                    Name = "Manchester United",
                    Players = new List<Player>
                    {
                        new Player { Name = "Bruno Fernandez", Team = "Manchester United", MatchesPlayed = 30, Goals = 9, Assists = 10, Cards = 2, PhotoPath = @"Images\Bruno_Fernandes.jpeg" },
                        new Player { Name = "Antony dos Santos", Team = "Manchester United", MatchesPlayed = 27, Goals = 5, Assists = 6, Cards = 3, PhotoPath = @"Images\Antony.jpeg" },
                        new Player { Name = "Matthijs de Ligt", Team = "Manchester United", MatchesPlayed = 25, Goals = 3, Assists = 2, Cards = 1, PhotoPath = @"C:\Users\david\source\repos\Addignment 3 TradingCards\Addignment 3 TradingCards\Images\Matthijs_de_Ligt.jpeg" }
                    }
                },
                new Team
                {
                    Name = "Manchester City",
                    Players = new List<Player>
                    {
                        new Player { Name = "Erling Haaland", Team = "Manchester City", MatchesPlayed = 28, Goals = 27, Assists = 6, Cards = 0, PhotoPath = @"C:\Users\david\source\repos\Addignment 3 TradingCards\Addignment 3 TradingCards\Images\Erling_Haaland.jpeg" },
                        new Player { Name = "Ruben Dias", Team = "Manchester City", MatchesPlayed = 29, Goals = 2, Assists = 1, Cards = 1, PhotoPath = @"Images\\Ruben_Dias.jpeg" },
                        new Player { Name = "Kevin De Bruyne", Team = "Manchester City", MatchesPlayed = 26, Goals = 7, Assists = 15, Cards = 1, PhotoPath = @"Images\\Kevind_De_Bruyne.jpeg" }
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

        public List<Card> GetAllCards()
        {
            return Teams
                .SelectMany(t => t.Players)
                .Select(p => new Card
                {
                    Name = p.Name,
                    Team = p.Team,
                    MatchesPlayed = p.MatchesPlayed,
                    Goals = p.Goals,
                    Assists = p.Assists,
                    Cards = p.Cards,
                    PhotoPath = p.PhotoPath
                }).ToList();
        }
    }

}

