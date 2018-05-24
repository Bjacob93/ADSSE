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
            SpadesBox2.Text = SpadesBox2.Text;
        }

        private void ClubsBox3_CheckedChanged(object sender, EventArgs e)
        {
            HeartsBox3.Checked = false;
            SpadesBox3.Checked = false;
            DiamondBox3.Checked = false;
        }

        private void DiamondBox3_CheckedChanged(object sender, EventArgs e)
        {
            HeartsBox3.Checked = false;
            SpadesBox3.Checked = false;
            ClubsBox3.Checked = false;
        }

        private void SpadesBox3_CheckedChanged(object sender, EventArgs e)
        {
            HeartsBox3.Checked = false;
            ClubsBox3.Checked = false;
            DiamondBox3.Checked = false;
        }

        private void HeartsBox3_CheckedChanged(object sender, EventArgs e)
        {
            ClubsBox3.Checked = false;
            SpadesBox3.Checked = false;
            DiamondBox3.Checked = false;
        }
       void setCard()
        {
        }

        private void AceCard_Click(object sender, EventArgs e)
        {
            CardNumber1.Text = "1";
        }
    }
}
