using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ADSSE_miniproject_poker_prob
{
    public partial class Form1 : Form
    {
        int check = 0;
        BuildDeck deck = new BuildDeck();
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<BuildDeck.Card> GameDeck = new List<BuildDeck.Card>();
            GameDeck = deck.myDeck();
            int i = 0;
            GameDeck[i].available = false;
            MessageBox.Show(Convert.ToString(GameDeck[i].suit + " " + GameDeck[i].rank + " " + GameDeck[i].available +"\n cards left: "+ deck.HeartsLeft(GameDeck)));
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void HeartsBox1_CheckedChanged(object sender, EventArgs e)
        {
            ClubsBox1.Checked = false;
            SpadesBox1.Checked = false;
            DiamondBox1.Checked = false;
            CardSuit1.Text = HeartsBox1.Text;
        }

        private void ClubsBox1_CheckedChanged(object sender, EventArgs e)
        {
            HeartsBox1.Checked = false;
            SpadesBox1.Checked = false;
            DiamondBox1.Checked = false;
            CardSuit1.Text = ClubsBox1.Text;
        }

        private void DiamondBox1_CheckedChanged(object sender, EventArgs e)
        {
            HeartsBox1.Checked = false;
            SpadesBox1.Checked = false;
            ClubsBox1.Checked = false;
            CardSuit1.Text = DiamondBox1.Text;
        }

        private void SpadesBox1_CheckedChanged(object sender, EventArgs e)
        {
            HeartsBox1.Checked = false;
            ClubsBox1.Checked = false;
            DiamondBox1.Checked = false;
            CardSuit1.Text = SpadesBox1.Text;
        }
        private void HeartsBox2_CheckedChanged(object sender, EventArgs e)
        {
            ClubsBox2.Checked = false;
            SpadesBox2.Checked = false;
            DiamondBox2.Checked = false;
            CardSuit2.Text = HeartsBox2.Text;
        }

        private void ClubsBox2_CheckedChanged(object sender, EventArgs e)
        {
            HeartsBox2.Checked = false;
            SpadesBox2.Checked = false;
            DiamondBox2.Checked = false;
            CardSuit2.Text = ClubsBox2.Text;
        }

        private void DiamondBox2_CheckedChanged(object sender, EventArgs e)
        {
            HeartsBox2.Checked = false;
            SpadesBox2.Checked = false;
            ClubsBox2.Checked = false;
            CardSuit2.Text = DiamondBox2.Text;
        }

        private void SpadesBox2_CheckedChanged(object sender, EventArgs e)
        {
            HeartsBox2.Checked = false;
            ClubsBox2.Checked = false;
            DiamondBox2.Checked = false;
            CardSuit2.Text = SpadesBox2.Text;
        }

        private void ClubsBox3_CheckedChanged(object sender, EventArgs e)
        {
            HeartsBox3.Checked = false;
            SpadesBox3.Checked = false;
            DiamondBox3.Checked = false;
            if(ComCard1.Checked==false)
            cardsuitchoice1.Text = ClubsBox3.Text;
            if (ComCard1.Checked == true && ComCard2.Checked==false)
                cardsuitchoice2.Text = ClubsBox3.Text;
            if (ComCard1.Checked == true && ComCard2.Checked == true && ComCard3.Checked==false)
                cardsuitchoice3.Text = ClubsBox3.Text;
            if (ComCard1.Checked == true && ComCard2.Checked == true && ComCard3.Checked == true && ComCard4.Checked == false)
                cardsuitchoice4.Text = ClubsBox3.Text;
            if (ComCard1.Checked == true && ComCard2.Checked == true && ComCard3.Checked == true && ComCard4.Checked == true)
                cardsuitchoice5.Text = ClubsBox3.Text;
        }

        private void DiamondBox3_CheckedChanged(object sender, EventArgs e)
        {
            HeartsBox3.Checked = false;
            SpadesBox3.Checked = false;
            ClubsBox3.Checked = false;
            if (ComCard1.Checked == false)
                cardsuitchoice1.Text = DiamondBox3.Text;
            if (ComCard1.Checked == true && ComCard2.Checked == false)
                cardsuitchoice2.Text = DiamondBox3.Text;
            if (ComCard1.Checked == true && ComCard2.Checked == true && ComCard3.Checked == false)
                cardsuitchoice3.Text = DiamondBox3.Text;
            if (ComCard1.Checked == true && ComCard2.Checked == true && ComCard3.Checked == true && ComCard4.Checked == false)
                cardsuitchoice4.Text = DiamondBox3.Text;
            if (ComCard1.Checked == true && ComCard2.Checked == true && ComCard3.Checked == true && ComCard4.Checked == true)
                cardsuitchoice5.Text = DiamondBox3.Text;
        }

        private void SpadesBox3_CheckedChanged(object sender, EventArgs e)
        {
            HeartsBox3.Checked = false;
            ClubsBox3.Checked = false;
            DiamondBox3.Checked = false;
            if (ComCard1.Checked == false)
                cardsuitchoice1.Text = SpadesBox3.Text;
            if (ComCard1.Checked == true && ComCard2.Checked == false)
                cardsuitchoice2.Text = SpadesBox3.Text;
            if (ComCard1.Checked == true && ComCard2.Checked == true && ComCard3.Checked == false)
                cardsuitchoice3.Text = SpadesBox3.Text;
            if (ComCard1.Checked == true && ComCard2.Checked == true && ComCard3.Checked == true && ComCard4.Checked == false)
                cardsuitchoice4.Text = SpadesBox3.Text;
            if (ComCard1.Checked == true && ComCard2.Checked == true && ComCard3.Checked == true && ComCard4.Checked == true)
                cardsuitchoice5.Text = SpadesBox3.Text;
        }

        private void HeartsBox3_CheckedChanged(object sender, EventArgs e)
        {
            ClubsBox3.Checked = false;
            SpadesBox3.Checked = false;
            DiamondBox3.Checked = false;
            if (ComCard1.Checked == false)
                cardsuitchoice1.Text = HeartsBox3.Text;
            if (ComCard1.Checked == true && ComCard2.Checked == false)
                cardsuitchoice2.Text = HeartsBox3.Text;
            if (ComCard1.Checked == true && ComCard2.Checked == true && ComCard3.Checked == false)
                cardsuitchoice3.Text = HeartsBox3.Text;
            if (ComCard1.Checked == true && ComCard2.Checked == true && ComCard3.Checked == true && ComCard4.Checked == false)
                cardsuitchoice4.Text = HeartsBox3.Text;
            if (ComCard1.Checked == true && ComCard2.Checked == true && ComCard3.Checked == true && ComCard4.Checked == true)
                cardsuitchoice5.Text = HeartsBox3.Text;
        }
       void setCard()
        {
        }

        private void AceCard_Click(object sender, EventArgs e)
        {
            if (FirstBox.Visible == true)
                CardNumber1.Text = "0";
            if (SecoundBox.Visible == true)
                CardNumber2.Text = "0";
            if (CardNumber1.Text == "0" && CardSuit1.Text == "Spades") 
                    FirstHandCard.Image = Properties.Resources.Spades_A;
                if (CardNumber2.Text == "0" && CardSuit2.Text == "Spades")
                      SecoundHandCard.Image = Properties.Resources.Spades_A;
            if (cardnumberchoice1.Text == "0" && cardsuitchoice1.Text == "Spades")
                FirstPlayCard.Image = Properties.Resources.Spades_A;

                if (CardNumber1.Text == "0" && CardSuit1.Text == "Hearts")
                      FirstHandCard.Image = Properties.Resources.Hearts_A;
                if (CardNumber2.Text == "0" && CardSuit2.Text == "Hearts")
                     SecoundHandCard.Image = Properties.Resources.Hearts_A;
            
            if (CardNumber1.Text == "0" && CardSuit1.Text == "Diamond")
                      FirstHandCard.Image = Properties.Resources.Diamond_A;
                if (CardNumber2.Text == "0" && CardSuit2.Text == "Diamond")
                    SecoundHandCard.Image = Properties.Resources.Diamond_A;
            
            if (CardNumber1.Text == "0" && CardSuit1.Text == "Clubs")
                FirstHandCard.Image = Properties.Resources.Clubs_A;
            if (CardNumber2.Text == "0" && CardSuit2.Text == "Clubs")
                SecoundHandCard.Image = Properties.Resources.Clubs_A;
           


        }

        private void TwoCard_Click(object sender, EventArgs e)
        {
            if (FirstBox.Visible == true)
                CardNumber1.Text = "1";
            if (SecoundBox.Visible == true)
                CardNumber2.Text = "1";
            if (CardNumber1.Text == "1" && CardSuit1.Text == "Spades")
                      FirstHandCard.Image = Properties.Resources.Spades_2;
                if (CardNumber2.Text == "1" && CardSuit2.Text == "Spades")
                    SecoundHandCard.Image = Properties.Resources.Spades_2;
            
            if (CardNumber1.Text == "1" && CardSuit1.Text == "Hearts")
                      FirstHandCard.Image = Properties.Resources.Hearts_2;
                if (CardNumber2.Text == "1" && CardSuit2.Text == "Hearts")
                    SecoundHandCard.Image = Properties.Resources.Hearts_2;
            
            if (CardNumber1.Text == "1" && CardSuit1.Text == "Diamond")
                      FirstHandCard.Image = Properties.Resources.Diamond_2;
                if (CardNumber2.Text == "1" && CardSuit2.Text == "Diamond")
                     SecoundHandCard.Image = Properties.Resources.Diamond_2;
            
            if (CardNumber1.Text == "1" && CardSuit1.Text == "Clubs")
                      FirstHandCard.Image = Properties.Resources.Clubs_2;
                if (CardNumber2.Text == "1" && CardSuit2.Text == "Clubs")
                    SecoundHandCard.Image = Properties.Resources.Clubs_2;
        }

        private void ThirdCard_Click(object sender, EventArgs e)
        {
            if (FirstBox.Visible == true)
                CardNumber1.Text = "2";
            if (SecoundBox.Visible == true)
                CardNumber2.Text = "2";
            if (CardNumber1.Text == "2" && CardSuit1.Text == "Spades")
                      FirstHandCard.Image = Properties.Resources.Spades_3;
                if (CardNumber2.Text == "2" && CardSuit2.Text == "Spades")
                      SecoundHandCard.Image = Properties.Resources.Spades_3;
            
            if (CardNumber1.Text == "2" && CardSuit1.Text == "Hearts")
                       FirstHandCard.Image = Properties.Resources.Hearts_3;
            if (CardNumber2.Text == "2" && CardSuit2.Text == "Hearts")
                SecoundHandCard.Image = Properties.Resources.Hearts_3;
            
            if (CardNumber1.Text == "2" && CardSuit1.Text == "Diamond")
                     FirstHandCard.Image = Properties.Resources.Diamond_3;
                if (CardNumber2.Text == "2" && CardSuit2.Text == "Diamond")
                    SecoundHandCard.Image = Properties.Resources.Diamond_3;
            
            if (CardNumber1.Text == "2" && CardSuit1.Text == "Clubs")
                    FirstHandCard.Image = Properties.Resources.Clubs_3;
                if (CardNumber2.Text == "2" && CardSuit2.Text == "Clubs")
                    SecoundHandCard.Image = Properties.Resources.Clubs_3;
            
        }

        private void FouthCard_Click(object sender, EventArgs e)
        {
            if (FirstBox.Visible == true)
                CardNumber1.Text = "3";
            if (SecoundBox.Visible == true)
                CardNumber2.Text = "3";
            if (CardNumber1.Text == "3" && CardSuit1.Text == "Spades")
            
                    FirstHandCard.Image = Properties.Resources.Spades_4;
            if (CardNumber2.Text == "3" && CardSuit2.Text == "Spades")

                SecoundHandCard.Image = Properties.Resources.Spades_4;
            
            if (CardNumber1.Text == "3" && CardSuit1.Text == "Hearts")
                                FirstHandCard.Image = Properties.Resources.Hearts_4;
                if (CardNumber2.Text == "3" && CardSuit2.Text == "Hearts")
                                    SecoundHandCard.Image = Properties.Resources.Hearts_4;
            
            if (CardNumber1.Text == "3" && CardSuit1.Text == "Diamond")
            
                    FirstHandCard.Image = Properties.Resources.Diamond_4;
            if (CardNumber2.Text == "3" && CardSuit2.Text == "Diamond")

                SecoundHandCard.Image = Properties.Resources.Diamond_4;
            
            if (CardNumber1.Text == "3" && CardSuit1.Text == "Clubs")
                      FirstHandCard.Image = Properties.Resources.Clubs_4;
                if (CardNumber2.Text == "3" && CardSuit2.Text == "Clubs")
                    SecoundHandCard.Image = Properties.Resources.Clubs_4;
            
        }

        private void FifthCard_Click(object sender, EventArgs e)
        {
            if (FirstBox.Visible == true)
                CardNumber1.Text = "4";
            if (SecoundBox.Visible == true)
                CardNumber2.Text = "4";
            if (CardNumber1.Text == "4" && CardSuit1.Text == "Spades")
                            FirstHandCard.Image = Properties.Resources.Spades_5;
            if (CardNumber2.Text == "4" && CardSuit2.Text == "Spades")

                SecoundHandCard.Image = Properties.Resources.Spades_5;
            
            if (CardNumber1.Text == "4" && CardSuit1.Text == "Hearts")
            
                    FirstHandCard.Image = Properties.Resources.Hearts_5;
            if (CardNumber2.Text == "4" && CardSuit2.Text == "Hearts")
                SecoundHandCard.Image = Properties.Resources.Hearts_5;
            
            if (CardNumber1.Text == "4" && CardSuit1.Text == "Diamond")
            
                    FirstHandCard.Image = Properties.Resources.Diamond_5;
            if (CardNumber2.Text == "4" && CardSuit2.Text == "Diamond")
                SecoundHandCard.Image = Properties.Resources.Diamond_5;
            
            if (CardNumber1.Text == "4" && CardSuit1.Text == "Clubs")
                    FirstHandCard.Image = Properties.Resources.Clubs_5;
            if (CardNumber2.Text == "4" && CardSuit2.Text == "Clubs")
                SecoundHandCard.Image = Properties.Resources.Clubs_5;
            
        }

        private void SixthCard_Click(object sender, EventArgs e)
        {
            if (FirstBox.Visible == true)
                CardNumber1.Text = "5";
            if (SecoundBox.Visible == true)
                CardNumber2.Text = "5";
            if (CardNumber1.Text == "5" && CardSuit1.Text == "Spades")
                FirstHandCard.Image = Properties.Resources.Spades_6;
            if (CardNumber2.Text == "5" && CardSuit2.Text == "Spades")
                SecoundHandCard.Image = Properties.Resources.Spades_6;
            
            if (CardNumber1.Text == "5" && CardSuit1.Text == "Hearts")
                                FirstHandCard.Image = Properties.Resources.Hearts_6;
            if (CardNumber2.Text == "5" && CardSuit2.Text == "Hearts")

                SecoundHandCard.Image = Properties.Resources.Hearts_6;
            
            if (CardNumber1.Text == "5" && CardSuit1.Text == "Diamond")
            
                    FirstHandCard.Image = Properties.Resources.Diamond_6;
            if (CardNumber2.Text == "5" && CardSuit2.Text == "Diamond")
                SecoundHandCard.Image = Properties.Resources.Diamond_6;
            
            if (CardNumber1.Text == "5" && CardSuit1.Text == "Clubs")
            
                    FirstHandCard.Image = Properties.Resources.Clubs_6;
            if (CardNumber2.Text == "5" && CardSuit2.Text == "Clubs")

                SecoundHandCard.Image = Properties.Resources.Clubs_6;
            
        }

        private void SeventhCard_Click(object sender, EventArgs e)
        {
            if (FirstBox.Visible == true)
                CardNumber1.Text = "6";
            if (SecoundBox.Visible == true)
                CardNumber2.Text = "6";
            if (CardNumber1.Text == "6" && CardSuit1.Text == "Spades")
                                FirstHandCard.Image = Properties.Resources.Spades_7;
            if (CardNumber2.Text == "6" && CardSuit2.Text == "Spades")

                SecoundHandCard.Image = Properties.Resources.Spades_7;
            
            if (CardNumber1.Text == "6" && CardSuit1.Text == "Hearts")
            
                    FirstHandCard.Image = Properties.Resources.Hearts_7;
            if (CardNumber2.Text == "6" && CardSuit2.Text == "Hearts")
                SecoundHandCard.Image = Properties.Resources.Hearts_7;
            
            if (CardNumber1.Text == "6" && CardSuit1.Text == "Diamond")
                     FirstHandCard.Image = Properties.Resources.Diamond_7;
            if (CardNumber2.Text == "6" && CardSuit2.Text == "Diamond")
                    SecoundHandCard.Image = Properties.Resources.Diamond_7;
            
            if (CardNumber1.Text == "6" && CardSuit1.Text == "Clubs")
                              FirstHandCard.Image = Properties.Resources.Clubs_7;
            if (CardNumber2.Text == "6" && CardSuit2.Text == "Clubs")
                SecoundHandCard.Image = Properties.Resources.Clubs_7;
            
        }

        private void EigthCard_Click(object sender, EventArgs e)
        {
            if (FirstBox.Visible == true)
                CardNumber1.Text = "7";
            if (SecoundBox.Visible == true)
                CardNumber2.Text = "7";
            if (CardNumber1.Text == "7" && CardSuit1.Text == "Spades")
                             FirstHandCard.Image = Properties.Resources.Spades_8;
            if (CardNumber2.Text == "7" && CardSuit2.Text == "Spades")
                SecoundHandCard.Image = Properties.Resources.Spades_8;
            
            if (CardNumber1.Text == "7" && CardSuit1.Text == "Hearts")
                          FirstHandCard.Image = Properties.Resources.Hearts_8;
            if (CardNumber2.Text == "7" && CardSuit2.Text == "Hearts")
                SecoundHandCard.Image = Properties.Resources.Hearts_8;
            
            if (CardNumber1.Text == "7" && CardSuit1.Text == "Diamond")
                FirstHandCard.Image = Properties.Resources.Diamond_8;
            if (CardNumber2.Text == "7" && CardSuit2.Text == "Diamond")
                SecoundHandCard.Image = Properties.Resources.Diamond_8;
            
            if (CardNumber1.Text == "7" && CardSuit1.Text == "Clubs")
                FirstHandCard.Image = Properties.Resources.Clubs_8;
            if (CardNumber2.Text == "7" && CardSuit2.Text == "Clubs")
                SecoundHandCard.Image = Properties.Resources.Clubs_8;
            
        }

        private void NinthCard_Click(object sender, EventArgs e)
        {
            if (FirstBox.Visible == true)
                CardNumber1.Text = "8";
            if (SecoundBox.Visible == true)
                CardNumber2.Text = "8";

            if (CardNumber1.Text == "8" && CardSuit1.Text == "Spades")
                    FirstHandCard.Image = Properties.Resources.Spades_9;
            if (CardNumber2.Text == "8" && CardSuit2.Text == "Spades")
                SecoundHandCard.Image = Properties.Resources.Spades_9;
            
            if (CardNumber1.Text == "8" && CardSuit1.Text == "Hearts")
                    FirstHandCard.Image = Properties.Resources.Hearts_9;
            if (CardNumber2.Text == "8" && CardSuit2.Text == "Hearts")
                SecoundHandCard.Image = Properties.Resources.Hearts_9;
            
            if (CardNumber1.Text == "8" && CardSuit1.Text == "Diamond")
                    FirstHandCard.Image = Properties.Resources.Diamond_9;
                if (CardNumber2.Text == "8" && CardSuit2.Text == "Diamond")
                    SecoundHandCard.Image = Properties.Resources.Diamond_9;
            
            if (CardNumber1.Text == "8" && CardSuit1.Text == "Clubs")
                               FirstHandCard.Image = Properties.Resources.Clubs_9;
                if (CardNumber2.Text == "8" && CardSuit2.Text == "Clubs")
                    SecoundHandCard.Image = Properties.Resources.Clubs_9;
            
        }

        private void TenthCard_Click(object sender, EventArgs e)
        {
            if (FirstBox.Visible == true)
                CardNumber1.Text = "9";
            if (SecoundBox.Visible == true)
                CardNumber2.Text = "9";
            if (CardNumber1.Text == "9" && CardSuit1.Text == "Spades")
                    FirstHandCard.Image = Properties.Resources.Spades_10;
                if (CardNumber2.Text == "9" && CardSuit2.Text == "Spades")
                    SecoundHandCard.Image = Properties.Resources.Spades_10;
           
            if (CardNumber1.Text == "9" && CardSuit1.Text == "Hearts")
                     FirstHandCard.Image = Properties.Resources.Hearts_10;
                if (CardNumber2.Text == "9" && CardSuit2.Text == "Hearts")
                    SecoundHandCard.Image = Properties.Resources.Hearts_10;
            
            if (CardNumber1.Text == "9" && CardSuit1.Text == "Diamond")
                FirstHandCard.Image = Properties.Resources.Diamond_10;
                if (CardNumber2.Text == "9" && CardSuit2.Text == "Diamond")
                    SecoundHandCard.Image = Properties.Resources.Diamond_10;
            
            if (CardNumber1.Text == "9" && CardSuit1.Text == "Clubs")
                      FirstHandCard.Image = Properties.Resources.Clubs_10;
                if (CardNumber2.Text == "9" && CardSuit2.Text == "Clubs")
                    SecoundHandCard.Image = Properties.Resources.Clubs_10;

        
        }

        private void JackCard_Click(object sender, EventArgs e)
        {
            if (FirstBox.Visible == true)
                CardNumber1.Text = "10";
            if (SecoundBox.Visible == true)
                CardNumber2.Text = "10";
            if (CardNumber1.Text == "10" && CardSuit1.Text == "Spades")
                             FirstHandCard.Image = Properties.Resources.Spades_J;
                if (CardNumber2.Text == "10" && CardSuit2.Text == "Spades")

                    SecoundHandCard.Image = Properties.Resources.Spades_J;
            
            if (CardNumber1.Text == "10" && CardSuit1.Text == "Hearts")
            
                    FirstHandCard.Image = Properties.Resources.Hearts_J;
                if (CardNumber2.Text == "10" && CardSuit2.Text == "Hearts")

                    SecoundHandCard.Image = Properties.Resources.Hearts_J;
            
            if (CardNumber1.Text == "10" && CardSuit1.Text == "Diamond")
                    FirstHandCard.Image = Properties.Resources.Diamond_J;
            if (CardNumber2.Text == "10" && CardSuit2.Text == "Diamond")
                    SecoundHandCard.Image = Properties.Resources.Diamond_J;
           if (CardNumber1.Text == "10" && CardSuit1.Text == "Clubs")
                    FirstHandCard.Image = Properties.Resources.Clubs_J;
            if (CardNumber2.Text == "10" && CardSuit2.Text == "Clubs")

                    SecoundHandCard.Image = Properties.Resources.Clubs_J;
            
        }

        private void QueenCard_Click(object sender, EventArgs e)
        {
            if(FirstBox.Visible==true)
                               CardNumber1.Text = "11";
            if (SecoundBox.Visible == true)
                CardNumber2.Text = "11";
            if (CardNumber1.Text == "11" && CardSuit1.Text == "Spades")
                FirstHandCard.Image = Properties.Resources.Spades_Q;
            
            if (CardNumber2.Text == "11" && CardSuit2.Text == "Spades") 
                SecoundHandCard.Image = Properties.Resources.Spades_Q;
            
            if (CardNumber1.Text == "11" && CardSuit1.Text == "Hearts")
                    FirstHandCard.Image = Properties.Resources.Hearts_Q;
                if (CardNumber2.Text == "11" && CardSuit2.Text == "Hearts")
                    SecoundHandCard.Image = Properties.Resources.Hearts_Q;
            
            if (CardNumber1.Text == "11" && CardSuit1.Text == "Diamond")           
                    FirstHandCard.Image = Properties.Resources.Diamond_Q;
            if (CardNumber2.Text == "11" && CardSuit2.Text == "Diamond")
                SecoundHandCard.Image = Properties.Resources.Diamond_Q;

            if (CardNumber1.Text == "11" && CardSuit1.Text == "Clubs")
                    FirstHandCard.Image = Properties.Resources.Clubs_Q;
                if (CardNumber2.Text == "11" && CardSuit2.Text == "Clubs")
                    SecoundHandCard.Image = Properties.Resources.Clubs_Q;
        }

        private void KingCard_Click(object sender, EventArgs e)
        {
            if (FirstBox.Visible == true)
                CardNumber1.Text = "12";
            if (SecoundBox.Visible == true)
                CardNumber2.Text = "12";
            if (CommunityBox.Visible == true && ComCard1.Checked == false)
                cardnumberchoice1.Text = "12";
            if (CommunityBox.Visible == true && ComCard1.Checked == true && ComCard2.Checked==false)
                cardnumberchoice2.Text = "12";
            if (CommunityBox.Visible == true && ComCard1.Checked == true && ComCard2.Checked == true && ComCard3.Checked==false)
                cardnumberchoice3.Text = "12";
            if (CommunityBox.Visible == true && ComCard1.Checked == true && ComCard2.Checked == true && ComCard3.Checked == true && ComCard4.Checked==false)
                cardnumberchoice4.Text = "12";
            if (CommunityBox.Visible == true && ComCard1.Checked == true && ComCard2.Checked == true && ComCard3.Checked == true && ComCard4.Checked == true)
                cardnumberchoice5.Text = "12";


            if (CardNumber1.Text == "12" && CardSuit1.Text == "Spades")
                FirstHandCard.Image = Properties.Resources.Spades_K;
            if (CardNumber2.Text == "12" && CardSuit2.Text == "Spades")
                SecoundHandCard.Image = Properties.Resources.Spades_K;

            
            if (CardNumber1.Text == "12" && CardSuit1.Text == "Hearts")
            
                    FirstHandCard.Image = Properties.Resources.Hearts_K;
                if (CardNumber2.Text == "12" && CardSuit2.Text == "Hearts")
                    SecoundHandCard.Image = Properties.Resources.Hearts_K;

            if (CardNumber1.Text == "12" && CardSuit1.Text == "Diamond")

                    FirstHandCard.Image = Properties.Resources.Diamond_K;
            if (CardNumber2.Text == "12" && CardSuit2.Text == "Diamond")
                SecoundHandCard.Image = Properties.Resources.Diamond_K;
           
            if (CardNumber1.Text == "12" && CardSuit1.Text == "Clubs")
                FirstHandCard.Image = Properties.Resources.Clubs_K;
                if (CardNumber2.Text == "12" && CardSuit2.Text == "Clubs")
                    SecoundHandCard.Image = Properties.Resources.Clubs_K;
            if (cardnumberchoice1.Text == "12" && cardsuitchoice1.Text == "Clubs")
                FirstPlayCard.Image = Properties.Resources.Clubs_K;
            if (cardnumberchoice2.Text == "12" && cardsuitchoice2.Text == "Clubs")
                FirstPlayCard.Image = Properties.Resources.Clubs_K;
            if (cardnumberchoice3.Text == "12" && cardsuitchoice3.Text == "Clubs")
                FirstPlayCard.Image = Properties.Resources.Clubs_K;
            if (cardnumberchoice4.Text == "12" && cardsuitchoice4.Text == "Clubs")
                FirstPlayCard.Image = Properties.Resources.Clubs_K;
            if (cardnumberchoice5.Text == "12" && cardsuitchoice5.Text == "Clubs")
                FirstPlayCard.Image = Properties.Resources.Clubs_K;



        }

        private void button2_Click(object sender, EventArgs e)
        {
            check++;
            label1.Text = Convert.ToString(check);
            if (check == 1)
            {
                if (FirstBox.Visible == true && CardSuit1.Text == "label1" || CardNumber1.Text == "label3")
                    check--;
                else
                {
                    FirstBox.Visible = false;
                    SecoundBox.Visible = true;
                }

            }
            
            if (check == 2)
            {
                if (SecoundBox.Visible == true && CardSuit2.Text == "label4" || CardNumber2.Text=="label5")
                    check--;
                else
                {
                    SecoundBox.Visible = false;
                    CommunityBox.Visible = true;
                }

            }

            if (check == 3)
            {
                if (CommunityBox.Visible == true && cardsuitchoice1.Text == "label1" || cardnumberchoice1.Text == "label3" )
                    check--;
                else {
                    ComCard1.Checked = true;
                    cardnumberchoice1.Text = cardnumberchoice1.Text;
                    cardsuitchoice1.Text = cardsuitchoice1.Text;
                }

            }

            if (check == 4)
            {
                if (ComCard1.Checked == true && cardsuitchoice2.Text == "label1" || cardnumberchoice2.Text == "label3")
                    check--;
                else
                {
                    ComCard2.Checked = true;
                    cardnumberchoice2.Text = cardnumberchoice2.Text;
                    cardsuitchoice2.Text = cardsuitchoice2.Text;
                }
            }
            if (check == 5)
            {
                if (ComCard2.Checked == true && cardsuitchoice3.Text == "label1" || cardnumberchoice3.Text == "label3")
                    check--;
                else
                {
                    ComCard3.Checked = true;
                    cardnumberchoice3.Text = cardnumberchoice3.Text;
                    cardsuitchoice3.Text = cardsuitchoice3.Text;
                }
            }
            if (check == 6 )
            {
                if (ComCard3.Checked == true && cardsuitchoice4.Text == "label1" || cardnumberchoice4.Text == "label3")
                    check--;
                else
                {
                    ComCard4.Checked = true;
                    cardnumberchoice4.Text = cardnumberchoice4.Text;
                    cardsuitchoice4.Text = cardsuitchoice4.Text;
                }
            }

            if (check == 7)
            {
                if (ComCard4.Checked == true && cardsuitchoice5.Text == "label1" || cardnumberchoice5.Text == "label3")
                    check--;
                else
                {
                    ComCard5.Checked = true;
                    cardnumberchoice5.Text = cardnumberchoice5.Text;
                    cardsuitchoice5.Text = cardsuitchoice5.Text;
                    ConfirmButton.Visible = false;

                }
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            if (SecoundBox.Visible == true || SecoundBox.Visible == false && CommunityBox.Visible == true)
            {
                FirstBox.Visible = true;
                SecoundBox.Visible = false;
                CommunityBox.Visible = false;
                check = 0;
                ConfirmButton.Visible = true;
                ComCard1.Checked = false;
                ComCard2.Checked = false;
                ComCard3.Checked = false;
                ComCard4.Checked = false;
                ComCard5.Checked = false;

            }
        }
    }
}
