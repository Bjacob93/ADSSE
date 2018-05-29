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
        //variables to add the correct card to the hand and make it unavailable in the deck.
        int suit;
        int rank;

        List<BuildDeck.Card> GameDeck = new List<BuildDeck.Card>();
        BuildDeck deck = new BuildDeck();
        List<BuildDeck.Card> currentHand = new List<BuildDeck.Card>();

        int check = 0;

        HandProbabilities probabilityCalculater = new HandProbabilities();

        public void Form1_Load(object sender, EventArgs e)
        {
            GameDeck = deck.myDeck();
        }


        public Form1()
        {
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString("size of hand: " + currentHand.Count + 
                                             "\n cardslet: " + deck.CardsLeft(GameDeck) + 
                                             "\n " + probabilityCalculater.ProbabilityOfThreeOfaKind(currentHand, GameDeck)));
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
            CardSuit1.Text = HeartsBox2.Text;
        }

        private void ClubsBox2_CheckedChanged(object sender, EventArgs e)
        {
            HeartsBox2.Checked = false;
            SpadesBox2.Checked = false;
            DiamondBox2.Checked = false;
            CardSuit1.Text = ClubsBox2.Text;
        }

        private void DiamondBox2_CheckedChanged(object sender, EventArgs e)
        {
            HeartsBox2.Checked = false;
            SpadesBox2.Checked = false;
            ClubsBox2.Checked = false;
            CardSuit1.Text = DiamondBox2.Text;
        }

        private void SpadesBox2_CheckedChanged(object sender, EventArgs e)
        {
            HeartsBox2.Checked = false;
            ClubsBox2.Checked = false;
            DiamondBox2.Checked = false;
            CardSuit1.Text = SpadesBox2.Text;
        }

        private void ClubsBox3_CheckedChanged(object sender, EventArgs e)
        {
            HeartsBox3.Checked = false;
            SpadesBox3.Checked = false;
            DiamondBox3.Checked = false;
            CardSuit1.Text = ClubsBox3.Text;

        }

        private void DiamondBox3_CheckedChanged(object sender, EventArgs e)
        {
            HeartsBox3.Checked = false;
            SpadesBox3.Checked = false;
            ClubsBox3.Checked = false;
            CardSuit1.Text = DiamondBox3.Text;

        }

        private void SpadesBox3_CheckedChanged(object sender, EventArgs e)
        {
            HeartsBox3.Checked = false;
            ClubsBox3.Checked = false;
            DiamondBox3.Checked = false;
            CardSuit1.Text = SpadesBox3.Text;

        }

        private void HeartsBox3_CheckedChanged(object sender, EventArgs e)
        {
            ClubsBox3.Checked = false;
            SpadesBox3.Checked = false;
            DiamondBox3.Checked = false;
            CardSuit1.Text = HeartsBox3.Text;

        }
       void setCard()
        {
        }

        private void AceCard_Click(object sender, EventArgs e)
        {
                CardNumber1.Text = "0";
            if (Cardchoice1.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        FirstHandCard.Image = Properties.Resources.Hearts_A;
                        break;
                    case "Spades":
                        FirstHandCard.Image = Properties.Resources.Spades_A;
                        break;
                    case "Diamonds":
                        FirstHandCard.Image = Properties.Resources.Diamond_A;
                        break;
                    case "Clubs":
                        FirstHandCard.Image = Properties.Resources.Clubs_A;
                        return;
                    default:
                        break;
                }
            }
            if (Cardchoice1.Checked == true && Cardchoice2.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        SecondHandCard.Image = Properties.Resources.Hearts_A;
                        break;
                    case "Spades":
                        SecondHandCard.Image = Properties.Resources.Spades_A;
                        break;
                    case "Diamonds":
                        SecondHandCard.Image = Properties.Resources.Diamond_A;
                        break;
                    case "Clubs":
                        SecondHandCard.Image = Properties.Resources.Clubs_A;
                        return;
                    default:
                        break;
                }
            }
            if (Cardchoice2.Checked == true && ComCard1.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        FirstPlayCard.Image = Properties.Resources.Hearts_A;
                        break;
                    case "Spades":
                        FirstPlayCard.Image = Properties.Resources.Spades_A;
                        break;
                    case "Diamonds":
                        FirstPlayCard.Image = Properties.Resources.Diamond_A;
                        break;
                    case "Clubs":
                        FirstPlayCard.Image = Properties.Resources.Clubs_A;
                        return;
                    default:
                        break;
                }
            }
            if (ComCard1.Checked == true && ComCard2.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        SecondPlayCard.Image = Properties.Resources.Hearts_A;
                        break;
                    case "Spades":
                        SecondPlayCard.Image = Properties.Resources.Spades_A;
                        break;
                    case "Diamonds":
                        SecondPlayCard.Image = Properties.Resources.Diamond_A;
                        break;
                    case "Clubs":
                        SecondPlayCard.Image = Properties.Resources.Clubs_A;
                        return;
                    default:
                        break;
                }
            }
            if (ComCard2.Checked == true && ComCard3.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        ThirdPlayCard.Image = Properties.Resources.Hearts_A;
                        break;
                    case "Spades":
                        ThirdPlayCard.Image = Properties.Resources.Spades_A;
                        break;
                    case "Diamonds":
                        ThirdPlayCard.Image = Properties.Resources.Diamond_A;
                        break;
                    case "Clubs":
                        ThirdPlayCard.Image = Properties.Resources.Clubs_A;
                        return;
                    default:
                        break;
                }
            }
            if (ComCard3.Checked == true && ComCard4.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        FourthPlayCard.Image = Properties.Resources.Hearts_A;
                        break;
                    case "Spades":
                        FourthPlayCard.Image = Properties.Resources.Spades_A;
                        break;
                    case "Diamonds":
                        FourthPlayCard.Image = Properties.Resources.Diamond_A;
                        break;
                    case "Clubs":
                        FourthPlayCard.Image = Properties.Resources.Clubs_A;
                        return;
                    default:
                        break;
                }
            }
            if (ComCard4.Checked == true && ComCard5.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        FifthPlayCard.Image = Properties.Resources.Hearts_A;
                        break;
                    case "Spades":
                        FifthPlayCard.Image = Properties.Resources.Spades_A;
                        break;
                    case "Diamonds":
                        FifthPlayCard.Image = Properties.Resources.Diamond_A;
                        break;
                    case "Clubs":
                        FifthPlayCard.Image = Properties.Resources.Clubs_A;
                        return;
                    default:
                        break;
                }
            }
        }

        private void TwoCard_Click(object sender, EventArgs e)
        {
                CardNumber1.Text = "1";
            if (Cardchoice1.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        FirstHandCard.Image = Properties.Resources.Hearts_2;
                        break;
                    case "Spades":
                        FirstHandCard.Image = Properties.Resources.Spades_2;
                        break;
                    case "Diamonds":
                        FirstHandCard.Image = Properties.Resources.Diamond_2;
                        break;
                    case "Clubs":
                        FirstHandCard.Image = Properties.Resources.Clubs_2;
                        return;
                    default:
                        break;
                }
            }
            if (Cardchoice1.Checked == true && Cardchoice2.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        SecondHandCard.Image = Properties.Resources.Hearts_2;
                        break;
                    case "Spades":
                        SecondHandCard.Image = Properties.Resources.Spades_2;
                        break;
                    case "Diamonds":
                        SecondHandCard.Image = Properties.Resources.Diamond_2;
                        break;
                    case "Clubs":
                        SecondHandCard.Image = Properties.Resources.Clubs_2;
                        return;
                    default:
                        break;
                }
            }
            if (Cardchoice2.Checked == true && ComCard1.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        FirstPlayCard.Image = Properties.Resources.Hearts_2;
                        break;
                    case "Spades":
                        FirstPlayCard.Image = Properties.Resources.Spades_2;
                        break;
                    case "Diamonds":
                        FirstPlayCard.Image = Properties.Resources.Diamond_2;
                        break;
                    case "Clubs":
                        FirstPlayCard.Image = Properties.Resources.Clubs_2;
                        return;
                    default:
                        break;
                }
            }
            if (ComCard1.Checked == true && ComCard2.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        SecondPlayCard.Image = Properties.Resources.Hearts_2;
                        break;
                    case "Spades":
                        SecondPlayCard.Image = Properties.Resources.Spades_2;
                        break;
                    case "Diamonds":
                        SecondPlayCard.Image = Properties.Resources.Diamond_2;
                        break;
                    case "Clubs":
                        SecondPlayCard.Image = Properties.Resources.Clubs_2;
                        return;
                    default:
                        break;
                }
            }
            if (ComCard2.Checked == true && ComCard3.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        ThirdPlayCard.Image = Properties.Resources.Hearts_2;
                        break;
                    case "Spades":
                        ThirdPlayCard.Image = Properties.Resources.Spades_2;
                        break;
                    case "Diamonds":
                        ThirdPlayCard.Image = Properties.Resources.Diamond_2;
                        break;
                    case "Clubs":
                        ThirdPlayCard.Image = Properties.Resources.Clubs_2;
                        return;
                    default:
                        break;
                }
            }
            if (ComCard3.Checked == true && ComCard4.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        FourthPlayCard.Image = Properties.Resources.Hearts_2;
                        break;
                    case "Spades":
                        FourthPlayCard.Image = Properties.Resources.Spades_2;
                        break;
                    case "Diamonds":
                        FourthPlayCard.Image = Properties.Resources.Diamond_2;
                        break;
                    case "Clubs":
                        FourthPlayCard.Image = Properties.Resources.Clubs_2;
                        return;
                    default:
                        break;
                }
            }
            if (ComCard4.Checked == true && ComCard5.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        FifthPlayCard.Image = Properties.Resources.Hearts_2;
                        break;
                    case "Spades":
                        FifthPlayCard.Image = Properties.Resources.Spades_2;
                        break;
                    case "Diamonds":
                        FifthPlayCard.Image = Properties.Resources.Diamond_2;
                        break;
                    case "Clubs":
                        FifthPlayCard.Image = Properties.Resources.Clubs_2;
                        return;
                    default:
                        break;
                }
            }
        }

        private void ThirdCard_Click(object sender, EventArgs e)
        {
                CardNumber1.Text = "2";
            if (Cardchoice1.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        FirstHandCard.Image = Properties.Resources.Hearts_3;
                        break;
                    case "Spades":
                        FirstHandCard.Image = Properties.Resources.Spades_3;
                        break;
                    case "Diamonds":
                        FirstHandCard.Image = Properties.Resources.Diamond_3;
                        break;
                    case "Clubs":
                        FirstHandCard.Image = Properties.Resources.Clubs_3;
                        return;
                    default:
                        break;
                }
            }
            if (Cardchoice1.Checked == true && Cardchoice2.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        SecondHandCard.Image = Properties.Resources.Hearts_3;
                        break;
                    case "Spades":
                        SecondHandCard.Image = Properties.Resources.Spades_3;
                        break;
                    case "Diamonds":
                        SecondHandCard.Image = Properties.Resources.Diamond_3;
                        break;
                    case "Clubs":
                        SecondHandCard.Image = Properties.Resources.Clubs_3;
                        return;
                    default:
                        break;
                }
            }
            if (Cardchoice2.Checked == true && ComCard1.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        FirstPlayCard.Image = Properties.Resources.Hearts_3;
                        break;
                    case "Spades":
                        FirstPlayCard.Image = Properties.Resources.Spades_3;
                        break;
                    case "Diamonds":
                        FirstPlayCard.Image = Properties.Resources.Diamond_3;
                        break;
                    case "Clubs":
                        FirstPlayCard.Image = Properties.Resources.Clubs_3;
                        return;
                    default:
                        break;
                }
            }
            if (ComCard1.Checked == true && ComCard2.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        SecondPlayCard.Image = Properties.Resources.Hearts_3;
                        break;
                    case "Spades":
                        SecondPlayCard.Image = Properties.Resources.Spades_3;
                        break;
                    case "Diamonds":
                        SecondPlayCard.Image = Properties.Resources.Diamond_3;
                        break;
                    case "Clubs":
                        SecondPlayCard.Image = Properties.Resources.Clubs_3;
                        return;
                    default:
                        break;
                }
            }
            if (ComCard2.Checked == true && ComCard3.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        ThirdPlayCard.Image = Properties.Resources.Hearts_3;
                        break;
                    case "Spades":
                        ThirdPlayCard.Image = Properties.Resources.Spades_3;
                        break;
                    case "Diamonds":
                        ThirdPlayCard.Image = Properties.Resources.Diamond_3;
                        break;
                    case "Clubs":
                        ThirdPlayCard.Image = Properties.Resources.Clubs_3;
                        return;
                    default:
                        break;
                }
            }
            if (ComCard3.Checked == true && ComCard4.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        FourthPlayCard.Image = Properties.Resources.Hearts_3;
                        break;
                    case "Spades":
                        FourthPlayCard.Image = Properties.Resources.Spades_3;
                        break;
                    case "Diamonds":
                        FourthPlayCard.Image = Properties.Resources.Diamond_3;
                        break;
                    case "Clubs":
                        FourthPlayCard.Image = Properties.Resources.Clubs_3;
                        return;
                    default:
                        break;
                }
            }
            if (ComCard4.Checked == true && ComCard5.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        FifthPlayCard.Image = Properties.Resources.Hearts_3;
                        break;
                    case "Spades":
                        FifthPlayCard.Image = Properties.Resources.Spades_3;
                        break;
                    case "Diamonds":
                        FifthPlayCard.Image = Properties.Resources.Diamond_3;
                        break;
                    case "Clubs":
                        FifthPlayCard.Image = Properties.Resources.Clubs_3;
                        return;
                    default:
                        break;
                }
            }

        }

        private void FouthCard_Click(object sender, EventArgs e)
        {
                CardNumber1.Text = "3";
            if (Cardchoice1.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        FirstHandCard.Image = Properties.Resources.Hearts_4;
                        break;
                    case "Spades":
                        FirstHandCard.Image = Properties.Resources.Spades_4;
                        break;
                    case "Diamonds":
                        FirstHandCard.Image = Properties.Resources.Diamond_4;
                        break;
                    case "Clubs":
                        FirstHandCard.Image = Properties.Resources.Clubs_4;
                        return;
                    default:
                        break;
                }
            }
            if (Cardchoice1.Checked == true && Cardchoice2.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        SecondHandCard.Image = Properties.Resources.Hearts_4;
                        break;
                    case "Spades":
                        SecondHandCard.Image = Properties.Resources.Spades_4;
                        break;
                    case "Diamonds":
                        SecondHandCard.Image = Properties.Resources.Diamond_4;
                        break;
                    case "Clubs":
                        SecondHandCard.Image = Properties.Resources.Clubs_4;
                        return;
                    default:
                        break;
                }
            }
            if (Cardchoice2.Checked == true && ComCard1.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        FirstPlayCard.Image = Properties.Resources.Hearts_4;
                        break;
                    case "Spades":
                        FirstPlayCard.Image = Properties.Resources.Spades_4;
                        break;
                    case "Diamonds":
                        FirstPlayCard.Image = Properties.Resources.Diamond_4;
                        break;
                    case "Clubs":
                        FirstPlayCard.Image = Properties.Resources.Clubs_4;
                        return;
                    default:
                        break;
                }
            }
            if (ComCard1.Checked == true && ComCard2.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        SecondPlayCard.Image = Properties.Resources.Hearts_4;
                        break;
                    case "Spades":
                        SecondPlayCard.Image = Properties.Resources.Spades_4;
                        break;
                    case "Diamonds":
                        SecondPlayCard.Image = Properties.Resources.Diamond_4;
                        break;
                    case "Clubs":
                        SecondPlayCard.Image = Properties.Resources.Clubs_4;
                        return;
                    default:
                        break;
                }
            }
            if (ComCard2.Checked == true && ComCard3.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        ThirdPlayCard.Image = Properties.Resources.Hearts_4;
                        break;
                    case "Spades":
                        ThirdPlayCard.Image = Properties.Resources.Spades_4;
                        break;
                    case "Diamonds":
                        ThirdPlayCard.Image = Properties.Resources.Diamond_4;
                        break;
                    case "Clubs":
                        ThirdPlayCard.Image = Properties.Resources.Clubs_4;
                        return;
                    default:
                        break;
                }
            }
            if (ComCard3.Checked == true && ComCard4.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        FourthPlayCard.Image = Properties.Resources.Hearts_4;
                        break;
                    case "Spades":
                        FourthPlayCard.Image = Properties.Resources.Spades_4;
                        break;
                    case "Diamonds":
                        FourthPlayCard.Image = Properties.Resources.Diamond_4;
                        break;
                    case "Clubs":
                        FourthPlayCard.Image = Properties.Resources.Clubs_4;
                        return;
                    default:
                        break;
                }
            }
            if (ComCard4.Checked == true && ComCard5.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        FifthPlayCard.Image = Properties.Resources.Hearts_4;
                        break;
                    case "Spades":
                        FifthPlayCard.Image = Properties.Resources.Spades_4;
                        break;
                    case "Diamonds":
                        FifthPlayCard.Image = Properties.Resources.Diamond_4;
                        break;
                    case "Clubs":
                        FifthPlayCard.Image = Properties.Resources.Clubs_4;
                        return;
                    default:
                        break;
                }
            }

        }

        private void FifthCard_Click(object sender, EventArgs e)
        {
                CardNumber1.Text = "4";
            if (Cardchoice1.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        FirstHandCard.Image = Properties.Resources.Hearts_5;
                        break;
                    case "Spades":
                        FirstHandCard.Image = Properties.Resources.Spades_5;
                        break;
                    case "Diamonds":
                        FirstHandCard.Image = Properties.Resources.Diamond_5;
                        break;
                    case "Clubs":
                        FirstHandCard.Image = Properties.Resources.Clubs_5;
                        return;
                    default:
                        break;
                }
            }
            if (Cardchoice1.Checked == true && Cardchoice2.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        SecondHandCard.Image = Properties.Resources.Hearts_5;
                        break;
                    case "Spades":
                        SecondHandCard.Image = Properties.Resources.Spades_5;
                        break;
                    case "Diamonds":
                        SecondHandCard.Image = Properties.Resources.Diamond_5;
                        break;
                    case "Clubs":
                        SecondHandCard.Image = Properties.Resources.Clubs_5;
                        return;
                    default:
                        break;
                }
            }
            if (Cardchoice2.Checked == true && ComCard1.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        FirstPlayCard.Image = Properties.Resources.Hearts_5;
                        break;
                    case "Spades":
                        FirstPlayCard.Image = Properties.Resources.Spades_5;
                        break;
                    case "Diamonds":
                        FirstPlayCard.Image = Properties.Resources.Diamond_5;
                        break;
                    case "Clubs":
                        FirstPlayCard.Image = Properties.Resources.Clubs_5;
                        return;
                    default:
                        break;
                }
            }
            if (ComCard1.Checked == true && ComCard2.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        SecondPlayCard.Image = Properties.Resources.Hearts_5;
                        break;
                    case "Spades":
                        SecondPlayCard.Image = Properties.Resources.Spades_5;
                        break;
                    case "Diamonds":
                        SecondPlayCard.Image = Properties.Resources.Diamond_5;
                        break;
                    case "Clubs":
                        SecondPlayCard.Image = Properties.Resources.Clubs_5;
                        return;
                    default:
                        break;
                }
            }
            if (ComCard2.Checked == true && ComCard3.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        ThirdPlayCard.Image = Properties.Resources.Hearts_5;
                        break;
                    case "Spades":
                        ThirdPlayCard.Image = Properties.Resources.Spades_5;
                        break;
                    case "Diamonds":
                        ThirdPlayCard.Image = Properties.Resources.Diamond_5;
                        break;
                    case "Clubs":
                        ThirdPlayCard.Image = Properties.Resources.Clubs_5;
                        return;
                    default:
                        break;
                }
            }
            if (ComCard3.Checked == true && ComCard4.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        FourthPlayCard.Image = Properties.Resources.Hearts_5;
                        break;
                    case "Spades":
                        FourthPlayCard.Image = Properties.Resources.Spades_5;
                        break;
                    case "Diamonds":
                        FourthPlayCard.Image = Properties.Resources.Diamond_5;
                        break;
                    case "Clubs":
                        FourthPlayCard.Image = Properties.Resources.Clubs_5;
                        return;
                    default:
                        break;
                }
            }
            if (ComCard4.Checked == true && ComCard5.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        FifthPlayCard.Image = Properties.Resources.Hearts_5;
                        break;
                    case "Spades":
                        FifthPlayCard.Image = Properties.Resources.Spades_5;
                        break;
                    case "Diamonds":
                        FifthPlayCard.Image = Properties.Resources.Diamond_5;
                        break;
                    case "Clubs":
                        FifthPlayCard.Image = Properties.Resources.Clubs_5;
                        return;
                    default:
                        break;
                }
            }

        }

        private void SixthCard_Click(object sender, EventArgs e)
        {
                CardNumber1.Text = "5";
            if (Cardchoice1.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        FirstHandCard.Image = Properties.Resources.Hearts_6;
                        break;
                    case "Spades":
                        FirstHandCard.Image = Properties.Resources.Spades_6;
                        break;
                    case "Diamonds":
                        FirstHandCard.Image = Properties.Resources.Diamond_6;
                        break;
                    case "Clubs":
                        FirstHandCard.Image = Properties.Resources.Clubs_6;
                        return;
                    default:
                        break;
                }
            }
            if (Cardchoice1.Checked == true && Cardchoice2.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        SecondHandCard.Image = Properties.Resources.Hearts_6;
                        break;
                    case "Spades":
                        SecondHandCard.Image = Properties.Resources.Spades_6;
                        break;
                    case "Diamonds":
                        SecondHandCard.Image = Properties.Resources.Diamond_6;
                        break;
                    case "Clubs":
                        SecondHandCard.Image = Properties.Resources.Clubs_6;
                        return;
                    default:
                        break;
                }
            }
            if (Cardchoice2.Checked == true && ComCard1.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        FirstPlayCard.Image = Properties.Resources.Hearts_6;
                        break;
                    case "Spades":
                        FirstPlayCard.Image = Properties.Resources.Spades_6;
                        break;
                    case "Diamonds":
                        FirstPlayCard.Image = Properties.Resources.Diamond_6;
                        break;
                    case "Clubs":
                        FirstPlayCard.Image = Properties.Resources.Clubs_6;
                        return;
                    default:
                        break;
                }
            }
            if (ComCard1.Checked == true && ComCard2.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        SecondPlayCard.Image = Properties.Resources.Hearts_6;
                        break;
                    case "Spades":
                        SecondPlayCard.Image = Properties.Resources.Spades_6;
                        break;
                    case "Diamonds":
                        SecondPlayCard.Image = Properties.Resources.Diamond_6;
                        break;
                    case "Clubs":
                        SecondPlayCard.Image = Properties.Resources.Clubs_6;
                        return;
                    default:
                        break;
                }
            }
            if (ComCard2.Checked == true && ComCard3.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        ThirdPlayCard.Image = Properties.Resources.Hearts_6;
                        break;
                    case "Spades":
                        ThirdPlayCard.Image = Properties.Resources.Spades_6;
                        break;
                    case "Diamonds":
                        ThirdPlayCard.Image = Properties.Resources.Diamond_6;
                        break;
                    case "Clubs":
                        ThirdPlayCard.Image = Properties.Resources.Clubs_6;
                        return;
                    default:
                        break;
                }
            }
            if (ComCard3.Checked == true && ComCard4.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        FourthPlayCard.Image = Properties.Resources.Hearts_6;
                        break;
                    case "Spades":
                        FourthPlayCard.Image = Properties.Resources.Spades_6;
                        break;
                    case "Diamonds":
                        FourthPlayCard.Image = Properties.Resources.Diamond_6;
                        break;
                    case "Clubs":
                        FourthPlayCard.Image = Properties.Resources.Clubs_6;
                        return;
                    default:
                        break;
                }
            }
            if (ComCard4.Checked == true && ComCard5.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        FifthPlayCard.Image = Properties.Resources.Hearts_6;
                        break;
                    case "Spades":
                        FifthPlayCard.Image = Properties.Resources.Spades_6;
                        break;
                    case "Diamonds":
                        FifthPlayCard.Image = Properties.Resources.Diamond_6;
                        break;
                    case "Clubs":
                        FifthPlayCard.Image = Properties.Resources.Clubs_6;
                        return;
                    default:
                        break;
                }
            }

        }

        private void SeventhCard_Click(object sender, EventArgs e)
        {
                CardNumber1.Text = "6";
            if (Cardchoice1.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        FirstHandCard.Image = Properties.Resources.Hearts_7;
                        break;
                    case "Spades":
                        FirstHandCard.Image = Properties.Resources.Spades_7;
                        break;
                    case "Diamonds":
                        FirstHandCard.Image = Properties.Resources.Diamond_7;
                        break;
                    case "Clubs":
                        FirstHandCard.Image = Properties.Resources.Clubs_7;
                        return;
                    default:
                        break;
                }
            }
            if (Cardchoice1.Checked == true && Cardchoice2.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        SecondHandCard.Image = Properties.Resources.Hearts_7;
                        break;
                    case "Spades":
                        SecondHandCard.Image = Properties.Resources.Spades_7;
                        break;
                    case "Diamonds":
                        SecondHandCard.Image = Properties.Resources.Diamond_7;
                        break;
                    case "Clubs":
                        SecondHandCard.Image = Properties.Resources.Clubs_7;
                        return;
                    default:
                        break;
                }
            }
            if (Cardchoice2.Checked == true && ComCard1.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        FirstPlayCard.Image = Properties.Resources.Hearts_7;
                        break;
                    case "Spades":
                        FirstPlayCard.Image = Properties.Resources.Spades_7;
                        break;
                    case "Diamonds":
                        FirstPlayCard.Image = Properties.Resources.Diamond_7;
                        break;
                    case "Clubs":
                        FirstPlayCard.Image = Properties.Resources.Clubs_7;
                        return;
                    default:
                        break;
                }
            }
            if (ComCard1.Checked == true && ComCard2.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        SecondPlayCard.Image = Properties.Resources.Hearts_7;
                        break;
                    case "Spades":
                        SecondPlayCard.Image = Properties.Resources.Spades_7;
                        break;
                    case "Diamonds":
                        SecondPlayCard.Image = Properties.Resources.Diamond_7;
                        break;
                    case "Clubs":
                        SecondPlayCard.Image = Properties.Resources.Clubs_7;
                        return;
                    default:
                        break;
                }
            }
            if (ComCard2.Checked == true && ComCard3.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        ThirdPlayCard.Image = Properties.Resources.Hearts_7;
                        break;
                    case "Spades":
                        ThirdPlayCard.Image = Properties.Resources.Spades_7;
                        break;
                    case "Diamonds":
                        ThirdPlayCard.Image = Properties.Resources.Diamond_7;
                        break;
                    case "Clubs":
                        ThirdPlayCard.Image = Properties.Resources.Clubs_7;
                        return;
                    default:
                        break;
                }
            }
            if (ComCard3.Checked == true && ComCard4.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        FourthPlayCard.Image = Properties.Resources.Hearts_7;
                        break;
                    case "Spades":
                        FourthPlayCard.Image = Properties.Resources.Spades_7;
                        break;
                    case "Diamonds":
                        FourthPlayCard.Image = Properties.Resources.Diamond_7;
                        break;
                    case "Clubs":
                        FourthPlayCard.Image = Properties.Resources.Clubs_7;
                        return;
                    default:
                        break;
                }
            }
            if (ComCard4.Checked == true && ComCard5.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        FifthPlayCard.Image = Properties.Resources.Hearts_7;
                        break;
                    case "Spades":
                        FifthPlayCard.Image = Properties.Resources.Spades_7;
                        break;
                    case "Diamonds":
                        FifthPlayCard.Image = Properties.Resources.Diamond_7;
                        break;
                    case "Clubs":
                        FifthPlayCard.Image = Properties.Resources.Clubs_7;
                        return;
                    default:
                        break;
                }
            }

        }

        private void EigthCard_Click(object sender, EventArgs e)
        {
                CardNumber1.Text = "7";
            if (Cardchoice1.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        FirstHandCard.Image = Properties.Resources.Hearts_8;
                        break;
                    case "Spades":
                        FirstHandCard.Image = Properties.Resources.Spades_8;
                        break;
                    case "Diamonds":
                        FirstHandCard.Image = Properties.Resources.Diamond_8;
                        break;
                    case "Clubs":
                        FirstHandCard.Image = Properties.Resources.Clubs_8;
                        return;
                    default:
                        break;
                }
            }
            if (Cardchoice1.Checked == true && Cardchoice2.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        SecondHandCard.Image = Properties.Resources.Hearts_8;
                        break;
                    case "Spades":
                        SecondHandCard.Image = Properties.Resources.Spades_8;
                        break;
                    case "Diamonds":
                        SecondHandCard.Image = Properties.Resources.Diamond_8;
                        break;
                    case "Clubs":
                        SecondHandCard.Image = Properties.Resources.Clubs_8;
                        return;
                    default:
                        break;
                }
            }
            if (Cardchoice2.Checked == true && ComCard1.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        FirstPlayCard.Image = Properties.Resources.Hearts_8;
                        break;
                    case "Spades":
                        FirstPlayCard.Image = Properties.Resources.Spades_8;
                        break;
                    case "Diamonds":
                        FirstPlayCard.Image = Properties.Resources.Diamond_8;
                        break;
                    case "Clubs":
                        FirstPlayCard.Image = Properties.Resources.Clubs_8;
                        return;
                    default:
                        break;
                }
            }
            if (ComCard1.Checked == true && ComCard2.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        SecondPlayCard.Image = Properties.Resources.Hearts_8;
                        break;
                    case "Spades":
                        SecondPlayCard.Image = Properties.Resources.Spades_8;
                        break;
                    case "Diamonds":
                        SecondPlayCard.Image = Properties.Resources.Diamond_8;
                        break;
                    case "Clubs":
                        SecondPlayCard.Image = Properties.Resources.Clubs_8;
                        return;
                    default:
                        break;
                }
            }
            if (ComCard2.Checked == true && ComCard3.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        ThirdPlayCard.Image = Properties.Resources.Hearts_8;
                        break;
                    case "Spades":
                        ThirdPlayCard.Image = Properties.Resources.Spades_8;
                        break;
                    case "Diamonds":
                        ThirdPlayCard.Image = Properties.Resources.Diamond_8;
                        break;
                    case "Clubs":
                        ThirdPlayCard.Image = Properties.Resources.Clubs_8;
                        return;
                    default:
                        break;
                }
            }
            if (ComCard3.Checked == true && ComCard4.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        FourthPlayCard.Image = Properties.Resources.Hearts_8;
                        break;
                    case "Spades":
                        FourthPlayCard.Image = Properties.Resources.Spades_8;
                        break;
                    case "Diamonds":
                        FourthPlayCard.Image = Properties.Resources.Diamond_8;
                        break;
                    case "Clubs":
                        FourthPlayCard.Image = Properties.Resources.Clubs_8;
                        return;
                    default:
                        break;
                }
            }
            if (ComCard4.Checked == true && ComCard5.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        FifthPlayCard.Image = Properties.Resources.Hearts_8;
                        break;
                    case "Spades":
                        FifthPlayCard.Image = Properties.Resources.Spades_8;
                        break;
                    case "Diamonds":
                        FifthPlayCard.Image = Properties.Resources.Diamond_8;
                        break;
                    case "Clubs":
                        FifthPlayCard.Image = Properties.Resources.Clubs_8;
                        return;
                    default:
                        break;
                }
            }

        }

        private void NinthCard_Click(object sender, EventArgs e)
        {
                CardNumber1.Text = "8";
            if (Cardchoice1.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        FirstHandCard.Image = Properties.Resources.Hearts_9;
                        break;
                    case "Spades":
                        FirstHandCard.Image = Properties.Resources.Spades_9;
                        break;
                    case "Diamonds":
                        FirstHandCard.Image = Properties.Resources.Diamond_9;
                        break;
                    case "Clubs":
                        FirstHandCard.Image = Properties.Resources.Clubs_9;
                        return;
                    default:
                        break;
                }
            }
            if (Cardchoice1.Checked == true && Cardchoice2.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        SecondHandCard.Image = Properties.Resources.Hearts_9;
                        break;
                    case "Spades":
                        SecondHandCard.Image = Properties.Resources.Spades_9;
                        break;
                    case "Diamonds":
                        SecondHandCard.Image = Properties.Resources.Diamond_9;
                        break;
                    case "Clubs":
                        SecondHandCard.Image = Properties.Resources.Clubs_9;
                        return;
                    default:
                        break;
                }
            }
            if (Cardchoice2.Checked == true && ComCard1.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        FirstPlayCard.Image = Properties.Resources.Hearts_9;
                        break;
                    case "Spades":
                        FirstPlayCard.Image = Properties.Resources.Spades_9;
                        break;
                    case "Diamonds":
                        FirstPlayCard.Image = Properties.Resources.Diamond_9;
                        break;
                    case "Clubs":
                        FirstPlayCard.Image = Properties.Resources.Clubs_9;
                        return;
                    default:
                        break;
                }
            }
            if (ComCard1.Checked == true && ComCard2.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        SecondPlayCard.Image = Properties.Resources.Hearts_9;
                        break;
                    case "Spades":
                        SecondPlayCard.Image = Properties.Resources.Spades_9;
                        break;
                    case "Diamonds":
                        SecondPlayCard.Image = Properties.Resources.Diamond_9;
                        break;
                    case "Clubs":
                        SecondPlayCard.Image = Properties.Resources.Clubs_9;
                        return;
                    default:
                        break;
                }
            }
            if (ComCard2.Checked == true && ComCard3.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        ThirdPlayCard.Image = Properties.Resources.Hearts_9;
                        break;
                    case "Spades":
                        ThirdPlayCard.Image = Properties.Resources.Spades_9;
                        break;
                    case "Diamonds":
                        ThirdPlayCard.Image = Properties.Resources.Diamond_9;
                        break;
                    case "Clubs":
                        ThirdPlayCard.Image = Properties.Resources.Clubs_9;
                        return;
                    default:
                        break;
                }
            }
            if (ComCard3.Checked == true && ComCard4.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        FourthPlayCard.Image = Properties.Resources.Hearts_9;
                        break;
                    case "Spades":
                        FourthPlayCard.Image = Properties.Resources.Spades_9;
                        break;
                    case "Diamonds":
                        FourthPlayCard.Image = Properties.Resources.Diamond_9;
                        break;
                    case "Clubs":
                        FourthPlayCard.Image = Properties.Resources.Clubs_9;
                        return;
                    default:
                        break;
                }
            }
            if (ComCard4.Checked == true && ComCard5.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        FifthPlayCard.Image = Properties.Resources.Hearts_9;
                        break;
                    case "Spades":
                        FifthPlayCard.Image = Properties.Resources.Spades_9;
                        break;
                    case "Diamonds":
                        FifthPlayCard.Image = Properties.Resources.Diamond_9;
                        break;
                    case "Clubs":
                        FifthPlayCard.Image = Properties.Resources.Clubs_9;
                        return;
                    default:
                        break;
                }
            }

        }

        private void TenthCard_Click(object sender, EventArgs e)
        {
                CardNumber1.Text = "9";
            if (Cardchoice1.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        FirstHandCard.Image = Properties.Resources.Hearts_10;
                        break;
                    case "Spades":
                        FirstHandCard.Image = Properties.Resources.Spades_10;
                        break;
                    case "Diamonds":
                        FirstHandCard.Image = Properties.Resources.Diamond_10;
                        break;
                    case "Clubs":
                        FirstHandCard.Image = Properties.Resources.Clubs_10;
                        return;
                    default:
                        break;
                }
            }
            if (Cardchoice1.Checked == true && Cardchoice2.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        SecondHandCard.Image = Properties.Resources.Hearts_10;
                        break;
                    case "Spades":
                        SecondHandCard.Image = Properties.Resources.Spades_10;
                        break;
                    case "Diamonds":
                        SecondHandCard.Image = Properties.Resources.Diamond_10;
                        break;
                    case "Clubs":
                        SecondHandCard.Image = Properties.Resources.Clubs_10;
                        return;
                    default:
                        break;
                }
            }
            if (Cardchoice2.Checked == true && ComCard1.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        FirstPlayCard.Image = Properties.Resources.Hearts_10;
                        break;
                    case "Spades":
                        FirstPlayCard.Image = Properties.Resources.Spades_10;
                        break;
                    case "Diamonds":
                        FirstPlayCard.Image = Properties.Resources.Diamond_10;
                        break;
                    case "Clubs":
                        FirstPlayCard.Image = Properties.Resources.Clubs_10;
                        return;
                    default:
                        break;
                }
            }
            if (ComCard1.Checked == true && ComCard2.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        SecondPlayCard.Image = Properties.Resources.Hearts_10;
                        break;
                    case "Spades":
                        SecondPlayCard.Image = Properties.Resources.Spades_10;
                        break;
                    case "Diamonds":
                        SecondPlayCard.Image = Properties.Resources.Diamond_10;
                        break;
                    case "Clubs":
                        SecondPlayCard.Image = Properties.Resources.Clubs_10;
                        return;
                    default:
                        break;
                }
            }
            if (ComCard2.Checked == true && ComCard3.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        ThirdPlayCard.Image = Properties.Resources.Hearts_10;
                        break;
                    case "Spades":
                        ThirdPlayCard.Image = Properties.Resources.Spades_10;
                        break;
                    case "Diamonds":
                        ThirdPlayCard.Image = Properties.Resources.Diamond_10;
                        break;
                    case "Clubs":
                        ThirdPlayCard.Image = Properties.Resources.Clubs_10;
                        return;
                    default:
                        break;
                }
            }
            if (ComCard3.Checked == true && ComCard4.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        FourthPlayCard.Image = Properties.Resources.Hearts_10;
                        break;
                    case "Spades":
                        FourthPlayCard.Image = Properties.Resources.Spades_10;
                        break;
                    case "Diamonds":
                        FourthPlayCard.Image = Properties.Resources.Diamond_10;
                        break;
                    case "Clubs":
                        FourthPlayCard.Image = Properties.Resources.Clubs_10;
                        return;
                    default:
                        break;
                }
            }
            if (ComCard4.Checked == true && ComCard5.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        FifthPlayCard.Image = Properties.Resources.Hearts_10;
                        break;
                    case "Spades":
                        FifthPlayCard.Image = Properties.Resources.Spades_10;
                        break;
                    case "Diamonds":
                        FifthPlayCard.Image = Properties.Resources.Diamond_10;
                        break;
                    case "Clubs":
                        FifthPlayCard.Image = Properties.Resources.Clubs_10;
                        return;
                    default:
                        break;
                }
            }
        }

        private void JackCard_Click(object sender, EventArgs e)
        {
          CardNumber1.Text = "10";
            if (Cardchoice1.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        FirstHandCard.Image = Properties.Resources.Hearts_J;
                        break;
                    case "Spades":
                        FirstHandCard.Image = Properties.Resources.Spades_J;
                        break;
                    case "Diamonds":
                        FirstHandCard.Image = Properties.Resources.Diamond_J;
                        break;
                    case "Clubs":
                        FirstHandCard.Image = Properties.Resources.Clubs_J;
                        return;
                    default:
                        break;
                }
            }
            if (Cardchoice1.Checked == true && Cardchoice2.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        SecondHandCard.Image = Properties.Resources.Hearts_J;
                        break;
                    case "Spades":
                        SecondHandCard.Image = Properties.Resources.Spades_J;
                        break;
                    case "Diamonds":
                        SecondHandCard.Image = Properties.Resources.Diamond_J;
                        break;
                    case "Clubs":
                        SecondHandCard.Image = Properties.Resources.Clubs_J;
                        return;
                    default:
                        break;
                }
            }
            if (Cardchoice2.Checked == true && ComCard1.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        FirstPlayCard.Image = Properties.Resources.Hearts_J;
                        break;
                    case "Spades":
                        FirstPlayCard.Image = Properties.Resources.Spades_J;
                        break;
                    case "Diamonds":
                        FirstPlayCard.Image = Properties.Resources.Diamond_J;
                        break;
                    case "Clubs":
                        FirstPlayCard.Image = Properties.Resources.Clubs_J;
                        return;
                    default:
                        break;
                }
            }
            if (ComCard1.Checked == true && ComCard2.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        SecondPlayCard.Image = Properties.Resources.Hearts_J;
                        break;
                    case "Spades":
                        SecondPlayCard.Image = Properties.Resources.Spades_J;
                        break;
                    case "Diamonds":
                        SecondPlayCard.Image = Properties.Resources.Diamond_J;
                        break;
                    case "Clubs":
                        SecondPlayCard.Image = Properties.Resources.Clubs_J;
                        return;
                    default:
                        break;
                }
            }
            if (ComCard2.Checked == true && ComCard3.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        ThirdPlayCard.Image = Properties.Resources.Hearts_J;
                        break;
                    case "Spades":
                        ThirdPlayCard.Image = Properties.Resources.Spades_J;
                        break;
                    case "Diamonds":
                        ThirdPlayCard.Image = Properties.Resources.Diamond_J;
                        break;
                    case "Clubs":
                        ThirdPlayCard.Image = Properties.Resources.Clubs_J;
                        return;
                    default:
                        break;
                }
            }
            if (ComCard3.Checked == true && ComCard4.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        FourthPlayCard.Image = Properties.Resources.Hearts_J;
                        break;
                    case "Spades":
                        FourthPlayCard.Image = Properties.Resources.Spades_J;
                        break;
                    case "Diamonds":
                        FourthPlayCard.Image = Properties.Resources.Diamond_J;
                        break;
                    case "Clubs":
                        FourthPlayCard.Image = Properties.Resources.Clubs_J;
                        return;
                    default:
                        break;
                }
            }
            if (ComCard4.Checked == true && ComCard5.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        FifthPlayCard.Image = Properties.Resources.Hearts_J;
                        break;
                    case "Spades":
                        FifthPlayCard.Image = Properties.Resources.Spades_J;
                        break;
                    case "Diamonds":
                        FifthPlayCard.Image = Properties.Resources.Diamond_J;
                        break;
                    case "Clubs":
                        FifthPlayCard.Image = Properties.Resources.Clubs_J;
                        return;
                    default:
                        break;
                }
            }
        }

        private void QueenCard_Click(object sender, EventArgs e)
        {
            CardNumber1.Text = "11";
            if (Cardchoice1.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        FirstHandCard.Image = Properties.Resources.Hearts_Q;
                        break;
                    case "Spades":
                        FirstHandCard.Image = Properties.Resources.Spades_Q;
                        break;
                    case "Diamonds":
                        FirstHandCard.Image = Properties.Resources.Diamond_Q;
                        break;
                    case "Clubs":
                        FirstHandCard.Image = Properties.Resources.Clubs_Q;
                        return;
                    default:
                        break;
                }
            }
            if (Cardchoice1.Checked == true && Cardchoice2.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        SecondHandCard.Image = Properties.Resources.Hearts_Q;
                        break;
                    case "Spades":
                        SecondHandCard.Image = Properties.Resources.Spades_Q;
                        break;
                    case "Diamonds":
                        SecondHandCard.Image = Properties.Resources.Diamond_Q;
                        break;
                    case "Clubs":
                        SecondHandCard.Image = Properties.Resources.Clubs_Q;
                        return;
                    default:
                        break;
                }
            }
            if (Cardchoice2.Checked == true && ComCard1.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        FirstPlayCard.Image = Properties.Resources.Hearts_Q;
                        break;
                    case "Spades":
                        FirstPlayCard.Image = Properties.Resources.Spades_Q;
                        break;
                    case "Diamonds":
                        FirstPlayCard.Image = Properties.Resources.Diamond_Q;
                        break;
                    case "Clubs":
                        FirstPlayCard.Image = Properties.Resources.Clubs_Q;
                        return;
                    default:
                        break;
                }
            }
            if (ComCard1.Checked == true && ComCard2.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        SecondPlayCard.Image = Properties.Resources.Hearts_Q;
                        break;
                    case "Spades":
                        SecondPlayCard.Image = Properties.Resources.Spades_Q;
                        break;
                    case "Diamonds":
                        SecondPlayCard.Image = Properties.Resources.Diamond_Q;
                        break;
                    case "Clubs":
                        SecondPlayCard.Image = Properties.Resources.Clubs_Q;
                        return;
                    default:
                        break;
                }
            }
            if (ComCard2.Checked == true && ComCard3.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        ThirdPlayCard.Image = Properties.Resources.Hearts_Q;
                        break;
                    case "Spades":
                        ThirdPlayCard.Image = Properties.Resources.Spades_Q;
                        break;
                    case "Diamonds":
                        ThirdPlayCard.Image = Properties.Resources.Diamond_Q;
                        break;
                    case "Clubs":
                        ThirdPlayCard.Image = Properties.Resources.Clubs_Q;
                        return;
                    default:
                        break;
                }
            }
            if (ComCard3.Checked == true && ComCard4.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        FourthPlayCard.Image = Properties.Resources.Hearts_Q;
                        break;
                    case "Spades":
                        FourthPlayCard.Image = Properties.Resources.Spades_Q;
                        break;
                    case "Diamonds":
                        FourthPlayCard.Image = Properties.Resources.Diamond_Q;
                        break;
                    case "Clubs":
                        FourthPlayCard.Image = Properties.Resources.Clubs_Q;
                        return;
                    default:
                        break;
                }
            }
            if (ComCard4.Checked == true && ComCard5.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        FifthPlayCard.Image = Properties.Resources.Hearts_Q;
                        break;
                    case "Spades":
                        FifthPlayCard.Image = Properties.Resources.Spades_Q;
                        break;
                    case "Diamonds":
                        FifthPlayCard.Image = Properties.Resources.Diamond_Q;
                        break;
                    case "Clubs":
                        FifthPlayCard.Image = Properties.Resources.Clubs_Q;
                        return;
                    default:
                        break;
                }
            }

        }

        private void KingCard_Click(object sender, EventArgs e)
        {
            CardNumber1.Text = "12";
            if (Cardchoice1.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        FirstHandCard.Image = Properties.Resources.Hearts_K;
                        break;
                    case "Spades":
                        FirstHandCard.Image = Properties.Resources.Spades_K;
                        break;
                    case "Diamonds":
                        FirstHandCard.Image = Properties.Resources.Diamond_K;
                        break;
                    case "Clubs":
                        FirstHandCard.Image = Properties.Resources.Clubs_K;
                        return;
                    default:
                        break;
                }
            }
            if (Cardchoice1.Checked == true && Cardchoice2.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        SecondHandCard.Image = Properties.Resources.Hearts_K;
                        break;
                    case "Spades":
                        SecondHandCard.Image = Properties.Resources.Spades_K;
                        break;
                    case "Diamonds":
                        SecondHandCard.Image = Properties.Resources.Diamond_K;
                        break;
                    case "Clubs":
                        SecondHandCard.Image = Properties.Resources.Clubs_K;
                        return;
                    default:
                        break;
                }
            }
            if (Cardchoice2.Checked == true && ComCard1.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        FirstPlayCard.Image = Properties.Resources.Hearts_K;
                        break;
                    case "Spades":
                        FirstPlayCard.Image = Properties.Resources.Spades_K;
                        break;
                    case "Diamonds":
                        FirstPlayCard.Image = Properties.Resources.Diamond_K;
                        break;
                    case "Clubs":
                        FirstPlayCard.Image = Properties.Resources.Clubs_K;
                        return;
                    default:
                        break;
                }
            }
            if (ComCard1.Checked == true && ComCard2.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        SecondPlayCard.Image = Properties.Resources.Hearts_K;
                        break;
                    case "Spades":
                        SecondPlayCard.Image = Properties.Resources.Spades_K;
                        break;
                    case "Diamonds":
                        SecondPlayCard.Image = Properties.Resources.Diamond_K;
                        break;
                    case "Clubs":
                        SecondPlayCard.Image = Properties.Resources.Clubs_K;
                        return;
                    default:
                        break;
                }
            }
            if (ComCard2.Checked == true && ComCard3.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        ThirdPlayCard.Image = Properties.Resources.Hearts_K;
                        break;
                    case "Spades":
                        ThirdPlayCard.Image = Properties.Resources.Spades_K;
                        break;
                    case "Diamonds":
                        ThirdPlayCard.Image = Properties.Resources.Diamond_K;
                        break;
                    case "Clubs":
                        ThirdPlayCard.Image = Properties.Resources.Clubs_K;
                        return;
                    default:
                        break;
                }
            }
            if (ComCard3.Checked == true && ComCard4.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        FourthPlayCard.Image = Properties.Resources.Hearts_K;
                        break;
                    case "Spades":
                        FourthPlayCard.Image = Properties.Resources.Spades_K;
                        break;
                    case "Diamonds":
                        FourthPlayCard.Image = Properties.Resources.Diamond_K;
                        break;
                    case "Clubs":
                        FourthPlayCard.Image = Properties.Resources.Clubs_K;
                        return;
                    default:
                        break;
                }
            }
            if (ComCard4.Checked == true && ComCard5.Checked == false)
            {
                switch (CardSuit1.Text)
                {
                    case "Hearts":
                        FifthPlayCard.Image = Properties.Resources.Hearts_K;
                        break;
                    case "Spades":
                        FifthPlayCard.Image = Properties.Resources.Spades_K;
                        break;
                    case "Diamonds":
                        FifthPlayCard.Image = Properties.Resources.Diamond_K;
                        break;
                    case "Clubs":
                        FifthPlayCard.Image = Properties.Resources.Clubs_K;
                        return;
                    default:
                        break;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            check++;
            label1.Text = Convert.ToString(check);
            rank = Convert.ToInt16(CardNumber1.Text);

            switch (CardSuit1.Text)
            {
                case "Hearts":
                    suit = 0;
                    currentHand.Add(GameDeck[suit + rank]);
                    GameDeck[suit + rank].available = false;
                    break;
                case "Clubs":
                    suit = 13;
                    currentHand.Add(GameDeck[suit + rank]);
                    GameDeck[suit + rank].available = false;
                    break;
                case "Diamonds":
                    suit = 26;
                    currentHand.Add(GameDeck[suit + rank]);
                    GameDeck[suit + rank].available = false;
                    break;
                case "Spades":
                    suit = 39;
                    currentHand.Add(GameDeck[suit + rank]);
                    GameDeck[suit + rank].available = false;
                    break;
                default:
                    break;
            }

            if(currentHand.Count == 2 || currentHand.Count == 5 || currentHand.Count == 6 || currentHand.Count == 7)
            {
                pairnumber.Text = Convert.ToString(probabilityCalculater.ProbabilityOfPair(currentHand,GameDeck)) + "%";
                twopairnumber.Text = Convert.ToString(probabilityCalculater.ProbabilityOfTwoPair(currentHand, GameDeck)) + "%";
                threeofkindnumber.Text = Convert.ToString(probabilityCalculater.ProbabilityOfThreeOfaKind(currentHand, GameDeck)) + "%";
                fourofkindnumber.Text = Convert.ToString(probabilityCalculater.ProbabilityOfFourOfaKind(currentHand, GameDeck)) + "%";
                fullhousenumber.Text = Convert.ToString(probabilityCalculater.ProbabilityOfFullHouse(currentHand, GameDeck)) + "%";
            }
            else if(currentHand.Count == 1)
            {
                MessageBox.Show("The chance will only update on legal tables i.e. 2 Cards, 5 Cards, 6 Cards, or 7 Cards");
            }

            if (check == 1)
            {
                if (FirstBox.Visible == true && CardSuit1.Text == "label1" || CardNumber1.Text == "label3")
                    check--;
                else
                {
                    CardNumber1.Text = CardNumber1.Text;
                    CardSuit1.Text = CardSuit1.Text;
                    Cardchoice1.Checked = true;
                    FirstBox.Visible = false;
                    SecoundBox.Visible = true;
                }

            }
            
            if (check == 2)
            {
                if (SecoundBox.Visible == true && Cardchoice1.Checked==false)
                    check--;
                else
                {
                    CardNumber1.Text = CardNumber1.Text;
                    CardSuit1.Text = CardSuit1.Text;
                    Cardchoice2.Checked = true;
                    SecoundBox.Visible = false;
                    CommunityBox.Visible = true;
                }

            }

            if (check == 3)
            {
                if (CommunityBox.Visible == true && Cardchoice2.Checked==false)
                    check--;
                else {
                    ComCard1.Checked = true;
                    CardNumber1.Text = CardNumber1.Text;
                    CardSuit1.Text = CardSuit1.Text;
                }

            }

            if (check == 4)
            {
                if (CommunityBox.Visible == true && ComCard1.Checked == false)
                    check--;
                else
                {
                    ComCard2.Checked = true;
                    CardNumber1.Text = CardNumber1.Text;
                    CardSuit1.Text = CardSuit1.Text;
                }
            }
            if (check == 5)
            {
                if (CommunityBox.Visible == true && ComCard2.Checked == false)
                    check--;
                else
                {
                    ComCard3.Checked = true;
                    CardNumber1.Text = CardNumber1.Text;
                    CardSuit1.Text = CardSuit1.Text;
                }
            }
            if (check == 6 )
            {
                if (CommunityBox.Visible == true && ComCard3.Checked == false)
                    check--;
                else
                {
                    ComCard4.Checked = true;
                    CardNumber1.Text = CardNumber1.Text;
                    CardSuit1.Text = CardSuit1.Text;
                }
            }

            if (check == 7)
            {
                if (CommunityBox.Visible == true && ComCard4.Checked == false)
                    check--;
                else
                {
                    ComCard5.Checked = true;
                    CardNumber1.Text = CardNumber1.Text;
                    CardSuit1.Text = CardSuit1.Text;
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
                Cardchoice1.Checked = false;
                Cardchoice2.Checked = false;
                ComCard1.Checked = false;
                ComCard2.Checked = false;
                ComCard3.Checked = false;
                ComCard4.Checked = false;
                ComCard5.Checked = false;

                FirstHandCard.Image = null;
                SecondHandCard.Image = null;
                FirstPlayCard.Image = null;
                SecondPlayCard.Image = null;
                ThirdPlayCard.Image = null;
                FourthPlayCard.Image = null;
                FifthPlayCard.Image = null;

                pairnumber.Text = "";
                twopairnumber.Text = "";
                fourofkindnumber.Text = "";


                //reset GameDeck and currentHand
                currentHand.Clear();
                foreach(BuildDeck.Card c in GameDeck)
                {
                    c.available = true;
                }

            }
        }
    }
}
