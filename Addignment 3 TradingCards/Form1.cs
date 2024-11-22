using System;
using System.Windows.Forms;

namespace Addignment_3_TradingCards
{
    public partial class Form1 : Form
    {
        private SportsDatabase sportsDatabase;

        public Form1()
        {
            InitializeComponent();
            sportsDatabase = new SportsDatabase();

            Lst_Cards.DataSource = sportsDatabase.GetAllCards();
            Lst_Cards.DisplayMember = "Name";
        }

        private void Lst_Cards_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Lst_Cards.SelectedItem is Card selectedCard)
            {
                pb_PlayerImage.ImageLocation = selectedCard.PhotoPath;

                lbl_PlayerName.Text = selectedCard.Name;
                lbl_Team.Text = selectedCard.Team;
                lbl_MatchesPlayed.Text = $"Matches Played: {selectedCard.MatchesPlayed}";
                lbl_Goals.Text = $"Goals: {selectedCard.Goals}";
                lbl_Assists.Text = $"Assists: {selectedCard.Assists}";
                lbl_Cards.Text = $"Disciplinary Cards: {selectedCard.Cards}";

                pnl_CardBorder.BackColor = selectedCard.BorderColor;

                lbl_Goals.ForeColor = selectedCard.StatColor();
                lbl_Assists.ForeColor = selectedCard.StatColor();
            }
        }
    }
}
