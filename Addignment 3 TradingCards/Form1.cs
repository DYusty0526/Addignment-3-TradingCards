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
        }
    }
}
