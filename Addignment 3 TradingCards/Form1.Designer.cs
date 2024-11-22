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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btn_AddCard = new Button();
            btn_RemoveCard = new Button();
            btn_Filter = new Button();
            btn_ShowAll = new Button();
            ((System.ComponentModel.ISupportInitialize)pb_PlayerImage).BeginInit();
            SuspendLayout();
            // 
            // Lst_Cards
            // 
            Lst_Cards.FormattingEnabled = true;
            Lst_Cards.Location = new Point(225, 170);
            Lst_Cards.Name = "Lst_Cards";
            Lst_Cards.Size = new Size(252, 124);
            Lst_Cards.TabIndex = 0;
            Lst_Cards.SelectedIndexChanged += Lst_Cards_SelectedIndexChanged;
            // 
            // lbl_PlayerName
            // 
            lbl_PlayerName.AutoSize = true;
            lbl_PlayerName.Location = new Point(25, 217);
            lbl_PlayerName.Name = "lbl_PlayerName";
            lbl_PlayerName.Size = new Size(50, 20);
            lbl_PlayerName.TabIndex = 2;
            lbl_PlayerName.Text = "label1";
            // 
            // pb_PlayerImage
            // 
            pb_PlayerImage.Location = new Point(12, 12);
            pb_PlayerImage.Name = "pb_PlayerImage";
            pb_PlayerImage.Size = new Size(207, 202);
            pb_PlayerImage.TabIndex = 3;
            pb_PlayerImage.TabStop = false;
            // 
            // lbl_Team
            // 
            lbl_Team.AutoSize = true;
            lbl_Team.Location = new Point(252, 17);
            lbl_Team.Name = "lbl_Team";
            lbl_Team.Size = new Size(50, 20);
            lbl_Team.TabIndex = 4;
            lbl_Team.Text = "label2";
            // 
            // pnl_CardBorder
            // 
            pnl_CardBorder.BorderStyle = BorderStyle.FixedSingle;
            pnl_CardBorder.Location = new Point(225, 40);
            pnl_CardBorder.Name = "pnl_CardBorder";
            pnl_CardBorder.Size = new Size(252, 59);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(225, 136);
            label1.Name = "label1";
            label1.Size = new Size(237, 20);
            label1.TabIndex = 10;
            label1.Text = "Choose a Card from the List Below";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 254);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 11;
            label2.Text = "Stats:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(381, 17);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 12;
            label3.Text = "Team Colour:";
            // 
            // btn_AddCard
            // 
            btn_AddCard.Location = new Point(225, 300);
            btn_AddCard.Name = "btn_AddCard";
            btn_AddCard.Size = new Size(94, 29);
            btn_AddCard.TabIndex = 13;
            btn_AddCard.Text = "Add Player";
            btn_AddCard.UseVisualStyleBackColor = true;
            btn_AddCard.Click += btn_AddCard_Click;
            // 
            // btn_RemoveCard
            // 
            btn_RemoveCard.Location = new Point(368, 300);
            btn_RemoveCard.Name = "btn_RemoveCard";
            btn_RemoveCard.Size = new Size(94, 29);
            btn_RemoveCard.TabIndex = 14;
            btn_RemoveCard.Text = "Remove Player";
            btn_RemoveCard.UseVisualStyleBackColor = true;
            btn_RemoveCard.Click += btn_RemoveCard_Click;
            // 
            // btn_Filter
            // 
            btn_Filter.Location = new Point(225, 338);
            btn_Filter.Name = "btn_Filter";
            btn_Filter.Size = new Size(94, 29);
            btn_Filter.TabIndex = 15;
            btn_Filter.Text = "Filter";
            btn_Filter.UseVisualStyleBackColor = true;
            btn_Filter.Click += btn_Filter_Click;
            // 
            // btn_ShowAll
            // 
            btn_ShowAll.Location = new Point(368, 338);
            btn_ShowAll.Name = "btn_ShowAll";
            btn_ShowAll.Size = new Size(94, 29);
            btn_ShowAll.TabIndex = 16;
            btn_ShowAll.Text = "Show All";
            btn_ShowAll.UseVisualStyleBackColor = true;
            btn_ShowAll.Click += btn_ShowAll_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 450);
            Controls.Add(btn_ShowAll);
            Controls.Add(btn_Filter);
            Controls.Add(btn_RemoveCard);
            Controls.Add(btn_AddCard);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btn_AddCard;
        private Button btn_RemoveCard;
        private Button btn_Filter;
        private Button btn_ShowAll;
    }
}
