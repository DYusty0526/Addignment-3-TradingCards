namespace Addignment_3_TradingCards
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Lst_Cards = new ListBox();
            lbl_PlayerName = new Label();
            pb_PlayerImage = new PictureBox();
            lbl_Team = new Label();
            pnl_CardBorder = new Panel();
            lbl_MatchesPlayed = new Label();
            lbl_Goals = new Label();
            lbl_Assists = new Label();
            lbl_Cards = new Label();
            ((System.ComponentModel.ISupportInitialize)pb_PlayerImage).BeginInit();
            SuspendLayout();
            // 
            // Lst_Cards
            // 
            Lst_Cards.FormattingEnabled = true;
            Lst_Cards.Location = new Point(276, 147);
            Lst_Cards.Name = "Lst_Cards";
            Lst_Cards.Size = new Size(150, 104);
            Lst_Cards.TabIndex = 0;
            Lst_Cards.SelectedIndexChanged += Lst_Cards_SelectedIndexChanged;
            // 
            // lbl_PlayerName
            // 
            lbl_PlayerName.AutoSize = true;
            lbl_PlayerName.Location = new Point(12, 217);
            lbl_PlayerName.Name = "lbl_PlayerName";
            lbl_PlayerName.Size = new Size(50, 20);
            lbl_PlayerName.TabIndex = 2;
            lbl_PlayerName.Text = "label1";
            // 
            // pb_PlayerImage
            // 
            pb_PlayerImage.Location = new Point(12, 69);
            pb_PlayerImage.Name = "pb_PlayerImage";
            pb_PlayerImage.Size = new Size(171, 114);
            pb_PlayerImage.TabIndex = 3;
            pb_PlayerImage.TabStop = false;
            // 
            // lbl_Team
            // 
            lbl_Team.AutoSize = true;
            lbl_Team.Location = new Point(12, 258);
            lbl_Team.Name = "lbl_Team";
            lbl_Team.Size = new Size(50, 20);
            lbl_Team.TabIndex = 4;
            lbl_Team.Text = "label2";
            // 
            // pnl_CardBorder
            // 
            pnl_CardBorder.BorderStyle = BorderStyle.FixedSingle;
            pnl_CardBorder.Location = new Point(305, 69);
            pnl_CardBorder.Name = "pnl_CardBorder";
            pnl_CardBorder.Size = new Size(99, 36);
            pnl_CardBorder.TabIndex = 5;
            // 
            // lbl_MatchesPlayed
            // 
            lbl_MatchesPlayed.AutoSize = true;
            lbl_MatchesPlayed.Location = new Point(12, 298);
            lbl_MatchesPlayed.Name = "lbl_MatchesPlayed";
            lbl_MatchesPlayed.Size = new Size(50, 20);
            lbl_MatchesPlayed.TabIndex = 6;
            lbl_MatchesPlayed.Text = "label3";
            // 
            // lbl_Goals
            // 
            lbl_Goals.AutoSize = true;
            lbl_Goals.Location = new Point(12, 338);
            lbl_Goals.Name = "lbl_Goals";
            lbl_Goals.Size = new Size(50, 20);
            lbl_Goals.TabIndex = 7;
            lbl_Goals.Text = "label4";
            // 
            // lbl_Assists
            // 
            lbl_Assists.AutoSize = true;
            lbl_Assists.Location = new Point(12, 378);
            lbl_Assists.Name = "lbl_Assists";
            lbl_Assists.Size = new Size(50, 20);
            lbl_Assists.TabIndex = 8;
            lbl_Assists.Text = "label5";
            // 
            // lbl_Cards
            // 
            lbl_Cards.AutoSize = true;
            lbl_Cards.Location = new Point(12, 421);
            lbl_Cards.Name = "lbl_Cards";
            lbl_Cards.Size = new Size(50, 20);
            lbl_Cards.TabIndex = 9;
            lbl_Cards.Text = "label6";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 450);
            Controls.Add(lbl_Cards);
            Controls.Add(lbl_Assists);
            Controls.Add(lbl_Goals);
            Controls.Add(lbl_MatchesPlayed);
            Controls.Add(pnl_CardBorder);
            Controls.Add(lbl_Team);
            Controls.Add(pb_PlayerImage);
            Controls.Add(lbl_PlayerName);
            Controls.Add(Lst_Cards);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pb_PlayerImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox Lst_Cards;
        private Label lbl_PlayerName;
        private PictureBox pb_PlayerImage;
        private Label lbl_Team;
        private Panel pnl_CardBorder;
        private Label lbl_MatchesPlayed;
        private Label lbl_Goals;
        private Label lbl_Assists;
        private Label lbl_Cards;
    }
}
