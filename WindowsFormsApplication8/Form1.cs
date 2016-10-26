using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/**

 *

 * Name: Dylan Fyvie

 * Teacher: Mr. Hardmen

 * Assignment #2a, Program #

 * Date Last Modified: 10/19/2016

 *

 */

namespace WindowsFormsApplication8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbNameQuest_TextChanged(object sender, EventArgs e)
        {
            String userName;

            lblResult.Text = ("Hello " + txbNameQuest.Text + " How Is Your Day");

        

    }
        //Each Of these are diplaying An emotion to the user
        private void rdbStupidious_CheckedChanged(object sender, EventArgs e)
        {
            lblDisplay.Text = ("Your Not Stupidious You Just Want To Click This Button");
        }

        private void rdbGood_CheckedChanged(object sender, EventArgs e)
        {
            lblDisplay.Text = ("Wonderful");
        }

        private void rdbGrinch_CheckedChanged(object sender, EventArgs e)
        {
            lblDisplay.Text = ("Well Just Dont Steal Christmas");
        }

     

        
    }
}
