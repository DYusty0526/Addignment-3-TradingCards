using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Addignment_3_TradingCards
{
    public partial class Form1 : Form
    {
        private SportsDatabase sportsDatabase;
        private BindingSource cardsBindingSource;

        public Form1()
        {
            InitializeComponent();

            sportsDatabase = new SportsDatabase();
            cardsBindingSource = new BindingSource
            {
                DataSource = sportsDatabase.GetAllCards() 
            };

            Lst_Cards.DataSource = cardsBindingSource;
            Lst_Cards.DisplayMember = "Name";
        }

        private void Lst_Cards_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Lst_Cards.SelectedItem is Card selectedCard)
            {
                pb_PlayerImage.DataBindings.Clear();
                lbl_PlayerName.DataBindings.Clear();
                lbl_Team.DataBindings.Clear();
                lbl_MatchesPlayed.DataBindings.Clear();
                lbl_Goals.DataBindings.Clear();
                lbl_Assists.DataBindings.Clear();
                lbl_Cards.DataBindings.Clear();

                pb_PlayerImage.DataBindings.Add("ImageLocation", selectedCard, "PhotoPath");
                lbl_PlayerName.DataBindings.Add("Text", selectedCard, "Name");
                lbl_Team.DataBindings.Add("Text", selectedCard, "Team");
                lbl_MatchesPlayed.DataBindings.Add("Text", selectedCard, "MatchesPlayed", true, DataSourceUpdateMode.OnPropertyChanged, null, "Matches Played: {0}");
                lbl_Goals.DataBindings.Add("Text", selectedCard, "Goals", true, DataSourceUpdateMode.OnPropertyChanged, null, "Goals: {0}");
                lbl_Assists.DataBindings.Add("Text", selectedCard, "Assists", true, DataSourceUpdateMode.OnPropertyChanged, null, "Assists: {0}");
                lbl_Cards.DataBindings.Add("Text", selectedCard, "Cards", true, DataSourceUpdateMode.OnPropertyChanged, null, "Cards: {0}");

                pnl_CardBorder.BackColor = selectedCard.BorderColor;
                lbl_Goals.ForeColor = selectedCard.StatColor(selectedCard.Goals);
                lbl_Assists.ForeColor = selectedCard.StatColor(selectedCard.Assists);
            }
        }

        private void btn_AddCard_Click(object sender, EventArgs e)
        {
            var newCard = new Card
            {
                Name = "New Player",
                Team = "Unassigned",
                MatchesPlayed = 0,
                Goals = 0,
                Assists = 0,
                Cards = 0,
                PhotoPath = @"Images\default.jpg" 
            };

            var cardList = (List<Card>)cardsBindingSource.DataSource;
            cardList.Add(newCard);

            cardsBindingSource.ResetBindings(false);
        }

        private void btn_RemoveCard_Click(object sender, EventArgs e)
        {
            if (Lst_Cards.SelectedItem is Card selectedCard)
            {
                var cardList = (List<Card>)cardsBindingSource.DataSource;
                cardList.Remove(selectedCard);

                cardsBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Please select a card to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FilterCardsByTeam(string teamName)
        {
            var filteredCards = sportsDatabase.GetAllCards().Where(c => c.Team == teamName).ToList();

            cardsBindingSource.DataSource = filteredCards;
            cardsBindingSource.ResetBindings(false);
        }

        private void btn_Filter_Click(object sender, EventArgs e)
        {
            FilterCardsByTeam("Liverpool");
        }

        private void btn_ShowAll_Click(object sender, EventArgs e)
        {
            cardsBindingSource.DataSource = sportsDatabase.GetAllCards();
            cardsBindingSource.ResetBindings(false);
        }
    }
}

