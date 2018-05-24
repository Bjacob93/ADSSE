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
            MessageBox.Show("hello");
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
        }

        private void ClubsBox1_CheckedChanged(object sender, EventArgs e)
        {
            HeartsBox1.Checked = false;
            SpadesBox1.Checked = false;
            DiamondBox1.Checked = false;
        }

        private void DiamondBox1_CheckedChanged(object sender, EventArgs e)
        {
            HeartsBox1.Checked = false;
            SpadesBox1.Checked = false;
            ClubsBox1.Checked = false;
        }

        private void SpadesBox1_CheckedChanged(object sender, EventArgs e)
        {
            HeartsBox1.Checked = false;
            ClubsBox1.Checked = false;
            DiamondBox1.Checked = false;
        }
        private void HeartsBox2_CheckedChanged(object sender, EventArgs e)
        {
            ClubsBox2.Checked = false;
            SpadesBox2.Checked = false;
            DiamondBox2.Checked = false;
        }

        private void ClubsBox2_CheckedChanged(object sender, EventArgs e)
        {
            HeartsBox2.Checked = false;
            SpadesBox2.Checked = false;
            DiamondBox2.Checked = false;
        }

        private void DiamondBox2_CheckedChanged(object sender, EventArgs e)
        {
            HeartsBox2.Checked = false;
            SpadesBox2.Checked = false;
            ClubsBox2.Checked = false;
        }

        private void SpadesBox2_CheckedChanged(object sender, EventArgs e)
        {
            HeartsBox2.Checked = false;
            ClubsBox2.Checked = false;
            DiamondBox2.Checked = false;
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
    }
}
